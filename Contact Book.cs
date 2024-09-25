using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
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
        int DataBegin = 16 * SymbolSize; 

        FileStream fileStream;
        
        static int BlockSize = Record.BlockSize;
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
                CurrentBlock = BitConverter.ToInt32(lastBlockOpened, 0);
                readBlock();
                updateBoxes();
            }
        }

        #region Label Clicks
        private void firstName_label_Click(object sender, EventArgs e)
        {
            firstName_box.Focus();
        }
        private void lastName_label_Click(object sender, EventArgs e)
        {
            lastName_box.Focus();
        }
        private void middleName_label_Click(object sender, EventArgs e)
        {
            middleName_box.Focus();
        }
        private void birthDate_label_Click(object sender, EventArgs e)
        {
            birthDatePicker_box.Focus();
        }
        private void phoneNumber_label_Click(object sender, EventArgs e)
        {
            phoneNumber_box.Focus();
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
                firstName_box.Text.ToCharArray(),
                lastName_box.Text.ToCharArray(),
                middleName_box.Text.ToCharArray(),
                birthDatePicker_box.Text.ToCharArray(),
                phoneNumber_box.Text.ToCharArray());

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
            foreach (Control control in textBox_panel.Controls)
            {
                control.Enabled = false;
            }
            editMode(false);
            updateBoxes();
        }
        private void delete_button_Click(object sender, EventArgs e)
        {
            fileStream.Seek(CurrentBlock * BlockSize + DataBegin, SeekOrigin.Begin);
            fileStream.WriteByte(1);
            fileStream.Flush();
            CurrentBlock += CurrentBlock == 0 ? +1 : -1;
            //TotalBlocks--;
            IsAnyDeleted = true;
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
                fileStream.Seek(tempPos * BlockSize + DataBegin,SeekOrigin.Begin);
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
                fileStream.Seek(tempPos * BlockSize + DataBegin, SeekOrigin.Begin);
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
                    fileStream.Seek(tempPos * BlockSize + DataBegin, SeekOrigin.Begin);
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
                    fileStream.Seek(tempPos * BlockSize + DataBegin, SeekOrigin.Begin);
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
            firstName_box.Text = new string(CurrentRecord.firstName);
            lastName_box.Text = new string(CurrentRecord.lastName);
            middleName_box.Text = new string(CurrentRecord.middleName);
            birthDatePicker_box.Text = new string(CurrentRecord.birthDate);
            birthDateMasked_box.Text = new string(CurrentRecord.birthDate);
            phoneNumber_box.Text = new string(CurrentRecord.phoneNumber);

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

            foreach (Control control in textBox_panel.Controls)
            {
                control.Enabled = true;
                if (control is TextBox textBox)
                    textBox.Clear();
                if (control is MaskedTextBox maskedTextBox)
                    maskedTextBox.Clear();
                if (control is DateTimePicker dateTimePicker)
                    dateTimePicker.Value = DateTime.Now;
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

            foreach (Control control in textBox_panel.Controls)
            {
                if (control is TextBox textBox)
                    textBox.ReadOnly = !isEditModeOn;

                if (control is DateTimePicker picker)
                    picker.Visible = isEditModeOn;

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
                        if (block[0] == 0)
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
                firstName_search.Text.ToCharArray(),
                lastName_search.Text.ToCharArray(),
                middleName_search.Text.ToCharArray(),
                birthDatePicker_search.Text.ToCharArray(),
                phoneNumber_search.Text.ToCharArray()
            );

            byte[] block = new byte[BlockSize];
            fileStream.Seek(DataBegin, SeekOrigin.Begin);
            int pos = 0;
            while (fileStream.Read(block, 0, BlockSize) >= BlockSize)
            {
                Record rec = new Record(block);
                if (rec.isDeleted) continue;
                bool check;

                if (and.Checked)
                {
                    check = true;

                    if (firstName_check.Checked && check)
                        check = compare(rec.firstName, filter.firstName);
                    if (lastName_check.Checked && check)
                        check = compare(rec.lastName, filter.lastName);
                    if (middleName_check.Checked && check)
                        check = compare(rec.middleName, filter.middleName);
                    if (birthDatePicker_check.Checked && check)
                        check = compare(rec.birthDate, filter.birthDate);
                    if (phoneNumber_check.Checked && check)
                        check = compare(rec.phoneNumber, filter.phoneNumber);
                }
                else
                {
                    check = false;

                    if (firstName_check.Checked && !check)
                        check = compare(rec.firstName, filter.firstName);
                    if (lastName_check.Checked && !check)
                        check = compare(rec.lastName, filter.lastName);
                    if (middleName_check.Checked && !check)
                        check = compare(rec.middleName, filter.middleName);
                    if (birthDatePicker_check.Checked && !check)
                        check = compare(rec.birthDate, filter.birthDate);
                    if (phoneNumber_check.Checked && !check)
                        check = compare(rec.phoneNumber, filter.phoneNumber);
                }

                if (check)
                    list.Add((rec, pos));
                pos++;
            }
            return list;
        }
        private bool compare(char[] a, char[] b)
        {
            if (a.Length != b.Length) return false;
            bool res = true;
            for (int i = 0; i < a.Length; i++)
                if (a[i] != b[i])
                    res = false;
            return res;
        }
    }
    public class Record
    {
        public static int symbolSize = 4;
        public static int BlockSize = (1 + 20 + 20 + 20 + 10 + 18) * symbolSize; // NEED TO FIX THIS MESS

        public bool isDeleted = false;
        public char[] firstName { get; } = new char[20];
        public char[] lastName { get; } = new char[20];
        public char[] middleName { get; } = new char[20];
        public char[] birthDate { get; } = new char[10];
        public char[] phoneNumber { get; } = new char[18];

        public Record() { }
        public Record(char[] firstName, char[] lastName, char[] middleName, char[] birthDate, char[] phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.middleName = middleName;
            this.birthDate = birthDate;
            this.phoneNumber = phoneNumber;
        }
        public Record(byte[] byteArray)
        {
            char[] charArray = Encoding.UTF32.GetChars(byteArray);
            Array.Copy(charArray, 1, firstName, 0, 20);
            Array.Copy(charArray, 21, lastName, 0, 20);
            Array.Copy(charArray, 41, middleName, 0, 20);
            Array.Copy(charArray, 61, birthDate, 0, 10);
            Array.Copy(charArray, 71, phoneNumber, 0, 18);

            firstName = removeZeros(firstName);
            lastName = removeZeros(lastName);
            middleName = removeZeros(middleName);
            birthDate = removeZeros(birthDate);
            phoneNumber = removeZeros(phoneNumber);
        }
        public Record(ref FileStream fs)
        {
            byte[] block = new byte[BlockSize];
            fs.Read(block, 0, BlockSize);
            char[] charArray = Encoding.UTF32.GetChars(block);
            isDeleted = charArray[0] == 0 ? true : false;
            Array.Copy(charArray, 1, firstName, 0, 20);
            Array.Copy(charArray, 21, lastName, 0, 20);
            Array.Copy(charArray, 41, middleName, 0, 20);
            Array.Copy(charArray, 61, birthDate, 0, 10);
            Array.Copy(charArray, 71, phoneNumber, 0, 18);
        }
        public byte[] Serialize2Byte()
        {
            char[] charArray = new char[BlockSize];
            charArray[0] = (char)(isDeleted ? 1 : 0);
            firstName.CopyTo(charArray, 1);
            lastName.CopyTo(charArray, 21);
            middleName.CopyTo(charArray, 41);
            birthDate.CopyTo(charArray, 61);
            phoneNumber.CopyTo(charArray, 71);

            return Encoding.UTF32.GetBytes(charArray);
        }
        public override string ToString()
        {
            return new string(firstName) + " " +
                new string(lastName)     + " " + 
                new string(middleName)   + " " + 
                new string(birthDate)    + " " + 
                new string(phoneNumber);
        }
        private char[] removeZeros(char[] ch)
        {
            List<char> result = new List<char>();
            foreach (char c in ch)
            {
                if (c != 0)
                    result.Add(c);
            }
            return result.ToArray();
        }
    }
}
