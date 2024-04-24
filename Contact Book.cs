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
        int BlockSize = 1 + 20 + 20 + 20 + 10 + 18;
        bool Add0_Edit1;
        int Maximum;
        FileStream fileStream;
        //BinaryWriter writer;
        //BinaryReader reader;
        public ContactBook()
        {
            InitializeComponent();
            CollapsedPanelHeight = this.splitContainer.Panel2.Height;
            this.Height -= CollapsedPanelHeight;
            this.splitContainer.Panel2Collapsed = true;

            fileStream = new FileStream(FilePath, FileMode.OpenOrCreate);

            fileStream.Position = 0;

            while (fileStream.Read(new byte[BlockSize], 0, BlockSize) > 0)
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

        private void firstName_label_Click(object sender, EventArgs e)
        {
            this.firstName_box.Focus();
        }
        private void lastName_label_Click(object sender, EventArgs e)
        {
            this.firstName_box.Focus();
        }
        private void middleName_label_Click(object sender, EventArgs e)
        {
            this.firstName_box.Focus();
        }
        private void birthDate_label_Click(object sender, EventArgs e)
        {
            this.birthDate_box.Focus();
        }
        private void phoneNumber_label_Click(object sender, EventArgs e)
        {
            this.phoneNumber_box.Focus();
        }
        private void search_button_Click(object sender, EventArgs e)
        {
            if (this.splitContainer.Panel2Collapsed)
            {
                this.splitContainer.Panel2Collapsed = false;
                this.Height += CollapsedPanelHeight;
                this.search_button.Text = "Поиск ▼";
            }
            else
            {
                this.splitContainer.Panel2Collapsed = true;
                this.Height -= CollapsedPanelHeight;
                this.search_button.Text = "Поиск ▲";
            }
        }
        private void add_button_Click(object sender, EventArgs e)
        {
            addBlock();
        }
        private void edit_button_Click(object sender, EventArgs e)
        {
            Add0_Edit1 = true;

            switchButtons(true);

            foreach (Control control in this.textBox_panel.Controls)
            {
                control.Enabled = true;
            }
        }
        private void ok_button_Click(object sender, EventArgs e)
        {
            /////////////////
            // SAVING CODE //
            /////////////////

            Record record = new Record(
                this.firstName_box.Text.ToCharArray(),
                this.lastName_box.Text.ToCharArray(),
                this.middleName_box.Text.ToCharArray(),
                this.birthDate_box.Text.ToCharArray(),
                this.phoneNumber_box.Text.ToCharArray());

            fileStream.Position = BlockPosition * BlockSize;
            fileStream.Write(record.Serialize2Byte(), 0, BlockSize);
            fileStream.Flush();

            if (!Add0_Edit1)
                Maximum++;

            foreach (Control control in this.textBox_panel.Controls)
            {
                control.Enabled = false;
            }
            switchButtons(false);
        }
        private void cancel_button_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.textBox_panel.Controls)
            {
                control.Enabled = false;
            }
            switchButtons(false);
            updateBoxes();
        }
        private void delete_button_Click(object sender, EventArgs e)
        {
            fileStream.Position = BlockPosition * BlockSize;
            fileStream.WriteByte(1);
            fileStream.Flush();
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

        private void updateBoxes()
        {
            byte[] block = new byte[BlockSize];
            fileStream.Position = BlockPosition * BlockSize;
            fileStream.Read(block, 0, BlockSize);
            Record record = new Record(block);
            this.firstName_box.Text = new string(record.firstName);
            this.lastName_box.Text = new string(record.lastName);
            this.middleName_box.Text = new string(record.middleName);
            this.birthDate_box.Text = new string(record.birthDate);
            this.phoneNumber_box.Text = new string(record.phoneNumber);
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

            switchButtons(true);

            foreach (Control control in this.textBox_panel.Controls)
            {
                control.Enabled = true;
                if (control is TextBox textBox)
                    textBox.Clear();
                if (control is MaskedTextBox maskedTextBox)
                    maskedTextBox.Clear();
                if (control is DateTimePicker dateTimePicker)
                    dateTimePicker.Value = DateTime.Now;
            }
            //findBlock();
            BlockPosition = Maximum;
            fileStream.Position = BlockPosition * BlockSize;
        }
        private void switchButtons(bool isEditModeOn)
        {
            if (isEditModeOn)
            {
                this.add_button.Enabled = false;
                this.edit_button.Enabled = false;
                this.delete_button.Enabled = false;
                this.ok_button.Enabled = true;
                this.ok_button.Visible = true;
                this.cancel_button.Enabled = true;
            }
            else
            {
                this.add_button.Enabled = true;
                this.edit_button.Enabled = true;
                this.delete_button.Enabled = true;
                this.ok_button.Enabled = false;
                this.ok_button.Visible = false;
                this.cancel_button.Enabled = false;
            }

        }
        private void Notebook_HardSaving(object sender, FormClosingEventArgs e)
        {
            using (FileStream temp = new FileStream("temp", FileMode.Create))
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
            File.Move("temp", FilePath);
        }
    }
    public class Record
    {
        public int size = 1 + 20 + 20 + 20 + 10 + 18;
        public bool isDeleted = false;
        public char[] firstName = new char[20];
        public char[] lastName = new char[20];
        public char[] middleName = new char[20];
        public char[] birthDate = new char[10];
        public char[] phoneNumber = new char[18];
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
            char[] charArray = System.Text.Encoding.UTF8.GetChars(byteArray);
            isDeleted = charArray[0] == 0 ? true : false;
            Array.Copy(charArray, 1, firstName, 0, 20);
            Array.Copy(charArray, 21, lastName, 0, 20);
            Array.Copy(charArray, 41, middleName, 0, 20);
            Array.Copy(charArray, 61, birthDate, 0, 10);
            Array.Copy(charArray, 71, phoneNumber, 0, 18);
        }
        public byte[] Serialize2Byte()
        {
            char[] charArray = new char[size];
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
