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
            this.textBox_panel = new System.Windows.Forms.Panel();
            this.firstName_box = new System.Windows.Forms.TextBox();
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
            this.searchPlaceholder_label = new System.Windows.Forms.Label();
            this.birthDatePicker_box = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.textBox_panel.SuspendLayout();
            this.navigation_panel.SuspendLayout();
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
            this.splitContainer.Panel2.Controls.Add(this.searchPlaceholder_label);
            this.splitContainer.Size = new System.Drawing.Size(349, 420);
            this.splitContainer.SplitterDistance = 192;
            this.splitContainer.TabIndex = 0;
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
            this.navigation_panel.Location = new System.Drawing.Point(15, 157);
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
            // searchPlaceholder_label
            // 
            this.searchPlaceholder_label.AutoSize = true;
            this.searchPlaceholder_label.Location = new System.Drawing.Point(15, 21);
            this.searchPlaceholder_label.Name = "searchPlaceholder_label";
            this.searchPlaceholder_label.Size = new System.Drawing.Size(55, 13);
            this.searchPlaceholder_label.TabIndex = 0;
            this.searchPlaceholder_label.Text = "тут поиск";
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
            // ContactBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(349, 420);
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
            this.ResumeLayout(false);

        }

        private void Notebook_HardSave(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            throw new System.NotImplementedException();
        }

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
        private System.Windows.Forms.Label searchPlaceholder_label;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Panel textBox_panel;
        private System.Windows.Forms.MaskedTextBox birthDateMasked_box;
    }
}

