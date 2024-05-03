using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        int BlockPosition;
        int BlockSize = Record.BlockSize;

        bool Add0_Edit1;
        int Maximum;
        FileStream fileStream;

        public ContactBook()
        {
            InitializeComponent();
            CollapsedPanelHeight = splitContainer.Panel2.Height;
            Height -= CollapsedPanelHeight;
            splitContainer.Panel2Collapsed = true;

            fileStream = new FileStream(FilePath, FileMode.OpenOrCreate);

            fileStream.Position = 0;

            while (fileStream.Read(new byte[BlockSize], 0, BlockSize) >= BlockSize)
            {
                Maximum++;
            }


            if (Maximum == 0)
            {
                addBlock();
            }
            else
            {
                BlockPosition = 0;
                updateBoxes();
            }

        }
        //---------- LABEL CLICKS ----------//
        private void firstName_label_Click(object sender, EventArgs e)
        {
            firstName_box.Focus();
        }
        private void lastName_label_Click(object sender, EventArgs e)
        {
            firstName_box.Focus();
        }
        private void middleName_label_Click(object sender, EventArgs e)
        {
            firstName_box.Focus();
        }
        private void birthDate_label_Click(object sender, EventArgs e)
        {
            birthDatePicker_box.Focus();
        }
        private void phoneNumber_label_Click(object sender, EventArgs e)
        {
            phoneNumber_box.Focus();
        }

        //---------- BUTTON CLICKS ----------//
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
            Add0_Edit1 = true;

            editMode(true);
        }
        private void ok_button_Click(object sender, EventArgs e)
        {
            /////////////////
            // SAVING CODE //
            /////////////////

            Record record = new Record(
                firstName_box.Text.ToCharArray(),
                lastName_box.Text.ToCharArray(),
                middleName_box.Text.ToCharArray(),
                birthDatePicker_box.Text.ToCharArray(),
                phoneNumber_box.Text.ToCharArray());

            if (!Add0_Edit1)
            {
                BlockPosition = Maximum;
                fileStream.Position = BlockPosition * BlockSize;
                Maximum++;
            }

            fileStream.Position = BlockPosition * BlockSize;
            byte[] bytes = record.Serialize2Byte();
            fileStream.Write(bytes, 0, BlockSize);
            fileStream.Flush();

            editMode(false);

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
            fileStream.Position = BlockPosition * BlockSize;
            fileStream.WriteByte(1);
            fileStream.Flush();
            BlockPosition += BlockPosition == 0 ? +1 : -1;
            updateBoxes();
        }
        private void firstPosition_button_Click(object sender, EventArgs e)
        {
            int tempPos = 0;
            while (tempPos < Maximum - 1)
            {
                fileStream.Position = tempPos * BlockSize;
                if (fileStream.ReadByte() == 0)
                {
                    BlockPosition = tempPos;
                    break;
                }
                tempPos++;
            }
            BlockPosition = tempPos;
            updateBoxes();
        }
        private void lastPosition_button_Click(object sender, EventArgs e)
        {
            int tempPos = Maximum - 1;
            while (tempPos > 0)
            {
                fileStream.Position = tempPos * BlockSize;
                if (fileStream.ReadByte() == 0)
                {
                    BlockPosition = tempPos;
                    break;
                }
                tempPos--;
            }
            BlockPosition = tempPos;
            updateBoxes();
        }
        private void nextPosition_button_Click(object sender, EventArgs e)
        {
            if (BlockPosition < Maximum - 1)
            {
                int tempPos = BlockPosition + 1;
                while (tempPos < Maximum - 1)
                {
                    fileStream.Position = tempPos * BlockSize;
                    if (fileStream.ReadByte() == 0)
                    {
                        BlockPosition = tempPos;
                        break;
                    }
                    tempPos++;
                }
                BlockPosition = tempPos;
            }
            updateBoxes();
        }
        private void previousPosition_button_Click(object sender, EventArgs e)
        {
            if (BlockPosition > 0)
            {
                int tempPos = BlockPosition - 1;
                while (tempPos > 0)
                {
                    fileStream.Position = tempPos * BlockSize;
                    if (fileStream.ReadByte() == 0)
                    {
                        BlockPosition = tempPos;
                        break;
                    }
                    tempPos--;
                }
                BlockPosition = tempPos;
            }
            updateBoxes();
        }

        //---------- SOME USEFUL FUNCTIONS ----------//
        private void updateBoxes()
        {
            byte[] block = new byte[BlockSize];
            fileStream.Position = BlockPosition * BlockSize;
            fileStream.Read(block, 0, BlockSize);
            Record record = new Record(block);
            firstName_box.Text = new string(record.firstName);
            lastName_box.Text = new string(record.lastName);
            middleName_box.Text = new string(record.middleName);
            birthDatePicker_box.Text = new string(record.birthDate);
            birthDateMasked_box.Text = new string(record.birthDate);
            phoneNumber_box.Text = new string(record.phoneNumber);
        }

        // OLD
        private bool findBlock()
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
            BlockPosition = position;
            fileStream.Position = BlockPosition * BlockSize;
            return isDeleted;
        }
        private void addBlock()
        {
            Add0_Edit1 = false;

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
        private void Notebook_Saving(object sender, FormClosingEventArgs e)
        {
            string tempPath = ".temp";
            using (FileStream temp = new FileStream(tempPath, FileMode.Create))
            {
                byte[] block = new byte[BlockSize];
                fileStream.Position = 0;

                for (int i = 0; i < Maximum; i++)
                {
                    if (fileStream.ReadByte() == 0)
                    {
                        fileStream.Position--;
                        fileStream.Read(block, 0, BlockSize);
                        temp.Write(block, 0, BlockSize);
                    }
                    else
                    {
                        fileStream.Position += BlockSize - 1;
                    }
                }
            }
            fileStream.Close();
            File.Delete(FilePath);
            File.Move(tempPath, FilePath);
        }
    }
    public class Record
    {
        public static int symbolSize = 2;
        public static int BlockSize = 1 + (20 + 20 + 20) * symbolSize + 10 + 18; // NEED TO FIX THIS MESS

        public bool isDeleted = false;
        public char[] firstName { get; } = new char[20];
        public char[] lastName { get; } = new char[20];
        public char[] middleName { get; } = new char[20];
        public char[] birthDate { get; } = new char[10];
        public char[] phoneNumber { get; } = new char[18];

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
            char[] charArray = Encoding.UTF8.GetChars(byteArray);
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

            return Encoding.UTF8.GetBytes(charArray);
        }
    }
}
