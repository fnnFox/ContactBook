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
			this.dataTable = new System.Windows.Forms.DataGridView();
			this.page_label = new System.Windows.Forms.Label();
			this.main_table = new System.Windows.Forms.TableLayoutPanel();
			this.firstName_box = new System.Windows.Forms.TextBox();
			this.phoneNumber_box = new System.Windows.Forms.MaskedTextBox();
			this.middleName_box = new System.Windows.Forms.TextBox();
			this.firstName_label = new System.Windows.Forms.Label();
			this.lastName_box = new System.Windows.Forms.TextBox();
			this.lastName_label = new System.Windows.Forms.Label();
			this.middleName_label = new System.Windows.Forms.Label();
			this.birthDate_box = new System.Windows.Forms.MaskedTextBox();
			this.phoneNumber_label = new System.Windows.Forms.Label();
			this.birthDate_label = new System.Windows.Forms.Label();
			this.country_label = new System.Windows.Forms.Label();
			this.city_label = new System.Windows.Forms.Label();
			this.email_label = new System.Windows.Forms.Label();
			this.website_label = new System.Windows.Forms.Label();
			this.comment_label = new System.Windows.Forms.Label();
			this.country_box = new System.Windows.Forms.TextBox();
			this.city_box = new System.Windows.Forms.TextBox();
			this.email_box = new System.Windows.Forms.TextBox();
			this.website_box = new System.Windows.Forms.TextBox();
			this.comment_box = new System.Windows.Forms.TextBox();
			this.cancel_button = new System.Windows.Forms.Button();
			this.search_button = new System.Windows.Forms.Button();
			this.delete_button = new System.Windows.Forms.Button();
			this.edit_button = new System.Windows.Forms.Button();
			this.ok_button = new System.Windows.Forms.Button();
			this.add_button = new System.Windows.Forms.Button();
			this.andor_table = new System.Windows.Forms.TableLayoutPanel();
			this.or = new System.Windows.Forms.RadioButton();
			this.and = new System.Windows.Forms.RadioButton();
			this.search_table = new System.Windows.Forms.TableLayoutPanel();
			this.phoneNumber_check = new System.Windows.Forms.CheckBox();
			this.firstName_search = new System.Windows.Forms.TextBox();
			this.phoneNumber_search = new System.Windows.Forms.MaskedTextBox();
			this.birthDate_check = new System.Windows.Forms.CheckBox();
			this.firstName_check = new System.Windows.Forms.CheckBox();
			this.middleName_check = new System.Windows.Forms.CheckBox();
			this.phoneNumber_search_label = new System.Windows.Forms.Label();
			this.firstName_search_label = new System.Windows.Forms.Label();
			this.middleName_search_label = new System.Windows.Forms.Label();
			this.lastName_search_label = new System.Windows.Forms.Label();
			this.lastName_search = new System.Windows.Forms.TextBox();
			this.birthDate_search_label = new System.Windows.Forms.Label();
			this.lastName_check = new System.Windows.Forms.CheckBox();
			this.middleName_search = new System.Windows.Forms.TextBox();
			this.birthDate_search = new System.Windows.Forms.MaskedTextBox();
			this.country_search_label = new System.Windows.Forms.Label();
			this.city_search_label = new System.Windows.Forms.Label();
			this.country_check = new System.Windows.Forms.CheckBox();
			this.city_check = new System.Windows.Forms.CheckBox();
			this.country_search = new System.Windows.Forms.TextBox();
			this.city_search = new System.Windows.Forms.TextBox();
			this.anything_check = new System.Windows.Forms.CheckBox();
			this.goSearch_button = new System.Windows.Forms.Button();
			this.anything_search = new System.Windows.Forms.TextBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
			this.main_table.SuspendLayout();
			this.andor_table.SuspendLayout();
			this.search_table.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer
			// 
			this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer.IsSplitterFixed = true;
			this.splitContainer.Location = new System.Drawing.Point(0, 0);
			this.splitContainer.Name = "splitContainer";
			this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.dataTable);
			this.splitContainer.Panel1.Controls.Add(this.page_label);
			this.splitContainer.Panel1.Controls.Add(this.main_table);
			this.splitContainer.Panel1.Controls.Add(this.cancel_button);
			this.splitContainer.Panel1.Controls.Add(this.search_button);
			this.splitContainer.Panel1.Controls.Add(this.delete_button);
			this.splitContainer.Panel1.Controls.Add(this.edit_button);
			this.splitContainer.Panel1.Controls.Add(this.ok_button);
			this.splitContainer.Panel1.Controls.Add(this.add_button);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.andor_table);
			this.splitContainer.Panel2.Controls.Add(this.search_table);
			this.splitContainer.Panel2.Controls.Add(this.anything_check);
			this.splitContainer.Panel2.Controls.Add(this.goSearch_button);
			this.splitContainer.Panel2.Controls.Add(this.anything_search);
			this.splitContainer.Size = new System.Drawing.Size(393, 610);
			this.splitContainer.SplitterDistance = 384;
			this.splitContainer.TabIndex = 0;
			this.splitContainer.TabStop = false;
			// 
			// dataTable
			// 
			this.dataTable.AllowUserToAddRows = false;
			this.dataTable.AllowUserToDeleteRows = false;
			this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataTable.Location = new System.Drawing.Point(12, 256);
			this.dataTable.Name = "dataTable";
			this.dataTable.ReadOnly = true;
			this.dataTable.Size = new System.Drawing.Size(368, 114);
			this.dataTable.TabIndex = 51;
			this.dataTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listBox_Select);
			// 
			// page_label
			// 
			this.page_label.AutoSize = true;
			this.page_label.Location = new System.Drawing.Point(324, 229);
			this.page_label.Name = "page_label";
			this.page_label.Size = new System.Drawing.Size(31, 13);
			this.page_label.TabIndex = 37;
			this.page_label.Text = "page";
			// 
			// main_table
			// 
			this.main_table.AutoSize = true;
			this.main_table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.main_table.ColumnCount = 2;
			this.main_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
			this.main_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192F));
			this.main_table.Controls.Add(this.firstName_box, 1, 0);
			this.main_table.Controls.Add(this.phoneNumber_box, 1, 4);
			this.main_table.Controls.Add(this.middleName_box, 1, 2);
			this.main_table.Controls.Add(this.firstName_label, 0, 0);
			this.main_table.Controls.Add(this.lastName_box, 1, 1);
			this.main_table.Controls.Add(this.lastName_label, 0, 1);
			this.main_table.Controls.Add(this.middleName_label, 0, 2);
			this.main_table.Controls.Add(this.birthDate_box, 1, 3);
			this.main_table.Controls.Add(this.phoneNumber_label, 0, 4);
			this.main_table.Controls.Add(this.birthDate_label, 0, 3);
			this.main_table.Controls.Add(this.country_label, 0, 5);
			this.main_table.Controls.Add(this.city_label, 0, 6);
			this.main_table.Controls.Add(this.email_label, 0, 7);
			this.main_table.Controls.Add(this.website_label, 0, 8);
			this.main_table.Controls.Add(this.comment_label, 0, 9);
			this.main_table.Controls.Add(this.country_box, 1, 5);
			this.main_table.Controls.Add(this.city_box, 1, 6);
			this.main_table.Controls.Add(this.email_box, 1, 7);
			this.main_table.Controls.Add(this.website_box, 1, 8);
			this.main_table.Controls.Add(this.comment_box, 1, 9);
			this.main_table.Location = new System.Drawing.Point(11, 10);
			this.main_table.Name = "main_table";
			this.main_table.RowCount = 10;
			this.main_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.main_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.main_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.main_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.main_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.main_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.main_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.main_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.main_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.main_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.main_table.Size = new System.Drawing.Size(285, 240);
			this.main_table.TabIndex = 50;
			// 
			// firstName_box
			// 
			this.firstName_box.Dock = System.Windows.Forms.DockStyle.Left;
			this.firstName_box.Location = new System.Drawing.Point(96, 3);
			this.firstName_box.MaxLength = 20;
			this.firstName_box.Name = "firstName_box";
			this.firstName_box.ReadOnly = true;
			this.firstName_box.Size = new System.Drawing.Size(186, 20);
			this.firstName_box.TabIndex = 0;
			// 
			// phoneNumber_box
			// 
			this.phoneNumber_box.Dock = System.Windows.Forms.DockStyle.Left;
			this.phoneNumber_box.Location = new System.Drawing.Point(96, 99);
			this.phoneNumber_box.Mask = "+7 (999) 000 00 00";
			this.phoneNumber_box.Name = "phoneNumber_box";
			this.phoneNumber_box.ReadOnly = true;
			this.phoneNumber_box.Size = new System.Drawing.Size(103, 20);
			this.phoneNumber_box.TabIndex = 4;
			this.phoneNumber_box.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// middleName_box
			// 
			this.middleName_box.Dock = System.Windows.Forms.DockStyle.Left;
			this.middleName_box.Location = new System.Drawing.Point(96, 51);
			this.middleName_box.MaxLength = 20;
			this.middleName_box.Name = "middleName_box";
			this.middleName_box.ReadOnly = true;
			this.middleName_box.Size = new System.Drawing.Size(186, 20);
			this.middleName_box.TabIndex = 2;
			// 
			// firstName_label
			// 
			this.firstName_label.AutoSize = true;
			this.firstName_label.Dock = System.Windows.Forms.DockStyle.Left;
			this.firstName_label.Location = new System.Drawing.Point(3, 0);
			this.firstName_label.Name = "firstName_label";
			this.firstName_label.Size = new System.Drawing.Size(29, 24);
			this.firstName_label.TabIndex = 17;
			this.firstName_label.Text = "Имя";
			this.firstName_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lastName_box
			// 
			this.lastName_box.Dock = System.Windows.Forms.DockStyle.Left;
			this.lastName_box.Location = new System.Drawing.Point(96, 27);
			this.lastName_box.MaxLength = 20;
			this.lastName_box.Name = "lastName_box";
			this.lastName_box.ReadOnly = true;
			this.lastName_box.Size = new System.Drawing.Size(186, 20);
			this.lastName_box.TabIndex = 1;
			// 
			// lastName_label
			// 
			this.lastName_label.AutoSize = true;
			this.lastName_label.Dock = System.Windows.Forms.DockStyle.Left;
			this.lastName_label.Location = new System.Drawing.Point(3, 24);
			this.lastName_label.Name = "lastName_label";
			this.lastName_label.Size = new System.Drawing.Size(56, 24);
			this.lastName_label.TabIndex = 18;
			this.lastName_label.Text = "Фамилия";
			this.lastName_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// middleName_label
			// 
			this.middleName_label.AutoSize = true;
			this.middleName_label.Dock = System.Windows.Forms.DockStyle.Left;
			this.middleName_label.Location = new System.Drawing.Point(3, 48);
			this.middleName_label.Name = "middleName_label";
			this.middleName_label.Size = new System.Drawing.Size(54, 24);
			this.middleName_label.TabIndex = 19;
			this.middleName_label.Text = "Отчество";
			this.middleName_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// birthDate_box
			// 
			this.birthDate_box.Location = new System.Drawing.Point(96, 75);
			this.birthDate_box.Mask = "00\\/00\\/0000";
			this.birthDate_box.Name = "birthDate_box";
			this.birthDate_box.ReadOnly = true;
			this.birthDate_box.Size = new System.Drawing.Size(103, 20);
			this.birthDate_box.TabIndex = 3;
			this.birthDate_box.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.birthDate_box.ValidatingType = typeof(System.DateTime);
			// 
			// phoneNumber_label
			// 
			this.phoneNumber_label.AutoSize = true;
			this.phoneNumber_label.Dock = System.Windows.Forms.DockStyle.Left;
			this.phoneNumber_label.Location = new System.Drawing.Point(3, 96);
			this.phoneNumber_label.Name = "phoneNumber_label";
			this.phoneNumber_label.Size = new System.Drawing.Size(52, 24);
			this.phoneNumber_label.TabIndex = 26;
			this.phoneNumber_label.Text = "Телефон";
			this.phoneNumber_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// birthDate_label
			// 
			this.birthDate_label.AutoSize = true;
			this.birthDate_label.Dock = System.Windows.Forms.DockStyle.Left;
			this.birthDate_label.Location = new System.Drawing.Point(3, 72);
			this.birthDate_label.Name = "birthDate_label";
			this.birthDate_label.Size = new System.Drawing.Size(86, 24);
			this.birthDate_label.TabIndex = 25;
			this.birthDate_label.Text = "Дата рождения";
			this.birthDate_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// country_label
			// 
			this.country_label.AutoSize = true;
			this.country_label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.country_label.Location = new System.Drawing.Point(3, 120);
			this.country_label.Name = "country_label";
			this.country_label.Size = new System.Drawing.Size(87, 24);
			this.country_label.TabIndex = 27;
			this.country_label.Text = "Страна";
			this.country_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// city_label
			// 
			this.city_label.AutoSize = true;
			this.city_label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.city_label.Location = new System.Drawing.Point(3, 144);
			this.city_label.Name = "city_label";
			this.city_label.Size = new System.Drawing.Size(87, 24);
			this.city_label.TabIndex = 28;
			this.city_label.Text = "Город";
			this.city_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// email_label
			// 
			this.email_label.AutoSize = true;
			this.email_label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.email_label.Location = new System.Drawing.Point(3, 168);
			this.email_label.Name = "email_label";
			this.email_label.Size = new System.Drawing.Size(87, 24);
			this.email_label.TabIndex = 29;
			this.email_label.Text = "Эл. почта";
			this.email_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// website_label
			// 
			this.website_label.AutoSize = true;
			this.website_label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.website_label.Location = new System.Drawing.Point(3, 192);
			this.website_label.Name = "website_label";
			this.website_label.Size = new System.Drawing.Size(87, 24);
			this.website_label.TabIndex = 30;
			this.website_label.Text = "Вебсайт";
			this.website_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// comment_label
			// 
			this.comment_label.AutoSize = true;
			this.comment_label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comment_label.Location = new System.Drawing.Point(3, 216);
			this.comment_label.Name = "comment_label";
			this.comment_label.Size = new System.Drawing.Size(87, 24);
			this.comment_label.TabIndex = 31;
			this.comment_label.Text = "Примечания";
			this.comment_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// country_box
			// 
			this.country_box.Dock = System.Windows.Forms.DockStyle.Left;
			this.country_box.Location = new System.Drawing.Point(96, 123);
			this.country_box.MaxLength = 20;
			this.country_box.Name = "country_box";
			this.country_box.ReadOnly = true;
			this.country_box.Size = new System.Drawing.Size(186, 20);
			this.country_box.TabIndex = 5;
			// 
			// city_box
			// 
			this.city_box.Dock = System.Windows.Forms.DockStyle.Left;
			this.city_box.Location = new System.Drawing.Point(96, 147);
			this.city_box.MaxLength = 20;
			this.city_box.Name = "city_box";
			this.city_box.ReadOnly = true;
			this.city_box.Size = new System.Drawing.Size(186, 20);
			this.city_box.TabIndex = 6;
			// 
			// email_box
			// 
			this.email_box.Dock = System.Windows.Forms.DockStyle.Left;
			this.email_box.Location = new System.Drawing.Point(96, 171);
			this.email_box.MaxLength = 20;
			this.email_box.Name = "email_box";
			this.email_box.ReadOnly = true;
			this.email_box.Size = new System.Drawing.Size(186, 20);
			this.email_box.TabIndex = 7;
			// 
			// website_box
			// 
			this.website_box.Dock = System.Windows.Forms.DockStyle.Left;
			this.website_box.Location = new System.Drawing.Point(96, 195);
			this.website_box.MaxLength = 20;
			this.website_box.Name = "website_box";
			this.website_box.ReadOnly = true;
			this.website_box.Size = new System.Drawing.Size(186, 20);
			this.website_box.TabIndex = 8;
			// 
			// comment_box
			// 
			this.comment_box.Dock = System.Windows.Forms.DockStyle.Left;
			this.comment_box.Location = new System.Drawing.Point(96, 219);
			this.comment_box.MaxLength = 20;
			this.comment_box.Name = "comment_box";
			this.comment_box.ReadOnly = true;
			this.comment_box.Size = new System.Drawing.Size(186, 20);
			this.comment_box.TabIndex = 9;
			// 
			// cancel_button
			// 
			this.cancel_button.Enabled = false;
			this.cancel_button.Location = new System.Drawing.Point(305, 93);
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
			this.search_button.Location = new System.Drawing.Point(305, 122);
			this.search_button.Name = "search_button";
			this.search_button.Size = new System.Drawing.Size(75, 23);
			this.search_button.TabIndex = 9;
			this.search_button.TabStop = false;
			this.search_button.Text = "Поиск ▲";
			this.search_button.UseVisualStyleBackColor = true;
			this.search_button.Click += new System.EventHandler(this.search_button_Click);
			// 
			// delete_button
			// 
			this.delete_button.Location = new System.Drawing.Point(305, 66);
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
			this.edit_button.Location = new System.Drawing.Point(305, 39);
			this.edit_button.Name = "edit_button";
			this.edit_button.Size = new System.Drawing.Size(75, 23);
			this.edit_button.TabIndex = 6;
			this.edit_button.TabStop = false;
			this.edit_button.Text = "Изменить";
			this.edit_button.UseVisualStyleBackColor = true;
			this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
			// 
			// ok_button
			// 
			this.ok_button.Enabled = false;
			this.ok_button.Location = new System.Drawing.Point(305, 13);
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
			this.add_button.Location = new System.Drawing.Point(305, 13);
			this.add_button.Name = "add_button";
			this.add_button.Size = new System.Drawing.Size(75, 23);
			this.add_button.TabIndex = 27;
			this.add_button.TabStop = false;
			this.add_button.Text = "Добавить";
			this.add_button.UseVisualStyleBackColor = true;
			this.add_button.Click += new System.EventHandler(this.add_button_Click);
			// 
			// andor_table
			// 
			this.andor_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.andor_table.ColumnCount = 1;
			this.andor_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.andor_table.Controls.Add(this.or, 0, 1);
			this.andor_table.Controls.Add(this.and, 0, 0);
			this.andor_table.Location = new System.Drawing.Point(324, 51);
			this.andor_table.Name = "andor_table";
			this.andor_table.RowCount = 2;
			this.andor_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.andor_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.andor_table.Size = new System.Drawing.Size(56, 50);
			this.andor_table.TabIndex = 50;
			// 
			// or
			// 
			this.or.AutoSize = true;
			this.or.Checked = true;
			this.or.Dock = System.Windows.Forms.DockStyle.Left;
			this.or.Location = new System.Drawing.Point(4, 28);
			this.or.Name = "or";
			this.or.Size = new System.Drawing.Size(41, 18);
			this.or.TabIndex = 1;
			this.or.TabStop = true;
			this.or.Text = "OR";
			this.or.UseVisualStyleBackColor = true;
			// 
			// and
			// 
			this.and.AutoSize = true;
			this.and.Dock = System.Windows.Forms.DockStyle.Left;
			this.and.Location = new System.Drawing.Point(4, 4);
			this.and.Name = "and";
			this.and.Size = new System.Drawing.Size(48, 17);
			this.and.TabIndex = 0;
			this.and.Text = "AND";
			this.and.UseVisualStyleBackColor = true;
			// 
			// search_table
			// 
			this.search_table.AutoSize = true;
			this.search_table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.search_table.ColumnCount = 3;
			this.search_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
			this.search_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F));
			this.search_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.search_table.Controls.Add(this.phoneNumber_check, 2, 4);
			this.search_table.Controls.Add(this.firstName_search, 1, 0);
			this.search_table.Controls.Add(this.phoneNumber_search, 1, 4);
			this.search_table.Controls.Add(this.birthDate_check, 2, 3);
			this.search_table.Controls.Add(this.firstName_check, 2, 0);
			this.search_table.Controls.Add(this.middleName_check, 2, 2);
			this.search_table.Controls.Add(this.phoneNumber_search_label, 0, 4);
			this.search_table.Controls.Add(this.firstName_search_label, 0, 0);
			this.search_table.Controls.Add(this.middleName_search_label, 0, 2);
			this.search_table.Controls.Add(this.lastName_search_label, 0, 1);
			this.search_table.Controls.Add(this.lastName_search, 1, 1);
			this.search_table.Controls.Add(this.birthDate_search_label, 0, 3);
			this.search_table.Controls.Add(this.lastName_check, 2, 1);
			this.search_table.Controls.Add(this.middleName_search, 1, 2);
			this.search_table.Controls.Add(this.birthDate_search, 1, 3);
			this.search_table.Controls.Add(this.country_search_label, 0, 5);
			this.search_table.Controls.Add(this.city_search_label, 0, 6);
			this.search_table.Controls.Add(this.country_check, 2, 5);
			this.search_table.Controls.Add(this.city_check, 2, 6);
			this.search_table.Controls.Add(this.country_search, 1, 5);
			this.search_table.Controls.Add(this.city_search, 1, 6);
			this.search_table.Location = new System.Drawing.Point(11, 8);
			this.search_table.Name = "search_table";
			this.search_table.RowCount = 7;
			this.search_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.search_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.search_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.search_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.search_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.search_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.search_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.search_table.Size = new System.Drawing.Size(303, 168);
			this.search_table.TabIndex = 49;
			// 
			// phoneNumber_check
			// 
			this.phoneNumber_check.AutoSize = true;
			this.phoneNumber_check.Dock = System.Windows.Forms.DockStyle.Fill;
			this.phoneNumber_check.Location = new System.Drawing.Point(285, 99);
			this.phoneNumber_check.Name = "phoneNumber_check";
			this.phoneNumber_check.Size = new System.Drawing.Size(15, 18);
			this.phoneNumber_check.TabIndex = 9;
			this.phoneNumber_check.TabStop = false;
			this.phoneNumber_check.UseVisualStyleBackColor = true;
			// 
			// firstName_search
			// 
			this.firstName_search.Dock = System.Windows.Forms.DockStyle.Left;
			this.firstName_search.Location = new System.Drawing.Point(99, 3);
			this.firstName_search.MaxLength = 20;
			this.firstName_search.Name = "firstName_search";
			this.firstName_search.Size = new System.Drawing.Size(180, 20);
			this.firstName_search.TabIndex = 0;
			// 
			// phoneNumber_search
			// 
			this.phoneNumber_search.Dock = System.Windows.Forms.DockStyle.Left;
			this.phoneNumber_search.Location = new System.Drawing.Point(99, 99);
			this.phoneNumber_search.Mask = "+7 (999) 000 00 00";
			this.phoneNumber_search.Name = "phoneNumber_search";
			this.phoneNumber_search.Size = new System.Drawing.Size(100, 20);
			this.phoneNumber_search.TabIndex = 4;
			this.phoneNumber_search.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// birthDate_check
			// 
			this.birthDate_check.AutoSize = true;
			this.birthDate_check.Dock = System.Windows.Forms.DockStyle.Fill;
			this.birthDate_check.Location = new System.Drawing.Point(285, 75);
			this.birthDate_check.Name = "birthDate_check";
			this.birthDate_check.Size = new System.Drawing.Size(15, 18);
			this.birthDate_check.TabIndex = 8;
			this.birthDate_check.TabStop = false;
			this.birthDate_check.UseVisualStyleBackColor = true;
			// 
			// firstName_check
			// 
			this.firstName_check.AutoSize = true;
			this.firstName_check.Dock = System.Windows.Forms.DockStyle.Fill;
			this.firstName_check.Location = new System.Drawing.Point(285, 3);
			this.firstName_check.Name = "firstName_check";
			this.firstName_check.Size = new System.Drawing.Size(15, 18);
			this.firstName_check.TabIndex = 5;
			this.firstName_check.TabStop = false;
			this.firstName_check.UseVisualStyleBackColor = true;
			// 
			// middleName_check
			// 
			this.middleName_check.AutoSize = true;
			this.middleName_check.Dock = System.Windows.Forms.DockStyle.Fill;
			this.middleName_check.Location = new System.Drawing.Point(285, 51);
			this.middleName_check.Name = "middleName_check";
			this.middleName_check.Size = new System.Drawing.Size(15, 18);
			this.middleName_check.TabIndex = 7;
			this.middleName_check.TabStop = false;
			this.middleName_check.UseVisualStyleBackColor = true;
			// 
			// phoneNumber_search_label
			// 
			this.phoneNumber_search_label.AutoSize = true;
			this.phoneNumber_search_label.Dock = System.Windows.Forms.DockStyle.Left;
			this.phoneNumber_search_label.Location = new System.Drawing.Point(3, 96);
			this.phoneNumber_search_label.Name = "phoneNumber_search_label";
			this.phoneNumber_search_label.Size = new System.Drawing.Size(52, 24);
			this.phoneNumber_search_label.TabIndex = 42;
			this.phoneNumber_search_label.Text = "Телефон";
			this.phoneNumber_search_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// firstName_search_label
			// 
			this.firstName_search_label.AutoSize = true;
			this.firstName_search_label.Dock = System.Windows.Forms.DockStyle.Left;
			this.firstName_search_label.Location = new System.Drawing.Point(3, 0);
			this.firstName_search_label.Name = "firstName_search_label";
			this.firstName_search_label.Size = new System.Drawing.Size(29, 24);
			this.firstName_search_label.TabIndex = 38;
			this.firstName_search_label.Text = "Имя";
			this.firstName_search_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// middleName_search_label
			// 
			this.middleName_search_label.AutoSize = true;
			this.middleName_search_label.Dock = System.Windows.Forms.DockStyle.Left;
			this.middleName_search_label.Location = new System.Drawing.Point(3, 48);
			this.middleName_search_label.Name = "middleName_search_label";
			this.middleName_search_label.Size = new System.Drawing.Size(54, 24);
			this.middleName_search_label.TabIndex = 40;
			this.middleName_search_label.Text = "Отчество";
			this.middleName_search_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lastName_search_label
			// 
			this.lastName_search_label.AutoSize = true;
			this.lastName_search_label.Dock = System.Windows.Forms.DockStyle.Left;
			this.lastName_search_label.Location = new System.Drawing.Point(3, 24);
			this.lastName_search_label.Name = "lastName_search_label";
			this.lastName_search_label.Size = new System.Drawing.Size(56, 24);
			this.lastName_search_label.TabIndex = 39;
			this.lastName_search_label.Text = "Фамилия";
			this.lastName_search_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lastName_search
			// 
			this.lastName_search.Dock = System.Windows.Forms.DockStyle.Left;
			this.lastName_search.Location = new System.Drawing.Point(99, 27);
			this.lastName_search.MaxLength = 20;
			this.lastName_search.Name = "lastName_search";
			this.lastName_search.Size = new System.Drawing.Size(180, 20);
			this.lastName_search.TabIndex = 1;
			// 
			// birthDate_search_label
			// 
			this.birthDate_search_label.AutoSize = true;
			this.birthDate_search_label.Dock = System.Windows.Forms.DockStyle.Left;
			this.birthDate_search_label.Location = new System.Drawing.Point(3, 72);
			this.birthDate_search_label.Name = "birthDate_search_label";
			this.birthDate_search_label.Size = new System.Drawing.Size(86, 24);
			this.birthDate_search_label.TabIndex = 41;
			this.birthDate_search_label.Text = "Дата рождения";
			this.birthDate_search_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lastName_check
			// 
			this.lastName_check.AutoSize = true;
			this.lastName_check.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lastName_check.Location = new System.Drawing.Point(285, 27);
			this.lastName_check.Name = "lastName_check";
			this.lastName_check.Size = new System.Drawing.Size(15, 18);
			this.lastName_check.TabIndex = 6;
			this.lastName_check.TabStop = false;
			this.lastName_check.UseVisualStyleBackColor = true;
			// 
			// middleName_search
			// 
			this.middleName_search.Dock = System.Windows.Forms.DockStyle.Left;
			this.middleName_search.Location = new System.Drawing.Point(99, 51);
			this.middleName_search.MaxLength = 20;
			this.middleName_search.Name = "middleName_search";
			this.middleName_search.Size = new System.Drawing.Size(180, 20);
			this.middleName_search.TabIndex = 2;
			// 
			// birthDate_search
			// 
			this.birthDate_search.Dock = System.Windows.Forms.DockStyle.Left;
			this.birthDate_search.Location = new System.Drawing.Point(99, 75);
			this.birthDate_search.Mask = "00\\/00\\/0000";
			this.birthDate_search.Name = "birthDate_search";
			this.birthDate_search.Size = new System.Drawing.Size(100, 20);
			this.birthDate_search.TabIndex = 3;
			this.birthDate_search.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// country_search_label
			// 
			this.country_search_label.AutoSize = true;
			this.country_search_label.Dock = System.Windows.Forms.DockStyle.Left;
			this.country_search_label.Location = new System.Drawing.Point(3, 120);
			this.country_search_label.Name = "country_search_label";
			this.country_search_label.Size = new System.Drawing.Size(43, 24);
			this.country_search_label.TabIndex = 44;
			this.country_search_label.Text = "Страна";
			this.country_search_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// city_search_label
			// 
			this.city_search_label.AutoSize = true;
			this.city_search_label.Dock = System.Windows.Forms.DockStyle.Left;
			this.city_search_label.Location = new System.Drawing.Point(3, 144);
			this.city_search_label.Name = "city_search_label";
			this.city_search_label.Size = new System.Drawing.Size(37, 24);
			this.city_search_label.TabIndex = 45;
			this.city_search_label.Text = "Город";
			this.city_search_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// country_check
			// 
			this.country_check.AutoSize = true;
			this.country_check.Dock = System.Windows.Forms.DockStyle.Fill;
			this.country_check.Location = new System.Drawing.Point(285, 123);
			this.country_check.Name = "country_check";
			this.country_check.Size = new System.Drawing.Size(15, 18);
			this.country_check.TabIndex = 46;
			this.country_check.TabStop = false;
			this.country_check.UseVisualStyleBackColor = true;
			// 
			// city_check
			// 
			this.city_check.AutoSize = true;
			this.city_check.Dock = System.Windows.Forms.DockStyle.Fill;
			this.city_check.Location = new System.Drawing.Point(285, 147);
			this.city_check.Name = "city_check";
			this.city_check.Size = new System.Drawing.Size(15, 18);
			this.city_check.TabIndex = 47;
			this.city_check.TabStop = false;
			this.city_check.UseVisualStyleBackColor = true;
			// 
			// country_search
			// 
			this.country_search.Dock = System.Windows.Forms.DockStyle.Left;
			this.country_search.Location = new System.Drawing.Point(99, 123);
			this.country_search.MaxLength = 20;
			this.country_search.Name = "country_search";
			this.country_search.Size = new System.Drawing.Size(180, 20);
			this.country_search.TabIndex = 5;
			// 
			// city_search
			// 
			this.city_search.Dock = System.Windows.Forms.DockStyle.Left;
			this.city_search.Location = new System.Drawing.Point(99, 147);
			this.city_search.MaxLength = 20;
			this.city_search.Name = "city_search";
			this.city_search.Size = new System.Drawing.Size(180, 20);
			this.city_search.TabIndex = 6;
			// 
			// anything_check
			// 
			this.anything_check.AutoSize = true;
			this.anything_check.Location = new System.Drawing.Point(278, 190);
			this.anything_check.Name = "anything_check";
			this.anything_check.Size = new System.Drawing.Size(15, 14);
			this.anything_check.TabIndex = 48;
			this.anything_check.TabStop = false;
			this.anything_check.UseVisualStyleBackColor = true;
			// 
			// goSearch_button
			// 
			this.goSearch_button.Location = new System.Drawing.Point(301, 185);
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
			this.anything_search.Location = new System.Drawing.Point(16, 187);
			this.anything_search.MaxLength = 20;
			this.anything_search.Name = "anything_search";
			this.anything_search.Size = new System.Drawing.Size(252, 20);
			this.anything_search.TabIndex = 7;
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
			this.ClientSize = new System.Drawing.Size(393, 610);
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
			((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
			this.main_table.ResumeLayout(false);
			this.main_table.PerformLayout();
			this.andor_table.ResumeLayout(false);
			this.andor_table.PerformLayout();
			this.search_table.ResumeLayout(false);
			this.search_table.PerformLayout();
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
        private System.Windows.Forms.MaskedTextBox phoneNumber_box;
        private System.Windows.Forms.TextBox middleName_box;
        private System.Windows.Forms.TextBox lastName_box;
        private System.Windows.Forms.Label middleName_label;
        private System.Windows.Forms.Label lastName_label;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.MaskedTextBox birthDate_box;
        private System.Windows.Forms.Label page_label;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox firstName_search;
        private System.Windows.Forms.TextBox middleName_search;
        private System.Windows.Forms.TextBox lastName_search;
        private System.Windows.Forms.MaskedTextBox phoneNumber_search;
        private System.Windows.Forms.Label firstName_search_label;
        private System.Windows.Forms.Label phoneNumber_search_label;
        private System.Windows.Forms.Label birthDate_search_label;
        private System.Windows.Forms.Label middleName_search_label;
        private System.Windows.Forms.Label lastName_search_label;
        private System.Windows.Forms.TextBox anything_search;
        private System.Windows.Forms.Button goSearch_button;
        private System.Windows.Forms.CheckBox phoneNumber_check;
        private System.Windows.Forms.CheckBox birthDate_check;
        private System.Windows.Forms.CheckBox middleName_check;
        private System.Windows.Forms.CheckBox lastName_check;
        private System.Windows.Forms.CheckBox firstName_check;
		private System.Windows.Forms.CheckBox anything_check;
		private System.Windows.Forms.TableLayoutPanel search_table;
		private System.Windows.Forms.TableLayoutPanel main_table;
		private System.Windows.Forms.MaskedTextBox birthDate_search;
		private System.Windows.Forms.TableLayoutPanel andor_table;
		private System.Windows.Forms.RadioButton or;
		private System.Windows.Forms.RadioButton and;
		private System.Windows.Forms.Label country_search_label;
		private System.Windows.Forms.Label city_search_label;
		private System.Windows.Forms.CheckBox country_check;
		private System.Windows.Forms.CheckBox city_check;
		private System.Windows.Forms.TextBox country_search;
		private System.Windows.Forms.TextBox city_search;
		private System.Windows.Forms.Label country_label;
		private System.Windows.Forms.Label city_label;
		private System.Windows.Forms.Label email_label;
		private System.Windows.Forms.Label website_label;
		private System.Windows.Forms.Label comment_label;
		private System.Windows.Forms.TextBox country_box;
		private System.Windows.Forms.TextBox city_box;
		private System.Windows.Forms.TextBox email_box;
		private System.Windows.Forms.TextBox website_box;
		private System.Windows.Forms.TextBox comment_box;
		private System.Windows.Forms.DataGridView dataTable;
	}
}

