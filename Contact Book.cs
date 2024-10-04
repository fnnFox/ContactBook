using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactBook
{
	public partial class ContactBook : Form
	{
		string FilePath = "file.contact";
		int CollapsedPanelHeight;

		/// <summary>
		/// 0 = Add Mode
		/// 1 = Edit Mode
		/// </summary>
		bool Mode;
		bool IsAnyDeleted = false;

		int TotalBlocks;
		int Maximum;
		int CurrentBlock;
		int DataBegin = 32 * SymbolSize; 

		FileStream fileStream;
		
		static int BlockSize = Record.blockSize;
		static int SymbolSize = Record.symbolSize;

		Record CurrentRecord;
		List<(Record record, int index)> SearchResult; 

		public ContactBook()
		{
			InitializeComponent();
			CollapsedPanelHeight = splitContainer.Panel2.Height;
			Height -= CollapsedPanelHeight;
			splitContainer.Panel2Collapsed = true;
			this.FormClosing += Notebook_Saving;

			this.firstName_search.TextChanged += searchBox_update;
			this.lastName_search.TextChanged += searchBox_update;
			this.middleName_search.TextChanged += searchBox_update;
			this.birthDate_search.TextChanged += searchBox_update;
			this.phoneNumber_search.TextChanged += searchBox_update;
			this.country_check.CheckedChanged += searchBox_update;
			this.city_check.CheckedChanged += searchBox_update;
			this.anything_search.TextChanged += anything_search_update;
			this.anything_check.CheckedChanged += anything_check_update;
			
			for (int row = 0; row < main_table.RowCount; row++)
			{
				if (main_table.GetControlFromPosition(0, row) is System.Windows.Forms.Label label)
					label.Click += label_onClick;
			}
			for (int row = 0; row < search_table.RowCount; row++)
			{
				if (search_table.GetControlFromPosition(0, row) is System.Windows.Forms.Label label)
					label.Click += label_onClick;
			}


			CurrentRecord = new Record();

			fileStream = new FileStream(FilePath, FileMode.OpenOrCreate);
			fileStream.Seek(DataBegin, SeekOrigin.Begin);
			byte[] sizeCheck = new byte[BlockSize];
			while (fileStream.Read(sizeCheck, 0, BlockSize) >= BlockSize)
			{
				if (sizeCheck[0] == 1)
					IsAnyDeleted = true;

				TotalBlocks++;
			}
			Maximum = TotalBlocks;

			if (TotalBlocks == 0)
			{
				addBlock();
			}
			else
			{
				byte[] lastBlockOpened = new byte[SymbolSize];
				fileStream.Seek(0, SeekOrigin.Begin);
				fileStream.Read(lastBlockOpened, 0, SymbolSize);
				CurrentBlock = BitConverter.ToInt16(lastBlockOpened, 0);
				readBlock();
				updateBoxes();
			}
		}
		#region Label Clicks
		private void anything_search_update(object sender, EventArgs e)
		{
			anything_check.Checked = anything_search.TextLength > 0;
		}
		private void anything_check_update(object sender, EventArgs e)
		{
			for (int i = 0; i < search_table.RowCount; i++)
			{
				search_table.GetControlFromPosition(1, i).Enabled = !anything_check.Checked;
				search_table.GetControlFromPosition(2, i).Enabled = !anything_check.Checked;
			}
		}
		private void label_onClick(object sender, EventArgs e)
		{
			if (sender is System.Windows.Forms.Label label)
			{
				if (label.Parent is TableLayoutPanel table)
				{
					table.GetControlFromPosition(1, table.GetRow(label)).Focus();
				}
			}
		}
		private void searchBox_update(object sender, EventArgs e)
		{
			if (sender is Control ctl)
			{
				if (ctl.Parent is TableLayoutPanel table)
				{
					if (ctl is TextBox tb)
					{
						(table.GetControlFromPosition(2, table.GetRow(tb)) as CheckBox).Checked = tb.TextLength > 0;
					}
					if (ctl is MaskedTextBox mtb)
					{
						(table.GetControlFromPosition(2, table.GetRow(mtb)) as CheckBox).Checked = mtb.MaskCompleted;
					}
				}
			}
		}
		#endregion

		#region Button Clicks
		private void search_button_Click(object sender, EventArgs e)
		{
			if (splitContainer.Panel2Collapsed)
			{
				splitContainer.Panel2Collapsed = false;
				Height += CollapsedPanelHeight;
				search_button.Text = "Поиск ▼";
			}
			else
			{
				splitContainer.Panel2Collapsed = true;
				Height -= CollapsedPanelHeight;
				search_button.Text = "Поиск ▲";
			}
		}
		private void add_button_Click(object sender, EventArgs e)
		{
			addBlock();
		}
		private void edit_button_Click(object sender, EventArgs e)
		{
			Mode = true;

			editMode(true);
		}
		private void ok_button_Click(object sender, EventArgs e)
		{
			/////////////////
			// SAVING CODE //
			/////////////////

			CurrentRecord = new Record(
				firstName_box.Text,
				lastName_box.Text,
				middleName_box.Text,
				birthDate_box.Text,
				phoneNumber_box.Text,
				country_box.Text,
				city_box.Text,
				email_box.Text,
				website_box.Text,
				comment_box.Text
			);

			if (!Mode)
			{
				CurrentBlock = TotalBlocks;
				fileStream.Seek(CurrentBlock * BlockSize + DataBegin, SeekOrigin.Begin);
				TotalBlocks++;
			}

			fileStream.Seek(CurrentBlock * BlockSize + DataBegin, SeekOrigin.Begin);
			byte[] bytes = CurrentRecord.Serialize2Byte();
			fileStream.Write(bytes, 0, BlockSize);
			fileStream.Flush();

			editMode(false);

			readBlock();
			updateBoxes();
		}
		private void cancel_button_Click(object sender, EventArgs e)
		{
			/*foreach (Control control in mainTable.Controls)
			{
				if (control is TextBox || control is MaskedTextBox)
					control.Enabled = false;
			}*/
			editMode(false);
			updateBoxes();
		}
		private void delete_button_Click(object sender, EventArgs e)
		{
			fileStream.Seek(CurrentBlock * BlockSize + DataBegin + 1, SeekOrigin.Begin);
			fileStream.WriteByte(1);
			fileStream.Flush();
			CurrentBlock += CurrentBlock == 0 ? +1 : -1;
			//TotalBlocks--;
			IsAnyDeleted = true;
			readBlock();
			updateBoxes();
		}
		private void goSearch_button_Click(object sender, EventArgs e)
		{
			SearchResult = makeList();
			listBox.Items.Clear();
			foreach (var i in SearchResult)
			{
				listBox.Items.Add((i.index + 1) + ".  " + i.record.ToString());
			}
		}
		private void listBox_Select(object sender, EventArgs e)
		{
			CurrentRecord = SearchResult[listBox.SelectedIndex].record;
			CurrentBlock = SearchResult[listBox.SelectedIndex].index;
			updateBoxes();
		}
		
		#endregion

		#region Navigation
		private void firstPosition_button_Click(object sender, EventArgs e)
		{
			int tempPos = 0;
			while (tempPos < TotalBlocks - 1)
			{
				fileStream.Seek(tempPos * BlockSize + DataBegin + 1, SeekOrigin.Begin);
				if (fileStream.ReadByte() == 0)
				{
					CurrentBlock = tempPos;
					break;
				}
				tempPos++;
			}
			CurrentBlock = tempPos;
			readBlock();
			updateBoxes();
		}
		private void lastPosition_button_Click(object sender, EventArgs e)
		{
			int tempPos = TotalBlocks - 1;
			while (tempPos > 0)
			{
				fileStream.Seek(tempPos * BlockSize + DataBegin + 1, SeekOrigin.Begin);
				if (fileStream.ReadByte() == 0)
				{
					CurrentBlock = tempPos;
					break;
				}
				tempPos--;
			}
			CurrentBlock = tempPos;
			readBlock();
			updateBoxes();
		}
		private void nextPosition_button_Click(object sender, EventArgs e)
		{
			if (CurrentBlock < TotalBlocks - 1)
			{
				int tempPos = CurrentBlock + 1;
				while (tempPos < TotalBlocks - 1)
				{
					fileStream.Seek(tempPos * BlockSize + DataBegin + 1, SeekOrigin.Begin);
					if (fileStream.ReadByte() == 0)
					{
						CurrentBlock = tempPos;
						break;
					}
					tempPos++;
				}
				CurrentBlock = tempPos;
			}
			readBlock();
			updateBoxes();
		}
		private void previousPosition_button_Click(object sender, EventArgs e)
		{
			if (CurrentBlock > 0)
			{
				int tempPos = CurrentBlock - 1;
				while (tempPos > 0)
				{
					fileStream.Seek(tempPos * BlockSize + DataBegin + 1, SeekOrigin.Begin);
					if (fileStream.ReadByte() == 0)
					{
						CurrentBlock = tempPos;
						break;
					}
					tempPos--;
				}
				CurrentBlock = tempPos;
			}
			readBlock();
			updateBoxes();
		}
		#endregion

		#region Miscellaneous
		private void readBlock()
		{
			byte[] block = new byte[BlockSize];
			fileStream.Seek(CurrentBlock * BlockSize + DataBegin, SeekOrigin.Begin);
			fileStream.Read(block, 0, BlockSize);
			CurrentRecord = new Record(block);
		}
		private void updateBoxes()
		{
			firstName_box.Text = CurrentRecord.firstName;
			lastName_box.Text = CurrentRecord.lastName;
			middleName_box.Text = CurrentRecord.middleName;
			birthDate_box.Text = CurrentRecord.birthDate;
			phoneNumber_box.Text = CurrentRecord.phoneNumber;
			country_box.Text = CurrentRecord.country;
			city_box.Text = CurrentRecord.city;
			email_box.Text = CurrentRecord.email;
			website_box.Text = CurrentRecord.website;
			comment_box.Text = CurrentRecord.comment;

			page_label.Text = $"{CurrentBlock+1}/{TotalBlocks}";
		}

		// OLD
		/*private bool findBlock()
		{
			byte[] block = new byte[BlockSize];
			int position = 0;
			bool isDeleted = false;
			fileStream.Position = 0;
			while (fileStream.Read(block, 0, BlockSize) > 0)
			{
				if (block[0] == 1)
				{
					isDeleted = true;
					break;
				}
				position++;
			}
			CurrentBlock = position;
			fileStream.Position = CurrentBlock * BlockSize;
			return isDeleted;
		}*/
		private void addBlock()
		{
			Mode = false;

			editMode(true);

			foreach (Control control in main_table.Controls)
			{
				control.Enabled = true;
				if (control is TextBox textBox)
					textBox.Clear();
				if (control is MaskedTextBox maskedTextBox)
					maskedTextBox.Clear();
				//if (control is DateTimePicker dateTimePicker)
				//	dateTimePicker.Value = DateTime.Now;
			}

			Maximum++;
			
			//   MOVED TO ok_button_Click()   //
			
			//BlockPosition = Maximum;
			//fileStream.Position = BlockPosition * BlockSize;
		}
		private void editMode(bool isEditModeOn)
		{
			add_button.Enabled = !isEditModeOn;
			edit_button.Enabled = !isEditModeOn;
			delete_button.Enabled = !isEditModeOn;
			navigation_panel.Enabled = !isEditModeOn;
			ok_button.Enabled = isEditModeOn;
			ok_button.Visible = isEditModeOn;
			cancel_button.Enabled = isEditModeOn;

			foreach (Control control in main_table.Controls)
			{
				if (control is TextBox textBox)
					textBox.ReadOnly = !isEditModeOn;

				//if (control is DateTimePicker picker)
				//	picker. = isEditModeOn;

				if (control is MaskedTextBox maskedTextBox)
					maskedTextBox.ReadOnly = !isEditModeOn;
			}

		}
		#endregion

		private void Notebook_Saving(object sender, FormClosingEventArgs e)
		{
			byte[] lastBlockOpened = BitConverter.GetBytes(CurrentBlock);

			if (IsAnyDeleted)
			{
				string tempPath = ".temp";
				using (FileStream tempStream = new FileStream(tempPath, FileMode.Create))
				{
					fileStream.Seek(0, SeekOrigin.Begin);
					tempStream.Seek(0, SeekOrigin.Begin);
					tempStream.Write(lastBlockOpened, 0, SymbolSize);

					byte[] block = new byte[BlockSize];

					fileStream.Seek(DataBegin, SeekOrigin.Begin);
					tempStream.Seek(DataBegin, SeekOrigin.Begin);
					while (fileStream.Read(block, 0, BlockSize) >= BlockSize)
					{
						if (block[1] == 0)
						{
							tempStream.Write(block, 0, BlockSize);
						}
					}
				}
				fileStream.Close();
				File.Delete(FilePath);
				File.Move(tempPath, FilePath);
			}
			else
			{
				fileStream.Seek(0, SeekOrigin.Begin);
				fileStream.Write(lastBlockOpened, 0, SymbolSize);
				fileStream.Close();
			}
		}

		private List<(Record,int)> makeList()
		{
			List<(Record, int)> list = new List<(Record, int)>();

			Record filter = new Record(
								firstName_search.Text,
								lastName_search.Text,
								middleName_search.Text,
								birthDate_search.Text,
								phoneNumber_search.Text,
								country_search.Text,
								city_search.Text
			);
			

			byte[] block = new byte[BlockSize];
			fileStream.Seek(DataBegin, SeekOrigin.Begin);
			int pos = 0;
			while (fileStream.Read(block, 0, BlockSize) >= BlockSize)
			{
				Record rec = new Record(block);
				if (rec.isDeleted) continue;
				bool check;

				if (!anything_check.Checked)
					if (and.Checked)
					{
						check = true;

						if (firstName_check.Checked && check)
							check = rec.firstName.ToLower().Contains(filter.firstName.ToLower());
						if (lastName_check.Checked && check)
							check = rec.lastName.ToLower().Contains(filter.lastName.ToLower());
						if (middleName_check.Checked && check)
							check = rec.middleName.ToLower().Contains(filter.middleName.ToLower());
						if (birthDate_check.Checked && check)
							check = rec.birthDate.ToLower().Contains(filter.birthDate.ToLower());
						if (phoneNumber_check.Checked && check)
							check = rec.phoneNumber.ToLower().Contains(filter.phoneNumber.ToLower());
						if (country_check.Checked && check)
							check = rec.country.ToLower().Contains(filter.country.ToLower());
						if (city_check.Checked && check)
							check = rec.city.ToLower().Contains(filter.city.ToLower());
					}
					else
					{
						check = false;

						if (firstName_check.Checked && !check)
							check = rec.firstName.ToLower().Contains(filter.firstName.ToLower());
						if (lastName_check.Checked && !check)
							check = rec.lastName.ToLower().Contains(filter.lastName.ToLower());
						if (middleName_check.Checked && !check)
							check = rec.middleName.ToLower().Contains(filter.middleName.ToLower());
						if (birthDate_check.Checked && !check)
							check = rec.birthDate.ToLower().Contains(filter.birthDate.ToLower());
						if (phoneNumber_check.Checked && !check)
							check = rec.phoneNumber.ToLower().Contains(filter.phoneNumber.ToLower());
						if (country_check.Checked && !check)
							check = rec.country.ToLower().Contains(filter.country.ToLower());
						if (city_check.Checked && !check)
							check = rec.city.ToLower().Contains(filter.city.ToLower());
					}
				else
				{
					check = false;

					string word = anything_search.Text;
					if (!check)
						check = rec.firstName.ToLower().Contains(word.ToLower());
					if (!check)
						check = rec.lastName.ToLower().Contains(word.ToLower());
					if (!check)
						check = rec.middleName.ToLower().Contains(word.ToLower());
					if (!check)
						check = rec.birthDate.ToLower().Contains(word.ToLower());
					if (!check)
						check = rec.phoneNumber.ToLower().Contains(word.ToLower());
					if (!check)
						check = rec.country.ToLower().Contains(word.ToLower());
					if (!check)
						check = rec.city.ToLower().Contains(word.ToLower());
				}

				if (check)
					list.Add((rec, pos));
				pos++;
			}
			return list;
		}
	}
	public class Record
	{
		public static int symbolSize = 2;
		public static int blockSize = (1 + 20 + 20 + 20 + 20 + 20 + 20 + 20 + 40 + 8 + 10) * symbolSize; // NEED TO FIX THIS MESS

		public bool isDeleted = false;
		public string firstName		{ get; private set; }
		public string lastName		{ get; private set; }
		public string middleName	{ get; private set; }
		public string birthDate		{ get; private set; }
		public string phoneNumber	{ get; private set; }
		public string country		{ get; private set; }
		public string city			{ get; private set; }
		public string email			{ get; private set; }
		public string website		{ get; private set; }
		public string comment		{ get; private set; }

		public Record() { }
		public Record(string firstName, string lastName, string middleName, string birthDate, string phoneNumber, string country, string city, string email, string website, string comment)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.middleName = middleName;
			this.birthDate = birthDate;
			this.phoneNumber = phoneNumber;
			this.country = country;
			this.city = city;
			this.email = email;
			this.website = website;
			this.comment = comment;
		}
		public Record(string firstName, string lastName, string middleName, string birthDate, string phoneNumber, string country, string city)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.middleName = middleName;
			this.birthDate = birthDate;
			this.phoneNumber = phoneNumber;
			this.country = country;
			this.city = city;
		}
		public Record(byte[] byteArray)
		{
			initFromByteArray(byteArray);
		}
		public Record(ref FileStream fs)
		{
			byte[] byteArray = new byte[blockSize];
			fs.Read(byteArray, 0, blockSize);
			initFromByteArray(byteArray);
		}
		public byte[] Serialize2Byte()
		{
			ByteEncodingStream stream = new ByteEncodingStream(blockSize, symbolSize);

			stream.insert(isDeleted);
			stream.insert(firstName, 20);
			stream.insert(lastName, 20);
			stream.insert(middleName, 20);
			stream.insert(birthDate, 8);
			stream.insert(phoneNumber, 10);
			stream.insert(country, 20);
			stream.insert(city, 20);
			stream.insert(email, 20);
			stream.insert(website, 20);
			stream.insert(comment, 40);

			return stream.getArray();
		}
		public override string ToString()
		{
			return	firstName + " " +
					lastName + " " +
					middleName;
		}
		private void initFromByteArray(byte[] byteArray)
		{
			ByteDecodingStream stream = new ByteDecodingStream(byteArray, symbolSize);
			isDeleted = stream.getNextBool();
			firstName = stream.getNextString(20);
			lastName = stream.getNextString(20);
			middleName = stream.getNextString(20);
			birthDate = stream.getNextString(8);
			phoneNumber = stream.getNextString(10);
			country = stream.getNextString(20);
			city = stream.getNextString(20);
			email = stream.getNextString(20);
			website = stream.getNextString(20);
			comment = stream.getNextString(40);
		}
		private abstract class ByteEncoderStream
		{
			protected byte[] byteArray;
			protected int symbolSize;
			protected int position;
			public bool ended { get; protected set; }
			public bool getEnded()
			{
				ended = !(position < byteArray.Length / symbolSize);
				return ended;
			}
		}
		private class ByteDecodingStream : ByteEncoderStream
		{
			public ByteDecodingStream(byte[] byteArray, int symbolSize, int startPosition = 0)
			{
				this.symbolSize = symbolSize;
				this.byteArray = byteArray;
				this.ended = false;
				this.position = startPosition;
			}
			public string getNextString(int length)
			{
				string output = Encoding.UTF8.GetString(byteArray, position * symbolSize, length * symbolSize).TrimEnd('\0');
				position += length;
				getEnded();
				return output;
			}
			public bool getNextBool(int length = 1)
			{
				bool output = Encoding.UTF8.GetChars(byteArray, position * symbolSize, length * symbolSize)[symbolSize-1] != '\0';
				position += length;
				getEnded();
				return output;
			}
		}
		private class ByteEncodingStream : ByteEncoderStream
		{
			public ByteEncodingStream(int arraySize, int symbolSize, int startPosition = 0)
			{
				this.symbolSize = symbolSize;
				this.byteArray = new byte[arraySize];
				this.ended = false;
				this.position = startPosition;
			}
			public void insert(string inputString, int offset)
			{
				Encoding.UTF8.GetBytes(inputString).CopyTo(byteArray, position * Record.symbolSize);
				position += offset;
				getEnded();
			}
			public void insert(bool boolean, int offset = 1)
			{
				this.insert((boolean ? 1 : 0).ToString(), offset);
			}
			public byte[] getArray()
			{
				return byteArray;
			}
		}
	}
}
