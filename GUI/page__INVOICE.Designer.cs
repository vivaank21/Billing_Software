namespace Billing_Software.GUI
{
    partial class page__INVOICE
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelforHeading = new System.Windows.Forms.Label();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.panelCustomerDetails = new System.Windows.Forms.Panel();
            this.textBox__InvoiceNO = new System.Windows.Forms.TextBox();
            this.labelColon4 = new System.Windows.Forms.Label();
            this.labelforInvoiceNo = new System.Windows.Forms.Label();
            this.labelColon5 = new System.Windows.Forms.Label();
            this.InvoicedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelforInvoiceDate = new System.Windows.Forms.Label();
            this.textBox__CustomerAddress = new System.Windows.Forms.TextBox();
            this.labelColon3 = new System.Windows.Forms.Label();
            this.labelforCustomerAddress = new System.Windows.Forms.Label();
            this.textBox__CustomerContact = new System.Windows.Forms.TextBox();
            this.labelColon2 = new System.Windows.Forms.Label();
            this.labelforCustomerContact = new System.Windows.Forms.Label();
            this.textBox__CustomerName = new System.Windows.Forms.TextBox();
            this.labelColon1 = new System.Windows.Forms.Label();
            this.labelforCustomerName = new System.Windows.Forms.Label();
            this.labelforCustomerDeatils = new System.Windows.Forms.Label();
            this.panelforProductDetails = new System.Windows.Forms.Panel();
            this.textBox__SaleStock = new System.Windows.Forms.TextBox();
            this.labelColon16 = new System.Windows.Forms.Label();
            this.labelforPurchasedStock = new System.Windows.Forms.Label();
            this.comboBox__SelectProductSize = new System.Windows.Forms.ComboBox();
            this.comboBox__SelectProduct = new System.Windows.Forms.ComboBox();
            this.comboBox__SelectCategory = new System.Windows.Forms.ComboBox();
            this.button__ClearProducts = new System.Windows.Forms.Button();
            this.textBox__ShowAvailableStock = new System.Windows.Forms.TextBox();
            this.button__AddProducts = new System.Windows.Forms.Button();
            this.labelColon10 = new System.Windows.Forms.Label();
            this.labelforProductStock = new System.Windows.Forms.Label();
            this.textBox__ShowProductDescription = new System.Windows.Forms.TextBox();
            this.textBox__ShowProductRate = new System.Windows.Forms.TextBox();
            this.labelforProductDescription = new System.Windows.Forms.Label();
            this.labelColon9 = new System.Windows.Forms.Label();
            this.labelColon11 = new System.Windows.Forms.Label();
            this.labelforProductRate = new System.Windows.Forms.Label();
            this.labelColon8 = new System.Windows.Forms.Label();
            this.labelforProductSize = new System.Windows.Forms.Label();
            this.labelColon7 = new System.Windows.Forms.Label();
            this.labelforProductName = new System.Windows.Forms.Label();
            this.labelColon6 = new System.Windows.Forms.Label();
            this.labelforCategory = new System.Windows.Forms.Label();
            this.labelforProductDetails = new System.Windows.Forms.Label();
            this.panelforSalesDeatails = new System.Windows.Forms.Panel();
            this.button__SaveInvoice = new System.Windows.Forms.Button();
            this.button__PrintInvoice = new System.Windows.Forms.Button();
            this.textBox__ShowGrandTotal = new System.Windows.Forms.TextBox();
            this.labelColon15 = new System.Windows.Forms.Label();
            this.labelforGrandTotal = new System.Windows.Forms.Label();
            this.textBox__GSTandTAX = new System.Windows.Forms.TextBox();
            this.labelColon14 = new System.Windows.Forms.Label();
            this.labelforGSTandTAX = new System.Windows.Forms.Label();
            this.textBox__Discount = new System.Windows.Forms.TextBox();
            this.labelColon13 = new System.Windows.Forms.Label();
            this.labelforDiscount = new System.Windows.Forms.Label();
            this.textBox__ShowSubTotal = new System.Windows.Forms.TextBox();
            this.labelforSalesDetails = new System.Windows.Forms.Label();
            this.labelColon12 = new System.Windows.Forms.Label();
            this.labelforSubTotal = new System.Windows.Forms.Label();
            this.dataGridViewforPRODUCTS = new System.Windows.Forms.DataGridView();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            this.panelCustomerDetails.SuspendLayout();
            this.panelforProductDetails.SuspendLayout();
            this.panelforSalesDeatails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewforPRODUCTS)).BeginInit();
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
            this.panelHeader.Size = new System.Drawing.Size(1672, 59);
            this.panelHeader.TabIndex = 1;
            // 
            // labelforHeading
            // 
            this.labelforHeading.AutoSize = true;
            this.labelforHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelforHeading.Font = new System.Drawing.Font("Baskerville Old Face", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelforHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.labelforHeading.Location = new System.Drawing.Point(565, 5);
            this.labelforHeading.Name = "labelforHeading";
            this.labelforHeading.Size = new System.Drawing.Size(466, 53);
            this.labelforHeading.TabIndex = 1;
            this.labelforHeading.Text = "INVOICE OF SALES";
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.Image = global::Billing_Software.Properties.Resources.closeIcon;
            this.pictureBox_close.Location = new System.Drawing.Point(1613, 6);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(47, 48);
            this.pictureBox_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_close.TabIndex = 2;
            this.pictureBox_close.TabStop = false;
            this.pictureBox_close.Click += new System.EventHandler(this.pictureBox_close_Click);
            // 
            // panelCustomerDetails
            // 
            this.panelCustomerDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCustomerDetails.Controls.Add(this.textBox__InvoiceNO);
            this.panelCustomerDetails.Controls.Add(this.labelColon4);
            this.panelCustomerDetails.Controls.Add(this.labelforInvoiceNo);
            this.panelCustomerDetails.Controls.Add(this.labelColon5);
            this.panelCustomerDetails.Controls.Add(this.InvoicedateTimePicker);
            this.panelCustomerDetails.Controls.Add(this.labelforInvoiceDate);
            this.panelCustomerDetails.Controls.Add(this.textBox__CustomerAddress);
            this.panelCustomerDetails.Controls.Add(this.labelColon3);
            this.panelCustomerDetails.Controls.Add(this.labelforCustomerAddress);
            this.panelCustomerDetails.Controls.Add(this.textBox__CustomerContact);
            this.panelCustomerDetails.Controls.Add(this.labelColon2);
            this.panelCustomerDetails.Controls.Add(this.labelforCustomerContact);
            this.panelCustomerDetails.Controls.Add(this.textBox__CustomerName);
            this.panelCustomerDetails.Controls.Add(this.labelColon1);
            this.panelCustomerDetails.Controls.Add(this.labelforCustomerName);
            this.panelCustomerDetails.Controls.Add(this.labelforCustomerDeatils);
            this.panelCustomerDetails.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCustomerDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.panelCustomerDetails.Location = new System.Drawing.Point(13, 82);
            this.panelCustomerDetails.Name = "panelCustomerDetails";
            this.panelCustomerDetails.Size = new System.Drawing.Size(1647, 150);
            this.panelCustomerDetails.TabIndex = 2;
            // 
            // textBox__InvoiceNO
            // 
            this.textBox__InvoiceNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.textBox__InvoiceNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox__InvoiceNO.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox__InvoiceNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.textBox__InvoiceNO.Location = new System.Drawing.Point(1311, 22);
            this.textBox__InvoiceNO.Name = "textBox__InvoiceNO";
            this.textBox__InvoiceNO.ReadOnly = true;
            this.textBox__InvoiceNO.Size = new System.Drawing.Size(315, 39);
            this.textBox__InvoiceNO.TabIndex = 17;
            // 
            // labelColon4
            // 
            this.labelColon4.AutoSize = true;
            this.labelColon4.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColon4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelColon4.Location = new System.Drawing.Point(1282, 25);
            this.labelColon4.Name = "labelColon4";
            this.labelColon4.Size = new System.Drawing.Size(22, 32);
            this.labelColon4.TabIndex = 16;
            this.labelColon4.Text = ":";
            // 
            // labelforInvoiceNo
            // 
            this.labelforInvoiceNo.AutoSize = true;
            this.labelforInvoiceNo.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelforInvoiceNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelforInvoiceNo.Location = new System.Drawing.Point(1090, 30);
            this.labelforInvoiceNo.Name = "labelforInvoiceNo";
            this.labelforInvoiceNo.Size = new System.Drawing.Size(168, 26);
            this.labelforInvoiceNo.TabIndex = 15;
            this.labelforInvoiceNo.Text = "INVOICE NO.";
            // 
            // labelColon5
            // 
            this.labelColon5.AutoSize = true;
            this.labelColon5.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColon5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelColon5.Location = new System.Drawing.Point(1282, 101);
            this.labelColon5.Name = "labelColon5";
            this.labelColon5.Size = new System.Drawing.Size(22, 32);
            this.labelColon5.TabIndex = 14;
            this.labelColon5.Text = ":";
            // 
            // InvoicedateTimePicker
            // 
            this.InvoicedateTimePicker.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoicedateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.InvoicedateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.InvoicedateTimePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.InvoicedateTimePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.InvoicedateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.InvoicedateTimePicker.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoicedateTimePicker.Location = new System.Drawing.Point(1311, 98);
            this.InvoicedateTimePicker.Name = "InvoicedateTimePicker";
            this.InvoicedateTimePicker.Size = new System.Drawing.Size(315, 39);
            this.InvoicedateTimePicker.TabIndex = 13;
            // 
            // labelforInvoiceDate
            // 
            this.labelforInvoiceDate.AutoSize = true;
            this.labelforInvoiceDate.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelforInvoiceDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelforInvoiceDate.Location = new System.Drawing.Point(1090, 106);
            this.labelforInvoiceDate.Name = "labelforInvoiceDate";
            this.labelforInvoiceDate.Size = new System.Drawing.Size(191, 26);
            this.labelforInvoiceDate.TabIndex = 12;
            this.labelforInvoiceDate.Text = "INVOICE DATE";
            // 
            // textBox__CustomerAddress
            // 
            this.textBox__CustomerAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.textBox__CustomerAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox__CustomerAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox__CustomerAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.textBox__CustomerAddress.Location = new System.Drawing.Point(689, 63);
            this.textBox__CustomerAddress.Multiline = true;
            this.textBox__CustomerAddress.Name = "textBox__CustomerAddress";
            this.textBox__CustomerAddress.Size = new System.Drawing.Size(369, 74);
            this.textBox__CustomerAddress.TabIndex = 9;
            // 
            // labelColon3
            // 
            this.labelColon3.AutoSize = true;
            this.labelColon3.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColon3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelColon3.Location = new System.Drawing.Point(1013, 19);
            this.labelColon3.Name = "labelColon3";
            this.labelColon3.Size = new System.Drawing.Size(22, 32);
            this.labelColon3.TabIndex = 11;
            this.labelColon3.Text = ":";
            // 
            // labelforCustomerAddress
            // 
            this.labelforCustomerAddress.AutoSize = true;
            this.labelforCustomerAddress.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelforCustomerAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelforCustomerAddress.Location = new System.Drawing.Point(742, 24);
            this.labelforCustomerAddress.Name = "labelforCustomerAddress";
            this.labelforCustomerAddress.Size = new System.Drawing.Size(268, 26);
            this.labelforCustomerAddress.TabIndex = 10;
            this.labelforCustomerAddress.Text = "CUSTOMER ADDRESS";
            // 
            // textBox__CustomerContact
            // 
            this.textBox__CustomerContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.textBox__CustomerContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox__CustomerContact.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox__CustomerContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.textBox__CustomerContact.Location = new System.Drawing.Point(258, 98);
            this.textBox__CustomerContact.MaxLength = 10;
            this.textBox__CustomerContact.Name = "textBox__CustomerContact";
            this.textBox__CustomerContact.Size = new System.Drawing.Size(378, 39);
            this.textBox__CustomerContact.TabIndex = 6;
            this.textBox__CustomerContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox__CustomerContact_KeyPress);
            // 
            // labelColon2
            // 
            this.labelColon2.AutoSize = true;
            this.labelColon2.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColon2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelColon2.Location = new System.Drawing.Point(229, 104);
            this.labelColon2.Name = "labelColon2";
            this.labelColon2.Size = new System.Drawing.Size(22, 32);
            this.labelColon2.TabIndex = 8;
            this.labelColon2.Text = ":";
            // 
            // labelforCustomerContact
            // 
            this.labelforCustomerContact.AutoSize = true;
            this.labelforCustomerContact.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelforCustomerContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelforCustomerContact.Location = new System.Drawing.Point(3, 108);
            this.labelforCustomerContact.Name = "labelforCustomerContact";
            this.labelforCustomerContact.Size = new System.Drawing.Size(205, 26);
            this.labelforCustomerContact.TabIndex = 7;
            this.labelforCustomerContact.Text = "CUSTOMER MO.";
            // 
            // textBox__CustomerName
            // 
            this.textBox__CustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.textBox__CustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox__CustomerName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox__CustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.textBox__CustomerName.Location = new System.Drawing.Point(258, 33);
            this.textBox__CustomerName.Name = "textBox__CustomerName";
            this.textBox__CustomerName.Size = new System.Drawing.Size(378, 39);
            this.textBox__CustomerName.TabIndex = 3;
            // 
            // labelColon1
            // 
            this.labelColon1.AutoSize = true;
            this.labelColon1.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColon1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelColon1.Location = new System.Drawing.Point(229, 35);
            this.labelColon1.Name = "labelColon1";
            this.labelColon1.Size = new System.Drawing.Size(22, 32);
            this.labelColon1.TabIndex = 5;
            this.labelColon1.Text = ":";
            // 
            // labelforCustomerName
            // 
            this.labelforCustomerName.AutoSize = true;
            this.labelforCustomerName.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelforCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelforCustomerName.Location = new System.Drawing.Point(2, 39);
            this.labelforCustomerName.Name = "labelforCustomerName";
            this.labelforCustomerName.Size = new System.Drawing.Size(228, 26);
            this.labelforCustomerName.TabIndex = 4;
            this.labelforCustomerName.Text = "CUSTOMER NAME";
            // 
            // labelforCustomerDeatils
            // 
            this.labelforCustomerDeatils.AutoSize = true;
            this.labelforCustomerDeatils.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelforCustomerDeatils.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelforCustomerDeatils.Location = new System.Drawing.Point(3, 0);
            this.labelforCustomerDeatils.Name = "labelforCustomerDeatils";
            this.labelforCustomerDeatils.Size = new System.Drawing.Size(143, 15);
            this.labelforCustomerDeatils.TabIndex = 3;
            this.labelforCustomerDeatils.Text = "CUSTOMER DETAILS";
            // 
            // panelforProductDetails
            // 
            this.panelforProductDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelforProductDetails.Controls.Add(this.textBox__SaleStock);
            this.panelforProductDetails.Controls.Add(this.labelColon16);
            this.panelforProductDetails.Controls.Add(this.labelforPurchasedStock);
            this.panelforProductDetails.Controls.Add(this.comboBox__SelectProductSize);
            this.panelforProductDetails.Controls.Add(this.comboBox__SelectProduct);
            this.panelforProductDetails.Controls.Add(this.comboBox__SelectCategory);
            this.panelforProductDetails.Controls.Add(this.button__ClearProducts);
            this.panelforProductDetails.Controls.Add(this.textBox__ShowAvailableStock);
            this.panelforProductDetails.Controls.Add(this.button__AddProducts);
            this.panelforProductDetails.Controls.Add(this.labelColon10);
            this.panelforProductDetails.Controls.Add(this.labelforProductStock);
            this.panelforProductDetails.Controls.Add(this.textBox__ShowProductDescription);
            this.panelforProductDetails.Controls.Add(this.textBox__ShowProductRate);
            this.panelforProductDetails.Controls.Add(this.labelforProductDescription);
            this.panelforProductDetails.Controls.Add(this.labelColon9);
            this.panelforProductDetails.Controls.Add(this.labelColon11);
            this.panelforProductDetails.Controls.Add(this.labelforProductRate);
            this.panelforProductDetails.Controls.Add(this.labelColon8);
            this.panelforProductDetails.Controls.Add(this.labelforProductSize);
            this.panelforProductDetails.Controls.Add(this.labelColon7);
            this.panelforProductDetails.Controls.Add(this.labelforProductName);
            this.panelforProductDetails.Controls.Add(this.labelColon6);
            this.panelforProductDetails.Controls.Add(this.labelforCategory);
            this.panelforProductDetails.Controls.Add(this.labelforProductDetails);
            this.panelforProductDetails.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelforProductDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.panelforProductDetails.Location = new System.Drawing.Point(13, 266);
            this.panelforProductDetails.Name = "panelforProductDetails";
            this.panelforProductDetails.Size = new System.Drawing.Size(1647, 237);
            this.panelforProductDetails.TabIndex = 18;
            // 
            // textBox__SaleStock
            // 
            this.textBox__SaleStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.textBox__SaleStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox__SaleStock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox__SaleStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.textBox__SaleStock.Location = new System.Drawing.Point(954, 84);
            this.textBox__SaleStock.Name = "textBox__SaleStock";
            this.textBox__SaleStock.Size = new System.Drawing.Size(315, 39);
            this.textBox__SaleStock.TabIndex = 29;
            this.textBox__SaleStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox__SaleStock_KeyPress);
            // 
            // labelColon16
            // 
            this.labelColon16.AutoSize = true;
            this.labelColon16.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColon16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelColon16.Location = new System.Drawing.Point(925, 85);
            this.labelColon16.Name = "labelColon16";
            this.labelColon16.Size = new System.Drawing.Size(22, 32);
            this.labelColon16.TabIndex = 28;
            this.labelColon16.Text = ":";
            // 
            // labelforPurchasedStock
            // 
            this.labelforPurchasedStock.AutoSize = true;
            this.labelforPurchasedStock.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelforPurchasedStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelforPurchasedStock.Location = new System.Drawing.Point(654, 92);
            this.labelforPurchasedStock.Name = "labelforPurchasedStock";
            this.labelforPurchasedStock.Size = new System.Drawing.Size(250, 26);
            this.labelforPurchasedStock.TabIndex = 27;
            this.labelforPurchasedStock.Text = "PURCHASED STOCK";
            // 
            // comboBox__SelectProductSize
            // 
            this.comboBox__SelectProductSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.comboBox__SelectProductSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox__SelectProductSize.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox__SelectProductSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.comboBox__SelectProductSize.FormattingEnabled = true;
            this.comboBox__SelectProductSize.Location = new System.Drawing.Point(258, 134);
            this.comboBox__SelectProductSize.Name = "comboBox__SelectProductSize";
            this.comboBox__SelectProductSize.Size = new System.Drawing.Size(378, 42);
            this.comboBox__SelectProductSize.TabIndex = 26;
            this.comboBox__SelectProductSize.SelectedIndexChanged += new System.EventHandler(this.comboBox__SelectProductSize_SelectedIndexChanged);
            // 
            // comboBox__SelectProduct
            // 
            this.comboBox__SelectProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.comboBox__SelectProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox__SelectProduct.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox__SelectProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.comboBox__SelectProduct.FormattingEnabled = true;
            this.comboBox__SelectProduct.Location = new System.Drawing.Point(258, 71);
            this.comboBox__SelectProduct.Name = "comboBox__SelectProduct";
            this.comboBox__SelectProduct.Size = new System.Drawing.Size(378, 42);
            this.comboBox__SelectProduct.TabIndex = 25;
            this.comboBox__SelectProduct.SelectedIndexChanged += new System.EventHandler(this.comboBox__SelectProduct_SelectedIndexChanged);
            // 
            // comboBox__SelectCategory
            // 
            this.comboBox__SelectCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.comboBox__SelectCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox__SelectCategory.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox__SelectCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.comboBox__SelectCategory.FormattingEnabled = true;
            this.comboBox__SelectCategory.Location = new System.Drawing.Point(258, 8);
            this.comboBox__SelectCategory.Name = "comboBox__SelectCategory";
            this.comboBox__SelectCategory.Size = new System.Drawing.Size(378, 42);
            this.comboBox__SelectCategory.TabIndex = 24;
            this.comboBox__SelectCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox__SelectCategory_SelectedIndexChanged);
            // 
            // button__ClearProducts
            // 
            this.button__ClearProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.button__ClearProducts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.button__ClearProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button__ClearProducts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.button__ClearProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.button__ClearProducts.Location = new System.Drawing.Point(1319, 136);
            this.button__ClearProducts.Name = "button__ClearProducts";
            this.button__ClearProducts.Size = new System.Drawing.Size(307, 91);
            this.button__ClearProducts.TabIndex = 20;
            this.button__ClearProducts.Text = "CLEAR";
            this.button__ClearProducts.UseVisualStyleBackColor = false;
            this.button__ClearProducts.Click += new System.EventHandler(this.button__ClearProducts_Click);
            // 
            // textBox__ShowAvailableStock
            // 
            this.textBox__ShowAvailableStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.textBox__ShowAvailableStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox__ShowAvailableStock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox__ShowAvailableStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.textBox__ShowAvailableStock.Location = new System.Drawing.Point(954, 21);
            this.textBox__ShowAvailableStock.Name = "textBox__ShowAvailableStock";
            this.textBox__ShowAvailableStock.ReadOnly = true;
            this.textBox__ShowAvailableStock.Size = new System.Drawing.Size(315, 39);
            this.textBox__ShowAvailableStock.TabIndex = 23;
            // 
            // button__AddProducts
            // 
            this.button__AddProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.button__AddProducts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.button__AddProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button__AddProducts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.button__AddProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.button__AddProducts.Location = new System.Drawing.Point(1319, 26);
            this.button__AddProducts.Name = "button__AddProducts";
            this.button__AddProducts.Size = new System.Drawing.Size(307, 91);
            this.button__AddProducts.TabIndex = 21;
            this.button__AddProducts.Text = "START INVOICE";
            this.button__AddProducts.UseVisualStyleBackColor = false;
            this.button__AddProducts.Click += new System.EventHandler(this.button__AddProducts_Click);
            // 
            // labelColon10
            // 
            this.labelColon10.AutoSize = true;
            this.labelColon10.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColon10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelColon10.Location = new System.Drawing.Point(925, 22);
            this.labelColon10.Name = "labelColon10";
            this.labelColon10.Size = new System.Drawing.Size(22, 32);
            this.labelColon10.TabIndex = 22;
            this.labelColon10.Text = ":";
            // 
            // labelforProductStock
            // 
            this.labelforProductStock.AutoSize = true;
            this.labelforProductStock.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelforProductStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelforProductStock.Location = new System.Drawing.Point(654, 29);
            this.labelforProductStock.Name = "labelforProductStock";
            this.labelforProductStock.Size = new System.Drawing.Size(222, 26);
            this.labelforProductStock.TabIndex = 21;
            this.labelforProductStock.Text = "PRODUCT STOCK";
            // 
            // textBox__ShowProductDescription
            // 
            this.textBox__ShowProductDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.textBox__ShowProductDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox__ShowProductDescription.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox__ShowProductDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.textBox__ShowProductDescription.Location = new System.Drawing.Point(954, 147);
            this.textBox__ShowProductDescription.Multiline = true;
            this.textBox__ShowProductDescription.Name = "textBox__ShowProductDescription";
            this.textBox__ShowProductDescription.ReadOnly = true;
            this.textBox__ShowProductDescription.Size = new System.Drawing.Size(315, 74);
            this.textBox__ShowProductDescription.TabIndex = 9;
            // 
            // textBox__ShowProductRate
            // 
            this.textBox__ShowProductRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.textBox__ShowProductRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox__ShowProductRate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox__ShowProductRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.textBox__ShowProductRate.Location = new System.Drawing.Point(258, 189);
            this.textBox__ShowProductRate.Name = "textBox__ShowProductRate";
            this.textBox__ShowProductRate.ReadOnly = true;
            this.textBox__ShowProductRate.Size = new System.Drawing.Size(378, 39);
            this.textBox__ShowProductRate.TabIndex = 20;
            // 
            // labelforProductDescription
            // 
            this.labelforProductDescription.AutoSize = true;
            this.labelforProductDescription.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelforProductDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelforProductDescription.Location = new System.Drawing.Point(654, 152);
            this.labelforProductDescription.Name = "labelforProductDescription";
            this.labelforProductDescription.Size = new System.Drawing.Size(207, 26);
            this.labelforProductDescription.TabIndex = 10;
            this.labelforProductDescription.Text = "PRODUCT INFO.";
            // 
            // labelColon9
            // 
            this.labelColon9.AutoSize = true;
            this.labelColon9.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColon9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelColon9.Location = new System.Drawing.Point(229, 191);
            this.labelColon9.Name = "labelColon9";
            this.labelColon9.Size = new System.Drawing.Size(22, 32);
            this.labelColon9.TabIndex = 19;
            this.labelColon9.Text = ":";
            // 
            // labelColon11
            // 
            this.labelColon11.AutoSize = true;
            this.labelColon11.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColon11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelColon11.Location = new System.Drawing.Point(925, 147);
            this.labelColon11.Name = "labelColon11";
            this.labelColon11.Size = new System.Drawing.Size(22, 32);
            this.labelColon11.TabIndex = 11;
            this.labelColon11.Text = ":";
            // 
            // labelforProductRate
            // 
            this.labelforProductRate.AutoSize = true;
            this.labelforProductRate.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelforProductRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelforProductRate.Location = new System.Drawing.Point(3, 194);
            this.labelforProductRate.Name = "labelforProductRate";
            this.labelforProductRate.Size = new System.Drawing.Size(204, 26);
            this.labelforProductRate.TabIndex = 18;
            this.labelforProductRate.Text = "PRODUCT RATE";
            // 
            // labelColon8
            // 
            this.labelColon8.AutoSize = true;
            this.labelColon8.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColon8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelColon8.Location = new System.Drawing.Point(229, 129);
            this.labelColon8.Name = "labelColon8";
            this.labelColon8.Size = new System.Drawing.Size(22, 32);
            this.labelColon8.TabIndex = 16;
            this.labelColon8.Text = ":";
            // 
            // labelforProductSize
            // 
            this.labelforProductSize.AutoSize = true;
            this.labelforProductSize.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelforProductSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelforProductSize.Location = new System.Drawing.Point(3, 134);
            this.labelforProductSize.Name = "labelforProductSize";
            this.labelforProductSize.Size = new System.Drawing.Size(191, 26);
            this.labelforProductSize.TabIndex = 15;
            this.labelforProductSize.Text = "PRODUCT SIZE";
            // 
            // labelColon7
            // 
            this.labelColon7.AutoSize = true;
            this.labelColon7.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColon7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelColon7.Location = new System.Drawing.Point(229, 71);
            this.labelColon7.Name = "labelColon7";
            this.labelColon7.Size = new System.Drawing.Size(22, 32);
            this.labelColon7.TabIndex = 8;
            this.labelColon7.Text = ":";
            // 
            // labelforProductName
            // 
            this.labelforProductName.AutoSize = true;
            this.labelforProductName.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelforProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelforProductName.Location = new System.Drawing.Point(3, 75);
            this.labelforProductName.Name = "labelforProductName";
            this.labelforProductName.Size = new System.Drawing.Size(211, 26);
            this.labelforProductName.TabIndex = 7;
            this.labelforProductName.Text = "PRODUCT NAME";
            // 
            // labelColon6
            // 
            this.labelColon6.AutoSize = true;
            this.labelColon6.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColon6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelColon6.Location = new System.Drawing.Point(229, 19);
            this.labelColon6.Name = "labelColon6";
            this.labelColon6.Size = new System.Drawing.Size(22, 32);
            this.labelColon6.TabIndex = 5;
            this.labelColon6.Text = ":";
            // 
            // labelforCategory
            // 
            this.labelforCategory.AutoSize = true;
            this.labelforCategory.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelforCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelforCategory.Location = new System.Drawing.Point(2, 23);
            this.labelforCategory.Name = "labelforCategory";
            this.labelforCategory.Size = new System.Drawing.Size(147, 26);
            this.labelforCategory.TabIndex = 4;
            this.labelforCategory.Text = "CATEGORY";
            // 
            // labelforProductDetails
            // 
            this.labelforProductDetails.AutoSize = true;
            this.labelforProductDetails.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelforProductDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelforProductDetails.Location = new System.Drawing.Point(3, 0);
            this.labelforProductDetails.Name = "labelforProductDetails";
            this.labelforProductDetails.Size = new System.Drawing.Size(133, 15);
            this.labelforProductDetails.TabIndex = 3;
            this.labelforProductDetails.Text = "PRODUCT DETAILS";
            // 
            // panelforSalesDeatails
            // 
            this.panelforSalesDeatails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelforSalesDeatails.Controls.Add(this.button__SaveInvoice);
            this.panelforSalesDeatails.Controls.Add(this.button__PrintInvoice);
            this.panelforSalesDeatails.Controls.Add(this.textBox__ShowGrandTotal);
            this.panelforSalesDeatails.Controls.Add(this.labelColon15);
            this.panelforSalesDeatails.Controls.Add(this.labelforGrandTotal);
            this.panelforSalesDeatails.Controls.Add(this.textBox__GSTandTAX);
            this.panelforSalesDeatails.Controls.Add(this.labelColon14);
            this.panelforSalesDeatails.Controls.Add(this.labelforGSTandTAX);
            this.panelforSalesDeatails.Controls.Add(this.textBox__Discount);
            this.panelforSalesDeatails.Controls.Add(this.labelColon13);
            this.panelforSalesDeatails.Controls.Add(this.labelforDiscount);
            this.panelforSalesDeatails.Controls.Add(this.textBox__ShowSubTotal);
            this.panelforSalesDeatails.Controls.Add(this.labelforSalesDetails);
            this.panelforSalesDeatails.Controls.Add(this.labelColon12);
            this.panelforSalesDeatails.Controls.Add(this.labelforSubTotal);
            this.panelforSalesDeatails.Location = new System.Drawing.Point(952, 519);
            this.panelforSalesDeatails.Name = "panelforSalesDeatails";
            this.panelforSalesDeatails.Size = new System.Drawing.Size(708, 385);
            this.panelforSalesDeatails.TabIndex = 20;
            // 
            // button__SaveInvoice
            // 
            this.button__SaveInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.button__SaveInvoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.button__SaveInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button__SaveInvoice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.button__SaveInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.button__SaveInvoice.Location = new System.Drawing.Point(18, 281);
            this.button__SaveInvoice.Name = "button__SaveInvoice";
            this.button__SaveInvoice.Size = new System.Drawing.Size(307, 87);
            this.button__SaveInvoice.TabIndex = 36;
            this.button__SaveInvoice.Text = "SAVE";
            this.button__SaveInvoice.UseVisualStyleBackColor = false;
            this.button__SaveInvoice.Click += new System.EventHandler(this.button__SaveInvoice_Click);
            // 
            // button__PrintInvoice
            // 
            this.button__PrintInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.button__PrintInvoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.button__PrintInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button__PrintInvoice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.button__PrintInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.button__PrintInvoice.Location = new System.Drawing.Point(380, 281);
            this.button__PrintInvoice.Name = "button__PrintInvoice";
            this.button__PrintInvoice.Size = new System.Drawing.Size(307, 87);
            this.button__PrintInvoice.TabIndex = 24;
            this.button__PrintInvoice.Text = "PRINT";
            this.button__PrintInvoice.UseVisualStyleBackColor = false;
            this.button__PrintInvoice.Click += new System.EventHandler(this.button__PrintInvoice_Click);
            // 
            // textBox__ShowGrandTotal
            // 
            this.textBox__ShowGrandTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.textBox__ShowGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox__ShowGrandTotal.Enabled = false;
            this.textBox__ShowGrandTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox__ShowGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.textBox__ShowGrandTotal.Location = new System.Drawing.Point(331, 212);
            this.textBox__ShowGrandTotal.Name = "textBox__ShowGrandTotal";
            this.textBox__ShowGrandTotal.ReadOnly = true;
            this.textBox__ShowGrandTotal.Size = new System.Drawing.Size(328, 39);
            this.textBox__ShowGrandTotal.TabIndex = 33;
            // 
            // labelColon15
            // 
            this.labelColon15.AutoSize = true;
            this.labelColon15.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColon15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelColon15.Location = new System.Drawing.Point(302, 214);
            this.labelColon15.Name = "labelColon15";
            this.labelColon15.Size = new System.Drawing.Size(22, 32);
            this.labelColon15.TabIndex = 35;
            this.labelColon15.Text = ":";
            // 
            // labelforGrandTotal
            // 
            this.labelforGrandTotal.AutoSize = true;
            this.labelforGrandTotal.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelforGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelforGrandTotal.Location = new System.Drawing.Point(75, 218);
            this.labelforGrandTotal.Name = "labelforGrandTotal";
            this.labelforGrandTotal.Size = new System.Drawing.Size(193, 26);
            this.labelforGrandTotal.TabIndex = 34;
            this.labelforGrandTotal.Text = "GRAND TOTAL";
            // 
            // textBox__GSTandTAX
            // 
            this.textBox__GSTandTAX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.textBox__GSTandTAX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox__GSTandTAX.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox__GSTandTAX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.textBox__GSTandTAX.Location = new System.Drawing.Point(331, 148);
            this.textBox__GSTandTAX.Name = "textBox__GSTandTAX";
            this.textBox__GSTandTAX.Size = new System.Drawing.Size(328, 39);
            this.textBox__GSTandTAX.TabIndex = 30;
            this.textBox__GSTandTAX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox__GSTandTAX_KeyPress);
            // 
            // labelColon14
            // 
            this.labelColon14.AutoSize = true;
            this.labelColon14.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColon14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelColon14.Location = new System.Drawing.Point(302, 150);
            this.labelColon14.Name = "labelColon14";
            this.labelColon14.Size = new System.Drawing.Size(22, 32);
            this.labelColon14.TabIndex = 32;
            this.labelColon14.Text = ":";
            // 
            // labelforGSTandTAX
            // 
            this.labelforGSTandTAX.AutoSize = true;
            this.labelforGSTandTAX.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelforGSTandTAX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelforGSTandTAX.Location = new System.Drawing.Point(75, 154);
            this.labelforGSTandTAX.Name = "labelforGSTandTAX";
            this.labelforGSTandTAX.Size = new System.Drawing.Size(144, 26);
            this.labelforGSTandTAX.TabIndex = 31;
            this.labelforGSTandTAX.Text = "GST TAX %";
            // 
            // textBox__Discount
            // 
            this.textBox__Discount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.textBox__Discount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox__Discount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox__Discount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.textBox__Discount.Location = new System.Drawing.Point(331, 83);
            this.textBox__Discount.Name = "textBox__Discount";
            this.textBox__Discount.Size = new System.Drawing.Size(328, 39);
            this.textBox__Discount.TabIndex = 27;
            this.textBox__Discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox__Discount_KeyPress);
            // 
            // labelColon13
            // 
            this.labelColon13.AutoSize = true;
            this.labelColon13.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColon13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelColon13.Location = new System.Drawing.Point(302, 85);
            this.labelColon13.Name = "labelColon13";
            this.labelColon13.Size = new System.Drawing.Size(22, 32);
            this.labelColon13.TabIndex = 29;
            this.labelColon13.Text = ":";
            // 
            // labelforDiscount
            // 
            this.labelforDiscount.AutoSize = true;
            this.labelforDiscount.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelforDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelforDiscount.Location = new System.Drawing.Point(75, 89);
            this.labelforDiscount.Name = "labelforDiscount";
            this.labelforDiscount.Size = new System.Drawing.Size(167, 26);
            this.labelforDiscount.TabIndex = 28;
            this.labelforDiscount.Text = "DISCOUNT %";
            // 
            // textBox__ShowSubTotal
            // 
            this.textBox__ShowSubTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.textBox__ShowSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox__ShowSubTotal.Enabled = false;
            this.textBox__ShowSubTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox__ShowSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.textBox__ShowSubTotal.Location = new System.Drawing.Point(331, 19);
            this.textBox__ShowSubTotal.Name = "textBox__ShowSubTotal";
            this.textBox__ShowSubTotal.ReadOnly = true;
            this.textBox__ShowSubTotal.Size = new System.Drawing.Size(328, 39);
            this.textBox__ShowSubTotal.TabIndex = 24;
            // 
            // labelforSalesDetails
            // 
            this.labelforSalesDetails.AutoSize = true;
            this.labelforSalesDetails.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelforSalesDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelforSalesDetails.Location = new System.Drawing.Point(3, 3);
            this.labelforSalesDetails.Name = "labelforSalesDetails";
            this.labelforSalesDetails.Size = new System.Drawing.Size(111, 15);
            this.labelforSalesDetails.TabIndex = 24;
            this.labelforSalesDetails.Text = "SALES DETAILS";
            // 
            // labelColon12
            // 
            this.labelColon12.AutoSize = true;
            this.labelColon12.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColon12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelColon12.Location = new System.Drawing.Point(302, 21);
            this.labelColon12.Name = "labelColon12";
            this.labelColon12.Size = new System.Drawing.Size(22, 32);
            this.labelColon12.TabIndex = 26;
            this.labelColon12.Text = ":";
            // 
            // labelforSubTotal
            // 
            this.labelforSubTotal.AutoSize = true;
            this.labelforSubTotal.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelforSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.labelforSubTotal.Location = new System.Drawing.Point(75, 25);
            this.labelforSubTotal.Name = "labelforSubTotal";
            this.labelforSubTotal.Size = new System.Drawing.Size(152, 26);
            this.labelforSubTotal.TabIndex = 25;
            this.labelforSubTotal.Text = "SUB TOTAL";
            // 
            // dataGridViewforPRODUCTS
            // 
            this.dataGridViewforPRODUCTS.AllowUserToAddRows = false;
            this.dataGridViewforPRODUCTS.AllowUserToDeleteRows = false;
            this.dataGridViewforPRODUCTS.AllowUserToResizeColumns = false;
            this.dataGridViewforPRODUCTS.AllowUserToResizeRows = false;
            this.dataGridViewforPRODUCTS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewforPRODUCTS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.dataGridViewforPRODUCTS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewforPRODUCTS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewforPRODUCTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewforPRODUCTS.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewforPRODUCTS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.dataGridViewforPRODUCTS.Location = new System.Drawing.Point(13, 519);
            this.dataGridViewforPRODUCTS.Name = "dataGridViewforPRODUCTS";
            this.dataGridViewforPRODUCTS.ReadOnly = true;
            this.dataGridViewforPRODUCTS.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.dataGridViewforPRODUCTS.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewforPRODUCTS.RowTemplate.Height = 24;
            this.dataGridViewforPRODUCTS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewforPRODUCTS.Size = new System.Drawing.Size(933, 385);
            this.dataGridViewforPRODUCTS.TabIndex = 36;
            this.dataGridViewforPRODUCTS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewforPRODUCTS_CellClick);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // page__INVOICE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(1672, 916);
            this.Controls.Add(this.dataGridViewforPRODUCTS);
            this.Controls.Add(this.panelforSalesDeatails);
            this.Controls.Add(this.panelforProductDetails);
            this.Controls.Add(this.panelCustomerDetails);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "page__INVOICE";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "page__INVOICE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.page__INVOICE_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            this.panelCustomerDetails.ResumeLayout(false);
            this.panelCustomerDetails.PerformLayout();
            this.panelforProductDetails.ResumeLayout(false);
            this.panelforProductDetails.PerformLayout();
            this.panelforSalesDeatails.ResumeLayout(false);
            this.panelforSalesDeatails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewforPRODUCTS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelforHeading;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.Panel panelCustomerDetails;
        private System.Windows.Forms.Label labelforCustomerDeatils;
        private System.Windows.Forms.Label labelforCustomerName;
        private System.Windows.Forms.Label labelColon1;
        private System.Windows.Forms.TextBox textBox__CustomerName;
        private System.Windows.Forms.TextBox textBox__CustomerContact;
        private System.Windows.Forms.Label labelColon2;
        private System.Windows.Forms.Label labelforCustomerContact;
        private System.Windows.Forms.TextBox textBox__CustomerAddress;
        private System.Windows.Forms.Label labelColon3;
        private System.Windows.Forms.Label labelforCustomerAddress;
        private System.Windows.Forms.Label labelforInvoiceDate;
        private System.Windows.Forms.Label labelColon5;
        private System.Windows.Forms.DateTimePicker InvoicedateTimePicker;
        private System.Windows.Forms.Label labelColon4;
        private System.Windows.Forms.Label labelforInvoiceNo;
        private System.Windows.Forms.TextBox textBox__InvoiceNO;
        private System.Windows.Forms.Panel panelforProductDetails;
        private System.Windows.Forms.Label labelColon8;
        private System.Windows.Forms.Label labelforProductSize;
        private System.Windows.Forms.TextBox textBox__ShowProductDescription;
        private System.Windows.Forms.Label labelColon11;
        private System.Windows.Forms.Label labelforProductDescription;
        private System.Windows.Forms.Label labelColon7;
        private System.Windows.Forms.Label labelforProductName;
        private System.Windows.Forms.Label labelColon6;
        private System.Windows.Forms.Label labelforCategory;
        private System.Windows.Forms.Label labelforProductDetails;
        private System.Windows.Forms.TextBox textBox__ShowProductRate;
        private System.Windows.Forms.Label labelColon9;
        private System.Windows.Forms.Label labelforProductRate;
        private System.Windows.Forms.TextBox textBox__ShowAvailableStock;
        private System.Windows.Forms.Label labelColon10;
        private System.Windows.Forms.Label labelforProductStock;
        private System.Windows.Forms.Button button__ClearProducts;
        private System.Windows.Forms.Button button__AddProducts;
        private System.Windows.Forms.Panel panelforSalesDeatails;
        private System.Windows.Forms.Label labelforSalesDetails;
        private System.Windows.Forms.TextBox textBox__ShowGrandTotal;
        private System.Windows.Forms.Label labelColon15;
        private System.Windows.Forms.Label labelforGrandTotal;
        private System.Windows.Forms.TextBox textBox__GSTandTAX;
        private System.Windows.Forms.Label labelColon14;
        private System.Windows.Forms.Label labelforGSTandTAX;
        private System.Windows.Forms.TextBox textBox__Discount;
        private System.Windows.Forms.Label labelColon13;
        private System.Windows.Forms.Label labelforDiscount;
        private System.Windows.Forms.TextBox textBox__ShowSubTotal;
        private System.Windows.Forms.Label labelColon12;
        private System.Windows.Forms.Label labelforSubTotal;
        private System.Windows.Forms.Button button__PrintInvoice;
        private System.Windows.Forms.DataGridView dataGridViewforPRODUCTS;
        private System.Windows.Forms.ComboBox comboBox__SelectCategory;
        private System.Windows.Forms.ComboBox comboBox__SelectProductSize;
        private System.Windows.Forms.ComboBox comboBox__SelectProduct;
        private System.Windows.Forms.TextBox textBox__SaleStock;
        private System.Windows.Forms.Label labelColon16;
        private System.Windows.Forms.Label labelforPurchasedStock;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button__SaveInvoice;
    }
}