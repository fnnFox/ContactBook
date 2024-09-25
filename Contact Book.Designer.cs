namespace ContactBook
{
    partial class ContactBook
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.page_label = new System.Windows.Forms.Label();
            this.textBox_panel = new System.Windows.Forms.Panel();
            this.firstName_box = new System.Windows.Forms.TextBox();
            this.birthDatePicker_box = new System.Windows.Forms.DateTimePicker();
            this.middleName_box = new System.Windows.Forms.TextBox();
            this.lastName_box = new System.Windows.Forms.TextBox();
            this.birthDateMasked_box = new System.Windows.Forms.MaskedTextBox();
            this.phoneNumber_box = new System.Windows.Forms.MaskedTextBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.navigation_panel = new System.Windows.Forms.Panel();
            this.lastPosition_button = new System.Windows.Forms.Button();
            this.previousPosition_button = new System.Windows.Forms.Button();
            this.firstPosition_button = new System.Windows.Forms.Button();
            this.nextPosition_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.firstName_label = new System.Windows.Forms.Label();
            this.phoneNumber_label = new System.Windows.Forms.Label();
            this.birthDate_label = new System.Windows.Forms.Label();
            this.middleName_label = new System.Windows.Forms.Label();
            this.lastName_label = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.radioBox = new System.Windows.Forms.GroupBox();
            this.or = new System.Windows.Forms.RadioButton();
            this.and = new System.Windows.Forms.RadioButton();
            this.goSearch_button = new System.Windows.Forms.Button();
            this.anything_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.phoneNumber_check = new System.Windows.Forms.CheckBox();
            this.birthDatePicker_check = new System.Windows.Forms.CheckBox();
            this.middleName_check = new System.Windows.Forms.CheckBox();
            this.lastName_check = new System.Windows.Forms.CheckBox();
            this.firstName_check = new System.Windows.Forms.CheckBox();
            this.firstName_search = new System.Windows.Forms.TextBox();
            this.birthDatePicker_search = new System.Windows.Forms.DateTimePicker();
            this.middleName_search = new System.Windows.Forms.TextBox();
            this.lastName_search = new System.Windows.Forms.TextBox();
            this.phoneNumber_search = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.textBox_panel.SuspendLayout();
            this.navigation_panel.SuspendLayout();
            this.radioBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.page_label);
            this.splitContainer.Panel1.Controls.Add(this.textBox_panel);
            this.splitContainer.Panel1.Controls.Add(this.cancel_button);
            this.splitContainer.Panel1.Controls.Add(this.search_button);
            this.splitContainer.Panel1.Controls.Add(this.navigation_panel);
            this.splitContainer.Panel1.Controls.Add(this.delete_button);
            this.splitContainer.Panel1.Controls.Add(this.edit_button);
            this.splitContainer.Panel1.Controls.Add(this.firstName_label);
            this.splitContainer.Panel1.Controls.Add(this.phoneNumber_label);
            this.splitContainer.Panel1.Controls.Add(this.birthDate_label);
            this.splitContainer.Panel1.Controls.Add(this.middleName_label);
            this.splitContainer.Panel1.Controls.Add(this.lastName_label);
            this.splitContainer.Panel1.Controls.Add(this.ok_button);
            this.splitContainer.Panel1.Controls.Add(this.add_button);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.radioBox);
            this.splitContainer.Panel2.Controls.Add(this.goSearch_button);
            this.splitContainer.Panel2.Controls.Add(this.anything_search);
            this.splitContainer.Panel2.Controls.Add(this.label1);
            this.splitContainer.Panel2.Controls.Add(this.panel1);
            this.splitContainer.Panel2.Controls.Add(this.label2);
            this.splitContainer.Panel2.Controls.Add(this.label3);
            this.splitContainer.Panel2.Controls.Add(this.label4);
            this.splitContainer.Panel2.Controls.Add(this.label5);
            this.splitContainer.Panel2.Controls.Add(this.label6);
            this.splitContainer.Panel2.Controls.Add(this.listBox);
            this.splitContainer.Size = new System.Drawing.Size(349, 530);
            this.splitContainer.SplitterDistance = 217;
            this.splitContainer.TabIndex = 0;
            // 
            // page_label
            // 
            this.page_label.AutoSize = true;
            this.page_label.Location = new System.Drawing.Point(29, 149);
            this.page_label.Name = "page_label";
            this.page_label.Size = new System.Drawing.Size(0, 13);
            this.page_label.TabIndex = 37;
            // 
            // textBox_panel
            // 
            this.textBox_panel.Controls.Add(this.firstName_box);
            this.textBox_panel.Controls.Add(this.birthDatePicker_box);
            this.textBox_panel.Controls.Add(this.middleName_box);
            this.textBox_panel.Controls.Add(this.lastName_box);
            this.textBox_panel.Controls.Add(this.birthDateMasked_box);
            this.textBox_panel.Controls.Add(this.phoneNumber_box);
            this.textBox_panel.Location = new System.Drawing.Point(97, 10);
            this.textBox_panel.Name = "textBox_panel";
            this.textBox_panel.Size = new System.Drawing.Size(154, 141);
            this.textBox_panel.TabIndex = 36;
            // 
            // firstName_box
            // 
            this.firstName_box.Location = new System.Drawing.Point(8, 7);
            this.firstName_box.MaxLength = 20;
            this.firstName_box.Name = "firstName_box";
            this.firstName_box.ReadOnly = true;
            this.firstName_box.Size = new System.Drawing.Size(136, 20);
            this.firstName_box.TabIndex = 0;
            // 
            // birthDatePicker_box
            // 
            this.birthDatePicker_box.CustomFormat = "dd/MM/yyyy";
            this.birthDatePicker_box.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDatePicker_box.Location = new System.Drawing.Point(8, 86);
            this.birthDatePicker_box.Name = "birthDatePicker_box";
            this.birthDatePicker_box.Size = new System.Drawing.Size(100, 20);
            this.birthDatePicker_box.TabIndex = 3;
            this.birthDatePicker_box.Value = new System.DateTime(2024, 4, 20, 0, 0, 0, 0);
            this.birthDatePicker_box.Visible = false;
            // 
            // middleName_box
            // 
            this.middleName_box.Location = new System.Drawing.Point(8, 60);
            this.middleName_box.MaxLength = 20;
            this.middleName_box.Name = "middleName_box";
            this.middleName_box.ReadOnly = true;
            this.middleName_box.Size = new System.Drawing.Size(136, 20);
            this.middleName_box.TabIndex = 2;
            // 
            // lastName_box
            // 
            this.lastName_box.Location = new System.Drawing.Point(8, 33);
            this.lastName_box.MaxLength = 20;
            this.lastName_box.Name = "lastName_box";
            this.lastName_box.ReadOnly = true;
            this.lastName_box.Size = new System.Drawing.Size(136, 20);
            this.lastName_box.TabIndex = 1;
            // 
            // birthDateMasked_box
            // 
            this.birthDateMasked_box.Location = new System.Drawing.Point(8, 86);
            this.birthDateMasked_box.Mask = "00\\/00\\/0000";
            this.birthDateMasked_box.Name = "birthDateMasked_box";
            this.birthDateMasked_box.ReadOnly = true;
            this.birthDateMasked_box.Size = new System.Drawing.Size(100, 20);
            this.birthDateMasked_box.TabIndex = 1;
            // 
            // phoneNumber_box
            // 
            this.phoneNumber_box.Location = new System.Drawing.Point(8, 112);
            this.phoneNumber_box.Mask = "+7 (999) 000 00 00";
            this.phoneNumber_box.Name = "phoneNumber_box";
            this.phoneNumber_box.ReadOnly = true;
            this.phoneNumber_box.Size = new System.Drawing.Size(100, 20);
            this.phoneNumber_box.TabIndex = 4;
            // 
            // cancel_button
            // 
            this.cancel_button.Enabled = false;
            this.cancel_button.Location = new System.Drawing.Point(259, 95);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 8;
            this.cancel_button.TabStop = false;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(259, 124);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 23);
            this.search_button.TabIndex = 9;
            this.search_button.TabStop = false;
            this.search_button.Text = "Поиск ▲";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // navigation_panel
            // 
            this.navigation_panel.Controls.Add(this.lastPosition_button);
            this.navigation_panel.Controls.Add(this.previousPosition_button);
            this.navigation_panel.Controls.Add(this.firstPosition_button);
            this.navigation_panel.Controls.Add(this.nextPosition_button);
            this.navigation_panel.Location = new System.Drawing.Point(15, 176);
            this.navigation_panel.Name = "navigation_panel";
            this.navigation_panel.Size = new System.Drawing.Size(318, 27);
            this.navigation_panel.TabIndex = 33;
            // 
            // lastPosition_button
            // 
            this.lastPosition_button.Location = new System.Drawing.Point(243, 0);
            this.lastPosition_button.Name = "lastPosition_button";
            this.lastPosition_button.Size = new System.Drawing.Size(75, 23);
            this.lastPosition_button.TabIndex = 13;
            this.lastPosition_button.TabStop = false;
            this.lastPosition_button.Text = "В конец";
            this.lastPosition_button.UseVisualStyleBackColor = true;
            this.lastPosition_button.Click += new System.EventHandler(this.lastPosition_button_Click);
            // 
            // previousPosition_button
            // 
            this.previousPosition_button.Location = new System.Drawing.Point(81, 0);
            this.previousPosition_button.Name = "previousPosition_button";
            this.previousPosition_button.Size = new System.Drawing.Size(75, 23);
            this.previousPosition_button.TabIndex = 11;
            this.previousPosition_button.TabStop = false;
            this.previousPosition_button.Text = "Назад";
            this.previousPosition_button.UseVisualStyleBackColor = true;
            this.previousPosition_button.Click += new System.EventHandler(this.previousPosition_button_Click);
            // 
            // firstPosition_button
            // 
            this.firstPosition_button.Location = new System.Drawing.Point(0, 0);
            this.firstPosition_button.Name = "firstPosition_button";
            this.firstPosition_button.Size = new System.Drawing.Size(75, 23);
            this.firstPosition_button.TabIndex = 10;
            this.firstPosition_button.TabStop = false;
            this.firstPosition_button.Text = "В начало";
            this.firstPosition_button.UseVisualStyleBackColor = true;
            this.firstPosition_button.Click += new System.EventHandler(this.firstPosition_button_Click);
            // 
            // nextPosition_button
            // 
            this.nextPosition_button.Location = new System.Drawing.Point(162, 0);
            this.nextPosition_button.Name = "nextPosition_button";
            this.nextPosition_button.Size = new System.Drawing.Size(75, 23);
            this.nextPosition_button.TabIndex = 12;
            this.nextPosition_button.TabStop = false;
            this.nextPosition_button.Text = "Вперёд";
            this.nextPosition_button.UseVisualStyleBackColor = true;
            this.nextPosition_button.Click += new System.EventHandler(this.nextPosition_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(259, 68);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 7;
            this.delete_button.TabStop = false;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(259, 41);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(75, 23);
            this.edit_button.TabIndex = 6;
            this.edit_button.TabStop = false;
            this.edit_button.Text = "Изменить";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // firstName_label
            // 
            this.firstName_label.AutoSize = true;
            this.firstName_label.Location = new System.Drawing.Point(12, 20);
            this.firstName_label.Name = "firstName_label";
            this.firstName_label.Size = new System.Drawing.Size(29, 13);
            this.firstName_label.TabIndex = 17;
            this.firstName_label.Text = "Имя";
            this.firstName_label.Click += new System.EventHandler(this.firstName_label_Click);
            // 
            // phoneNumber_label
            // 
            this.phoneNumber_label.AutoSize = true;
            this.phoneNumber_label.Location = new System.Drawing.Point(12, 125);
            this.phoneNumber_label.Name = "phoneNumber_label";
            this.phoneNumber_label.Size = new System.Drawing.Size(52, 13);
            this.phoneNumber_label.TabIndex = 26;
            this.phoneNumber_label.Text = "Телефон";
            this.phoneNumber_label.Click += new System.EventHandler(this.phoneNumber_label_Click);
            // 
            // birthDate_label
            // 
            this.birthDate_label.AutoSize = true;
            this.birthDate_label.Location = new System.Drawing.Point(12, 100);
            this.birthDate_label.Name = "birthDate_label";
            this.birthDate_label.Size = new System.Drawing.Size(86, 13);
            this.birthDate_label.TabIndex = 25;
            this.birthDate_label.Text = "Дата рождения";
            this.birthDate_label.Click += new System.EventHandler(this.birthDate_label_Click);
            // 
            // middleName_label
            // 
            this.middleName_label.AutoSize = true;
            this.middleName_label.Location = new System.Drawing.Point(12, 73);
            this.middleName_label.Name = "middleName_label";
            this.middleName_label.Size = new System.Drawing.Size(54, 13);
            this.middleName_label.TabIndex = 19;
            this.middleName_label.Text = "Отчество";
            this.middleName_label.Click += new System.EventHandler(this.middleName_label_Click);
            // 
            // lastName_label
            // 
            this.lastName_label.AutoSize = true;
            this.lastName_label.Location = new System.Drawing.Point(12, 46);
            this.lastName_label.Name = "lastName_label";
            this.lastName_label.Size = new System.Drawing.Size(56, 13);
            this.lastName_label.TabIndex = 18;
            this.lastName_label.Text = "Фамилия";
            this.lastName_label.Click += new System.EventHandler(this.lastName_label_Click);
            // 
            // ok_button
            // 
            this.ok_button.Enabled = false;
            this.ok_button.Location = new System.Drawing.Point(259, 15);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 5;
            this.ok_button.TabStop = false;
            this.ok_button.Text = "Ок";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Visible = false;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(259, 15);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 27;
            this.add_button.TabStop = false;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // radioBox
            // 
            this.radioBox.Controls.Add(this.or);
            this.radioBox.Controls.Add(this.and);
            this.radioBox.Location = new System.Drawing.Point(277, 39);
            this.radioBox.Name = "radioBox";
            this.radioBox.Size = new System.Drawing.Size(57, 66);
            this.radioBox.TabIndex = 47;
            this.radioBox.TabStop = false;
            // 
            // or
            // 
            this.or.AutoSize = true;
            this.or.Checked = true;
            this.or.Location = new System.Drawing.Point(6, 42);
            this.or.Name = "or";
            this.or.Size = new System.Drawing.Size(41, 17);
            this.or.TabIndex = 1;
            this.or.TabStop = true;
            this.or.Text = "OR";
            this.or.UseVisualStyleBackColor = true;
            // 
            // and
            // 
            this.and.AutoSize = true;
            this.and.Location = new System.Drawing.Point(6, 19);
            this.and.Name = "and";
            this.and.Size = new System.Drawing.Size(48, 17);
            this.and.TabIndex = 0;
            this.and.TabStop = true;
            this.and.Text = "AND";
            this.and.UseVisualStyleBackColor = true;
            // 
            // goSearch_button
            // 
            this.goSearch_button.Location = new System.Drawing.Point(259, 148);
            this.goSearch_button.Name = "goSearch_button";
            this.goSearch_button.Size = new System.Drawing.Size(75, 23);
            this.goSearch_button.TabIndex = 46;
            this.goSearch_button.TabStop = false;
            this.goSearch_button.Text = "Искать";
            this.goSearch_button.UseVisualStyleBackColor = true;
            this.goSearch_button.Click += new System.EventHandler(this.goSearch_button_Click);
            // 
            // anything_search
            // 
            this.anything_search.Location = new System.Drawing.Point(15, 150);
            this.anything_search.MaxLength = 20;
            this.anything_search.Name = "anything_search";
            this.anything_search.Size = new System.Drawing.Size(225, 20);
            this.anything_search.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 44;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.phoneNumber_check);
            this.panel1.Controls.Add(this.birthDatePicker_check);
            this.panel1.Controls.Add(this.middleName_check);
            this.panel1.Controls.Add(this.lastName_check);
            this.panel1.Controls.Add(this.firstName_check);
            this.panel1.Controls.Add(this.firstName_search);
            this.panel1.Controls.Add(this.birthDatePicker_search);
            this.panel1.Controls.Add(this.middleName_search);
            this.panel1.Controls.Add(this.lastName_search);
            this.panel1.Controls.Add(this.phoneNumber_search);
            this.panel1.Location = new System.Drawing.Point(96, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 141);
            this.panel1.TabIndex = 43;
            // 
            // phoneNumber_check
            // 
            this.phoneNumber_check.AutoSize = true;
            this.phoneNumber_check.Location = new System.Drawing.Point(151, 114);
            this.phoneNumber_check.Name = "phoneNumber_check";
            this.phoneNumber_check.Size = new System.Drawing.Size(15, 14);
            this.phoneNumber_check.TabIndex = 9;
            this.phoneNumber_check.UseVisualStyleBackColor = true;
            // 
            // birthDatePicker_check
            // 
            this.birthDatePicker_check.AutoSize = true;
            this.birthDatePicker_check.Location = new System.Drawing.Point(151, 88);
            this.birthDatePicker_check.Name = "birthDatePicker_check";
            this.birthDatePicker_check.Size = new System.Drawing.Size(15, 14);
            this.birthDatePicker_check.TabIndex = 8;
            this.birthDatePicker_check.UseVisualStyleBackColor = true;
            // 
            // middleName_check
            // 
            this.middleName_check.AutoSize = true;
            this.middleName_check.Location = new System.Drawing.Point(151, 62);
            this.middleName_check.Name = "middleName_check";
            this.middleName_check.Size = new System.Drawing.Size(15, 14);
            this.middleName_check.TabIndex = 7;
            this.middleName_check.UseVisualStyleBackColor = true;
            // 
            // lastName_check
            // 
            this.lastName_check.AutoSize = true;
            this.lastName_check.Location = new System.Drawing.Point(151, 35);
            this.lastName_check.Name = "lastName_check";
            this.lastName_check.Size = new System.Drawing.Size(15, 14);
            this.lastName_check.TabIndex = 6;
            this.lastName_check.UseVisualStyleBackColor = true;
            // 
            // firstName_check
            // 
            this.firstName_check.AutoSize = true;
            this.firstName_check.Location = new System.Drawing.Point(151, 9);
            this.firstName_check.Name = "firstName_check";
            this.firstName_check.Size = new System.Drawing.Size(15, 14);
            this.firstName_check.TabIndex = 5;
            this.firstName_check.UseVisualStyleBackColor = true;
            // 
            // firstName_search
            // 
            this.firstName_search.Location = new System.Drawing.Point(8, 7);
            this.firstName_search.MaxLength = 20;
            this.firstName_search.Name = "firstName_search";
            this.firstName_search.Size = new System.Drawing.Size(136, 20);
            this.firstName_search.TabIndex = 0;
            // 
            // birthDatePicker_search
            // 
            this.birthDatePicker_search.CustomFormat = "dd/MM/yyyy";
            this.birthDatePicker_search.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDatePicker_search.Location = new System.Drawing.Point(8, 86);
            this.birthDatePicker_search.Name = "birthDatePicker_search";
            this.birthDatePicker_search.Size = new System.Drawing.Size(100, 20);
            this.birthDatePicker_search.TabIndex = 3;
            this.birthDatePicker_search.Value = new System.DateTime(2024, 4, 20, 0, 0, 0, 0);
            // 
            // middleName_search
            // 
            this.middleName_search.Location = new System.Drawing.Point(8, 60);
            this.middleName_search.MaxLength = 20;
            this.middleName_search.Name = "middleName_search";
            this.middleName_search.Size = new System.Drawing.Size(136, 20);
            this.middleName_search.TabIndex = 2;
            // 
            // lastName_search
            // 
            this.lastName_search.Location = new System.Drawing.Point(8, 33);
            this.lastName_search.MaxLength = 20;
            this.lastName_search.Name = "lastName_search";
            this.lastName_search.Size = new System.Drawing.Size(136, 20);
            this.lastName_search.TabIndex = 1;
            // 
            // phoneNumber_search
            // 
            this.phoneNumber_search.Location = new System.Drawing.Point(8, 112);
            this.phoneNumber_search.Mask = "+7 (999) 000 00 00";
            this.phoneNumber_search.Name = "phoneNumber_search";
            this.phoneNumber_search.Size = new System.Drawing.Size(100, 20);
            this.phoneNumber_search.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Отчество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Фамилия";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(11, 188);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(325, 108);
            this.listBox.TabIndex = 1;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_Select);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // ContactBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(349, 530);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ContactBook";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Записная книжка";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.textBox_panel.ResumeLayout(false);
            this.textBox_panel.PerformLayout();
            this.navigation_panel.ResumeLayout(false);
            this.radioBox.ResumeLayout(false);
            this.radioBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        //private void Notebook_HardSave(object sender, System.Windows.Forms.FormClosingEventArgs e)
        //{
        //    throw new System.NotImplementedException();
        //}

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox firstName_box;
        private System.Windows.Forms.Label firstName_label;
        private System.Windows.Forms.Label phoneNumber_label;
        private System.Windows.Forms.Label birthDate_label;
        private System.Windows.Forms.DateTimePicker birthDatePicker_box;
        private System.Windows.Forms.MaskedTextBox phoneNumber_box;
        private System.Windows.Forms.TextBox middleName_box;
        private System.Windows.Forms.TextBox lastName_box;
        private System.Windows.Forms.Label middleName_label;
        private System.Windows.Forms.Label lastName_label;
        private System.Windows.Forms.Button previousPosition_button;
        private System.Windows.Forms.Button firstPosition_button;
        private System.Windows.Forms.Panel navigation_panel;
        private System.Windows.Forms.Button lastPosition_button;
        private System.Windows.Forms.Button nextPosition_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Panel textBox_panel;
        private System.Windows.Forms.MaskedTextBox birthDateMasked_box;
        private System.Windows.Forms.Label page_label;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox firstName_search;
        private System.Windows.Forms.DateTimePicker birthDatePicker_search;
        private System.Windows.Forms.TextBox middleName_search;
        private System.Windows.Forms.TextBox lastName_search;
        private System.Windows.Forms.MaskedTextBox phoneNumber_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox anything_search;
        private System.Windows.Forms.Button goSearch_button;
        private System.Windows.Forms.CheckBox phoneNumber_check;
        private System.Windows.Forms.CheckBox birthDatePicker_check;
        private System.Windows.Forms.CheckBox middleName_check;
        private System.Windows.Forms.CheckBox lastName_check;
        private System.Windows.Forms.CheckBox firstName_check;
        private System.Windows.Forms.GroupBox radioBox;
        private System.Windows.Forms.RadioButton or;
        private System.Windows.Forms.RadioButton and;
    }
}

