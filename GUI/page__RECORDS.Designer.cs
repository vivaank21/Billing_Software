namespace Billing_Software.GUI
{
    partial class page__RECORDS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelforHeading = new System.Windows.Forms.Label();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.panelforSearchDetails = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBox__SearchVal = new System.Windows.Forms.TextBox();
            this.panelForDate = new System.Windows.Forms.Panel();
            this.labelForToDate = new System.Windows.Forms.Label();
            this.InvoiceToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelForFromDate = new System.Windows.Forms.Label();
            this.InvoiceFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelforProductDetails = new System.Windows.Forms.Label();
            this.button__ShoeSearch = new System.Windows.Forms.Button();
            this.labelForSearchValue = new System.Windows.Forms.Label();
            this.labelforCategoryName = new System.Windows.Forms.Label();
            this.comboBox__SelectSearchOption = new System.Windows.Forms.ComboBox();
            this.panelforProductFields = new System.Windows.Forms.Panel();
            this.dataGridViewforSales = new System.Windows.Forms.DataGridView();
            this.invoiceno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoicedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customercontact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeraddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grandtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            this.panelforSearchDetails.SuspendLayout();
            this.panelForDate.SuspendLayout();
            this.panelforProductFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewforSales)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.panelHeader.Controls.Add(this.labelforHeading);
            this.panelHeader.Controls.Add(this.pictureBox_close);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1607, 69);
            this.panelHeader.TabIndex = 2;
            // 
            // labelforHeading
            // 
            this.labelforHeading.AutoSize = true;
            this.labelforHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelforHeading.Font = new System.Drawing.Font("Baskerville Old Face", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelforHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.labelforHeading.Location = new System.Drawing.Point(544, 5);
            this.labelforHeading.Name = "labelforHeading";
            this.labelforHeading.Size = new System.Drawing.Size(460, 53);
            this.labelforHeading.TabIndex = 1;
            this.labelforHeading.Text = "INVOICE REPORTS";
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.Image = global::Billing_Software.Properties.Resources.closeIcon;
            this.pictureBox_close.Location = new System.Drawing.Point(1548, 8);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(47, 48);
            this.pictureBox_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_close.TabIndex = 2;
            this.pictureBox_close.TabStop = false;
            this.pictureBox_close.Click += new System.EventHandler(this.pictureBox_close_Click);
            // 
            // panelforSearchDetails
            // 
            this.panelforSearchDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelforSearchDetails.Controls.Add(this.buttonClear);
            this.panelforSearchDetails.Controls.Add(this.textBox__SearchVal);
            this.panelforSearchDetails.Controls.Add(this.panelForDate);
            this.panelforSearchDetails.Controls.Add(this.button__ShoeSearch);
            this.panelforSearchDetails.Controls.Add(this.labelForSearchValue);
            this.panelforSearchDetails.Controls.Add(this.labelforCategoryName);
            this.panelforSearchDetails.Controls.Add(this.comboBox__SelectSearchOption);
            this.panelforSearchDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.panelforSearchDetails.Location = new System.Drawing.Point(5, 64);
            this.panelforSearchDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelforSearchDetails.Name = "panelforSearchDetails";
            this.panelforSearchDetails.Size = new System.Drawing.Size(1601, 187);
            this.panelforSearchDetails.TabIndex = 12;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.buttonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.buttonClear.Location = new System.Drawing.Point(749, 112);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(327, 68);
            this.buttonClear.TabIndex = 28;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBox__SearchVal
            // 
            this.textBox__SearchVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.textBox__SearchVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox__SearchVal.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox__SearchVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.textBox__SearchVal.Location = new System.Drawing.Point(380, 112);
            this.textBox__SearchVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox__SearchVal.Multiline = true;
            this.textBox__SearchVal.Name = "textBox__SearchVal";
            this.textBox__SearchVal.Size = new System.Drawing.Size(309, 40);
            this.textBox__SearchVal.TabIndex = 27;
            // 
            // panelForDate
            // 
            this.panelForDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForDate.Controls.Add(this.labelForToDate);
            this.panelForDate.Controls.Add(this.InvoiceToDateTimePicker);
            this.panelForDate.Controls.Add(this.labelForFromDate);
            this.panelForDate.Controls.Add(this.InvoiceFromDateTimePicker);
            this.panelForDate.Controls.Add(this.labelforProductDetails);
            this.panelForDate.Location = new System.Drawing.Point(1131, 11);
            this.panelForDate.Margin = new System.Windows.Forms.Padding(4);
            this.panelForDate.Name = "panelForDate";
            this.panelForDate.Size = new System.Drawing.Size(442, 174);
            this.panelForDate.TabIndex = 14;
            // 
            // labelForToDate
            // 
            this.labelForToDate.AutoSize = true;
            this.labelForToDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForToDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelForToDate.Location = new System.Drawing.Point(3, 119);
            this.labelForToDate.Name = "labelForToDate";
            this.labelForToDate.Size = new System.Drawing.Size(96, 28);
            this.labelForToDate.TabIndex = 26;
            this.labelForToDate.Text = "TO       :";
            // 
            // InvoiceToDateTimePicker
            // 
            this.InvoiceToDateTimePicker.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceToDateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.InvoiceToDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.InvoiceToDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.InvoiceToDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.InvoiceToDateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.InvoiceToDateTimePicker.Enabled = false;
            this.InvoiceToDateTimePicker.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceToDateTimePicker.Location = new System.Drawing.Point(111, 114);
            this.InvoiceToDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InvoiceToDateTimePicker.Name = "InvoiceToDateTimePicker";
            this.InvoiceToDateTimePicker.Size = new System.Drawing.Size(315, 35);
            this.InvoiceToDateTimePicker.TabIndex = 25;
            // 
            // labelForFromDate
            // 
            this.labelForFromDate.AutoSize = true;
            this.labelForFromDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForFromDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelForFromDate.Location = new System.Drawing.Point(3, 57);
            this.labelForFromDate.Name = "labelForFromDate";
            this.labelForFromDate.Size = new System.Drawing.Size(96, 28);
            this.labelForFromDate.TabIndex = 24;
            this.labelForFromDate.Text = "FROM :";
            // 
            // InvoiceFromDateTimePicker
            // 
            this.InvoiceFromDateTimePicker.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceFromDateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.InvoiceFromDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.InvoiceFromDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.InvoiceFromDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.InvoiceFromDateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.InvoiceFromDateTimePicker.Enabled = false;
            this.InvoiceFromDateTimePicker.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceFromDateTimePicker.Location = new System.Drawing.Point(111, 52);
            this.InvoiceFromDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InvoiceFromDateTimePicker.Name = "InvoiceFromDateTimePicker";
            this.InvoiceFromDateTimePicker.Size = new System.Drawing.Size(315, 35);
            this.InvoiceFromDateTimePicker.TabIndex = 15;
            // 
            // labelforProductDetails
            // 
            this.labelforProductDetails.AutoSize = true;
            this.labelforProductDetails.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelforProductDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelforProductDetails.Location = new System.Drawing.Point(3, 6);
            this.labelforProductDetails.Name = "labelforProductDetails";
            this.labelforProductDetails.Size = new System.Drawing.Size(203, 20);
            this.labelforProductDetails.TabIndex = 23;
            this.labelforProductDetails.Text = "SELECT INVOICE DATE";
            // 
            // button__ShoeSearch
            // 
            this.button__ShoeSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.button__ShoeSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.button__ShoeSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button__ShoeSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.button__ShoeSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.button__ShoeSearch.Location = new System.Drawing.Point(749, 27);
            this.button__ShoeSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button__ShoeSearch.Name = "button__ShoeSearch";
            this.button__ShoeSearch.Size = new System.Drawing.Size(327, 68);
            this.button__ShoeSearch.TabIndex = 13;
            this.button__ShoeSearch.Text = "SEARCH";
            this.button__ShoeSearch.UseVisualStyleBackColor = false;
            this.button__ShoeSearch.Click += new System.EventHandler(this.button__ShoeSearch_Click);
            // 
            // labelForSearchValue
            // 
            this.labelForSearchValue.AutoSize = true;
            this.labelForSearchValue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForSearchValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelForSearchValue.Location = new System.Drawing.Point(5, 120);
            this.labelForSearchValue.Name = "labelForSearchValue";
            this.labelForSearchValue.Size = new System.Drawing.Size(322, 28);
            this.labelForSearchValue.TabIndex = 4;
            this.labelForSearchValue.Text = "ENTER SEARCH VALUE    :";
            // 
            // labelforCategoryName
            // 
            this.labelforCategoryName.AutoSize = true;
            this.labelforCategoryName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelforCategoryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelforCategoryName.Location = new System.Drawing.Point(3, 32);
            this.labelforCategoryName.Name = "labelforCategoryName";
            this.labelforCategoryName.Size = new System.Drawing.Size(330, 28);
            this.labelforCategoryName.TabIndex = 2;
            this.labelforCategoryName.Text = "SELECT SEARCH OPTION :";
            // 
            // comboBox__SelectSearchOption
            // 
            this.comboBox__SelectSearchOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox__SelectSearchOption.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox__SelectSearchOption.FormattingEnabled = true;
            this.comboBox__SelectSearchOption.Items.AddRange(new object[] {
            "Customer Name",
            "Customer Contact",
            "Invoice Number",
            "Invoice Date Range"});
            this.comboBox__SelectSearchOption.Location = new System.Drawing.Point(380, 27);
            this.comboBox__SelectSearchOption.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox__SelectSearchOption.Name = "comboBox__SelectSearchOption";
            this.comboBox__SelectSearchOption.Size = new System.Drawing.Size(308, 38);
            this.comboBox__SelectSearchOption.TabIndex = 3;
            this.comboBox__SelectSearchOption.SelectedIndexChanged += new System.EventHandler(this.comboBox__SelectSearchOption_SelectedIndexChanged);
            // 
            // panelforProductFields
            // 
            this.panelforProductFields.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelforProductFields.Controls.Add(this.dataGridViewforSales);
            this.panelforProductFields.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.panelforProductFields.Location = new System.Drawing.Point(0, 256);
            this.panelforProductFields.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelforProductFields.Name = "panelforProductFields";
            this.panelforProductFields.Size = new System.Drawing.Size(1606, 670);
            this.panelforProductFields.TabIndex = 13;
            // 
            // dataGridViewforSales
            // 
            this.dataGridViewforSales.AllowUserToAddRows = false;
            this.dataGridViewforSales.AllowUserToDeleteRows = false;
            this.dataGridViewforSales.AllowUserToResizeRows = false;
            this.dataGridViewforSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewforSales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.dataGridViewforSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewforSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewforSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewforSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceno,
            this.invoicedate,
            this.customername,
            this.customercontact,
            this.customeraddress,
            this.category,
            this.products,
            this.total,
            this.discount,
            this.tax,
            this.grandtotal});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewforSales.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewforSales.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewforSales.Location = new System.Drawing.Point(-1, 2);
            this.dataGridViewforSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewforSales.MultiSelect = false;
            this.dataGridViewforSales.Name = "dataGridViewforSales";
            this.dataGridViewforSales.ReadOnly = true;
            this.dataGridViewforSales.RowHeadersVisible = false;
            this.dataGridViewforSales.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.dataGridViewforSales.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewforSales.RowTemplate.Height = 24;
            this.dataGridViewforSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewforSales.Size = new System.Drawing.Size(1607, 667);
            this.dataGridViewforSales.TabIndex = 22;
            this.dataGridViewforSales.TabStop = false;
            // 
            // invoiceno
            // 
            this.invoiceno.DataPropertyName = "invoiceno";
            this.invoiceno.HeaderText = "INVOICE NO.";
            this.invoiceno.MinimumWidth = 6;
            this.invoiceno.Name = "invoiceno";
            this.invoiceno.ReadOnly = true;
            // 
            // invoicedate
            // 
            this.invoicedate.DataPropertyName = "invoicedate";
            this.invoicedate.HeaderText = "INVOICE DATE";
            this.invoicedate.MinimumWidth = 6;
            this.invoicedate.Name = "invoicedate";
            this.invoicedate.ReadOnly = true;
            // 
            // customername
            // 
            this.customername.DataPropertyName = "CustomerName";
            this.customername.HeaderText = "CUSTOMER NAME";
            this.customername.MinimumWidth = 6;
            this.customername.Name = "customername";
            this.customername.ReadOnly = true;
            // 
            // customercontact
            // 
            this.customercontact.DataPropertyName = "CustomerContact";
            this.customercontact.HeaderText = "CUSTOMER MO.";
            this.customercontact.MinimumWidth = 6;
            this.customercontact.Name = "customercontact";
            this.customercontact.ReadOnly = true;
            // 
            // customeraddress
            // 
            this.customeraddress.DataPropertyName = "CustomerAddress";
            this.customeraddress.HeaderText = "ADDRESS";
            this.customeraddress.MinimumWidth = 6;
            this.customeraddress.Name = "customeraddress";
            this.customeraddress.ReadOnly = true;
            // 
            // category
            // 
            this.category.DataPropertyName = "CategoryList";
            this.category.HeaderText = "CATEGORY";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // products
            // 
            this.products.DataPropertyName = "PurchasedProducts";
            this.products.HeaderText = "PRODUCTS";
            this.products.MinimumWidth = 6;
            this.products.Name = "products";
            this.products.ReadOnly = true;
            // 
            // total
            // 
            this.total.DataPropertyName = "totalamount";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.total.DefaultCellStyle = dataGridViewCellStyle2;
            this.total.HeaderText = "TOTAL";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // discount
            // 
            this.discount.DataPropertyName = "discount";
            this.discount.HeaderText = "DISCOUNT";
            this.discount.MinimumWidth = 6;
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            // 
            // tax
            // 
            this.tax.DataPropertyName = "tax";
            this.tax.HeaderText = "TAX";
            this.tax.MinimumWidth = 6;
            this.tax.Name = "tax";
            this.tax.ReadOnly = true;
            // 
            // grandtotal
            // 
            this.grandtotal.DataPropertyName = "grandtotal";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.grandtotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.grandtotal.HeaderText = "GRAND TOTAL";
            this.grandtotal.MinimumWidth = 6;
            this.grandtotal.Name = "grandtotal";
            this.grandtotal.ReadOnly = true;
            // 
            // page__RECORDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(1607, 926);
            this.Controls.Add(this.panelforProductFields);
            this.Controls.Add(this.panelforSearchDetails);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "page__RECORDS";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.page__RECORDS_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            this.panelforSearchDetails.ResumeLayout(false);
            this.panelforSearchDetails.PerformLayout();
            this.panelForDate.ResumeLayout(false);
            this.panelForDate.PerformLayout();
            this.panelforProductFields.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewforSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelforHeading;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.Panel panelforSearchDetails;
        private System.Windows.Forms.TextBox textBox__SearchVal;
        private System.Windows.Forms.Panel panelForDate;
        private System.Windows.Forms.Label labelForToDate;
        private System.Windows.Forms.DateTimePicker InvoiceToDateTimePicker;
        private System.Windows.Forms.Label labelForFromDate;
        private System.Windows.Forms.DateTimePicker InvoiceFromDateTimePicker;
        private System.Windows.Forms.Label labelforProductDetails;
        private System.Windows.Forms.Button button__ShoeSearch;
        private System.Windows.Forms.Label labelForSearchValue;
        private System.Windows.Forms.Label labelforCategoryName;
        private System.Windows.Forms.ComboBox comboBox__SelectSearchOption;
        private System.Windows.Forms.Panel panelforProductFields;
        private System.Windows.Forms.DataGridView dataGridViewforSales;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceno;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoicedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn customername;
        private System.Windows.Forms.DataGridViewTextBoxColumn customercontact;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeraddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn products;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn grandtotal;
    }
}