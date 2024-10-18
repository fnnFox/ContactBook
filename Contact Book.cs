using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

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

		OleDbConnection db = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.mdb");

		Record CurrentRecord;

		public ContactBook()
		{
			InitializeComponent();
			CollapsedPanelHeight = splitContainer.Panel2.Height;
			Height -= CollapsedPanelHeight;
			splitContainer.Panel2Collapsed = true;

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

			db.Open();
			OleDbCommand command = new OleDbCommand(
				"SELECT COUNT(*) FROM contacts", db);
			int TotalBlocks = (int)command.ExecuteScalar();
			db.Close();

			if (TotalBlocks == 0)
			{
				addBlock();
			}
			else
			{
				updateDataGrid();
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
				CurrentRecord.id,
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
			if (!checkIsEmpty(CurrentRecord))
			{
				if (!checkForDubs(CurrentRecord))
				{
					db.Open();
					OleDbCommand command;
					if (!Mode)
					{
						command = new OleDbCommand("insert into contacts (firstName,lastName,middleName,birthDate,phoneNumber,country,city,email,website,comment) values (?,?,?,?,?,?,?,?,?,?)", db);
						CurrentRecord.AddAllParams(ref command);
					}
					else
					{
						command = new OleDbCommand($"update contacts set {CurrentRecord.ToQuery()} where id={CurrentRecord.id}", db);
					}
					command.ExecuteNonQuery();
					db.Close();

					editMode(false);
					updateDataGrid();
					updateBoxes();
				}
				else
				{
					MessageBox.Show("Такая запись уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Запись пуста", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void cancel_button_Click(object sender, EventArgs e)
		{
			editMode(false);
			updateBoxes();
		}
		private void delete_button_Click(object sender, EventArgs e)
		{
			db.Open();
			OleDbCommand command = new OleDbCommand($"delete from contacts where id={CurrentRecord.id}",db);
			command.ExecuteNonQuery();
			db.Close();
			updateDataGrid();
			listBox_Select(dataTable, null);
			updateBoxes();
		}
		private void goSearch_button_Click(object sender, EventArgs e)
		{
			db.Open();
			OleDbCommand command = new OleDbCommand(makeSearchQuery(), db);
			OleDbDataAdapter adapter = new OleDbDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			dataTable.DataSource = table;
			if (dataTable.Columns.Contains("id"))
			{
				dataTable.Columns["id"].Visible = false;
			}
			db.Close();
		}

		#endregion

		#region Miscellaneous
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

			page_label.Text = $"id = {CurrentRecord.id}";
		}
		private void updateDataGrid()
		{
			db.Open();

			OleDbCommand command = new OleDbCommand("SELECT * FROM contacts", db);
			OleDbDataAdapter adapter = new OleDbDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			dataTable.DataSource = table;
			if (dataTable.Columns.Contains("id"))
			{
				dataTable.Columns["id"].Visible = false;
			}

			db.Close();
		}
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
			}
		}
		private void editMode(bool isEditModeOn)
		{
			add_button.Enabled = !isEditModeOn;
			edit_button.Enabled = !isEditModeOn;
			delete_button.Enabled = !isEditModeOn;
			ok_button.Enabled = isEditModeOn;
			ok_button.Visible = isEditModeOn;
			cancel_button.Enabled = isEditModeOn;

			foreach (Control control in main_table.Controls)
			{
				if (control is TextBoxBase tbb)
					tbb.ReadOnly = !isEditModeOn;
			}
		}

		private void listBox_Select(object sender, DataGridViewCellEventArgs e)
		{
			var c = (sender as DataGridView).CurrentRow.Cells;
			if (c != null)
			{
				CurrentRecord = new Record(
								c["id"].Value.ToString(),
								c["firstName"].Value.ToString(),
								c["lastName"].Value.ToString(),
								c["middleName"].Value.ToString(),
								c["birthDate"].Value.ToString(),
								c["phoneNumber"].Value.ToString(),
								c["country"].Value.ToString(),
								c["city"].Value.ToString(),
								c["email"].Value.ToString(),
								c["website"].Value.ToString(),
								c["comment"].Value.ToString());
			}
			updateBoxes();
		}
		private string makeSearchQuery()
		{
			string query = "select * from contacts where ";

			Record filter = new Record(
								firstName_search.Text,
								lastName_search.Text,
								middleName_search.Text,
								birthDate_search.Text,
								phoneNumber_search.Text,
								country_search.Text,
								city_search.Text
			);

			if (!anything_check.Checked) {
				if (and.Checked)
				{
					if (firstName_check.Checked)
						query += $"firstName like '%{filter.firstName}%' and ";
					if (lastName_check.Checked)
						query += $"lastName like '%{filter.lastName}%' and ";
					if (middleName_check.Checked)
						query += $"middleName like '%{filter.middleName}%' and ";
					if (birthDate_check.Checked)
						query += $"birthDate like '%{filter.birthDate}%' and ";
					if (phoneNumber_check.Checked)
						query += $"phoneNumber like '%{filter.phoneNumber}%' and ";
					if (country_check.Checked)
						query += $"country like '%{filter.country}%' and ";
					if (city_check.Checked)
						query += $"city like '%{filter.city}%' and ";

					query = query.Substring(0, query.Length - " and ".Length);
				}
				else
				{
					if (firstName_check.Checked)
						query += $"firstName like '%{filter.firstName}%' or ";
					if (lastName_check.Checked)
						query += $"lastName like '%{filter.lastName}%' or ";
					if (middleName_check.Checked)
						query += $"middleName like '%{filter.middleName}%' or ";
					if (birthDate_check.Checked)
						query += $"birthDate like '%{filter.birthDate}%' or ";
					if (phoneNumber_check.Checked)
						query += $"phoneNumber like '%{filter.phoneNumber}%' or ";
					if (country_check.Checked)
						query += $"country like '%{filter.country}%' or ";
					if (city_check.Checked)
						query += $"city like '%{filter.city}%' or ";

					query = query.Substring(0, query.Length - " or ".Length);
				}
				query += ";";
			}
			else
			{
				string str = anything_search.Text;
				query +=
					$"firstName like '%{str}%' or " +
					$"lastName like '%{str}%' or " +
					$"middleName like '%{str}%' or " +
					$"birthDate like '%{str}%' or " +
					$"phoneNumber like '%{str}%' or " +
					$"country like '%{str}%' or " +
					$"city like '%{str}%';";
			}
			return query;
		}
		private bool checkForDubs(Record filter)
		{
			int result = 0;
			db.Open();

			OleDbCommand command = new OleDbCommand(
				"SELECT COUNT(*) FROM contacts WHERE id <> ? AND firstName = ? AND lastName = ? AND middleName = ? AND birthDate = ? AND phoneNumber = ? AND country = ? AND city = ?", db);

			filter.AddAllParams(ref command);

			result = (int)(command.ExecuteScalar());
			db.Close();
			return result > 0 ? true : false;
		}
		private bool checkIsEmpty(Record record)
		{
			if (record.firstName.Length == 0 &&
				record.lastName.Length == 0 &&
				record.middleName.Length == 0 &&
				record.birthDate.Length == 0 &&
				record.phoneNumber.Length == 0)
				return true;
			return false;
		}
		#endregion
	}
	public class Record
	{
		public static int symbolSize = 2;
		public static int blockSize = (1 + 20 + 20 + 20 + 20 + 20 + 20 + 20 + 40 + 8 + 10) * symbolSize; // NEED TO FIX THIS MESS

		public string id			{ get; private set; } = "1";
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
		public Record(string id, string firstName, string lastName, string middleName, string birthDate, string phoneNumber, string country, string city, string email, string website, string comment)
		{
			this.id = id;
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
		public string ToQuery()
		{
			return
				$"firstName='{firstName}'," +
				$"lastName='{lastName}'," +
				$"middleName='{middleName}'," +
				$"birthDate='{birthDate}'," +
				$"phoneNumber='{phoneNumber}'," +
				$"country='{country}'," +
				$"city='{city}'," +
				$"email='{email}'," +
				$"website='{website}'," +
				$"comment='{comment}'";
		}
		public void AddAllParams(ref OleDbCommand command)
		{
			command.Parameters.AddWithValue("@id", id);
			command.Parameters.AddWithValue("@firstName", firstName);
			command.Parameters.AddWithValue("@lastName", lastName);
			command.Parameters.AddWithValue("@middleName", middleName);
			command.Parameters.AddWithValue("@birthDate", birthDate);
			command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
			command.Parameters.AddWithValue("@country", country);
			command.Parameters.AddWithValue("@city", city);
			command.Parameters.AddWithValue("@email", email);
			command.Parameters.AddWithValue("@website", website);
			command.Parameters.AddWithValue("@comment", comment);
		}
	}
}
