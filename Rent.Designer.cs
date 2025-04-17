namespace Lumani_Rental_Store
{
    partial class Rent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rent));
            this.cboAName = new System.Windows.Forms.ComboBox();
            this.appliancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rental = new Lumani_Rental_Store.Rental();
            this.gpRentData = new System.Windows.Forms.GroupBox();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txttotalamount = new System.Windows.Forms.TextBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblMonthlyFees = new System.Windows.Forms.Label();
            this.txtfees = new System.Windows.Forms.TextBox();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.txtRentID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAID = new System.Windows.Forms.Label();
            this.gpCustomer = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAName = new System.Windows.Forms.Label();
            this.categoryTableAdapter = new Lumani_Rental_Store.RentalTableAdapters.CategoryTableAdapter();
            this.appliancesTableAdapter = new Lumani_Rental_Store.RentalTableAdapters.AppliancesTableAdapter();
            this.gpAppliance = new System.Windows.Forms.GroupBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.lblBrandID = new System.Windows.Forms.Label();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.txtBrandID = new System.Windows.Forms.TextBox();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.txtCaID = new System.Windows.Forms.TextBox();
            this.txtAID = new System.Windows.Forms.TextBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvview = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnReview = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRent = new System.Windows.Forms.Button();
            this.lbltotalduration = new System.Windows.Forms.Label();
            this.lblfinalamount = new System.Windows.Forms.Label();
            this.btnCart = new System.Windows.Forms.Button();
            this.lblTopic = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.appliancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rental)).BeginInit();
            this.gpRentData.SuspendLayout();
            this.gpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpAppliance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvview)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboAName
            // 
            this.cboAName.DataSource = this.appliancesBindingSource;
            this.cboAName.DisplayMember = "ApplianeName";
            this.cboAName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.cboAName.FormattingEnabled = true;
            this.cboAName.Location = new System.Drawing.Point(233, 111);
            this.cboAName.Name = "cboAName";
            this.cboAName.Size = new System.Drawing.Size(176, 33);
            this.cboAName.TabIndex = 0;
            this.cboAName.ValueMember = "ApplianeName";
            this.cboAName.SelectedIndexChanged += new System.EventHandler(this.cboAName_SelectedIndexChanged);
            // 
            // appliancesBindingSource
            // 
            this.appliancesBindingSource.DataMember = "Appliances";
            this.appliancesBindingSource.DataSource = this.rental;
            // 
            // rental
            // 
            this.rental.DataSetName = "Rental";
            this.rental.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gpRentData
            // 
            this.gpRentData.BackColor = System.Drawing.Color.Transparent;
            this.gpRentData.Controls.Add(this.datetime);
            this.gpRentData.Controls.Add(this.lblTotal);
            this.gpRentData.Controls.Add(this.txttotalamount);
            this.gpRentData.Controls.Add(this.lblMonth);
            this.gpRentData.Controls.Add(this.lblMonthlyFees);
            this.gpRentData.Controls.Add(this.txtfees);
            this.gpRentData.Controls.Add(this.txtmonth);
            this.gpRentData.Controls.Add(this.txtRentID);
            this.gpRentData.Controls.Add(this.label5);
            this.gpRentData.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.gpRentData.Location = new System.Drawing.Point(864, 136);
            this.gpRentData.Name = "gpRentData";
            this.gpRentData.Size = new System.Drawing.Size(432, 423);
            this.gpRentData.TabIndex = 30;
            this.gpRentData.TabStop = false;
            this.gpRentData.Text = "Rent Info";
            // 
            // datetime
            // 
            this.datetime.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.datetime.Location = new System.Drawing.Point(18, 370);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(394, 33);
            this.datetime.TabIndex = 10;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(51, 288);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(147, 25);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total Amount";
            // 
            // txttotalamount
            // 
            this.txttotalamount.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txttotalamount.Location = new System.Drawing.Point(218, 288);
            this.txttotalamount.Name = "txttotalamount";
            this.txttotalamount.ReadOnly = true;
            this.txttotalamount.Size = new System.Drawing.Size(182, 33);
            this.txttotalamount.TabIndex = 8;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMonth.Location = new System.Drawing.Point(51, 219);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(129, 25);
            this.lblMonth.TabIndex = 7;
            this.lblMonth.Text = "Rent Month";
            // 
            // lblMonthlyFees
            // 
            this.lblMonthlyFees.AutoSize = true;
            this.lblMonthlyFees.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMonthlyFees.Location = new System.Drawing.Point(51, 151);
            this.lblMonthlyFees.Name = "lblMonthlyFees";
            this.lblMonthlyFees.Size = new System.Drawing.Size(138, 25);
            this.lblMonthlyFees.TabIndex = 6;
            this.lblMonthlyFees.Text = "MonthlyFees";
            // 
            // txtfees
            // 
            this.txtfees.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtfees.Location = new System.Drawing.Point(218, 148);
            this.txtfees.Name = "txtfees";
            this.txtfees.Size = new System.Drawing.Size(182, 33);
            this.txtfees.TabIndex = 5;
            // 
            // txtmonth
            // 
            this.txtmonth.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtmonth.Location = new System.Drawing.Point(218, 216);
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(182, 33);
            this.txtmonth.TabIndex = 4;
            this.txtmonth.TextChanged += new System.EventHandler(this.txtmonth_TextChanged);
            // 
            // txtRentID
            // 
            this.txtRentID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtRentID.Location = new System.Drawing.Point(218, 83);
            this.txtRentID.Name = "txtRentID";
            this.txtRentID.ReadOnly = true;
            this.txtRentID.Size = new System.Drawing.Size(182, 33);
            this.txtRentID.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(51, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "RentID";
            // 
            // lblAID
            // 
            this.lblAID.AutoSize = true;
            this.lblAID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAID.Location = new System.Drawing.Point(14, 54);
            this.lblAID.Name = "lblAID";
            this.lblAID.Size = new System.Drawing.Size(130, 25);
            this.lblAID.TabIndex = 2;
            this.lblAID.Text = "ApplianceID";
            // 
            // gpCustomer
            // 
            this.gpCustomer.BackColor = System.Drawing.Color.Transparent;
            this.gpCustomer.Controls.Add(this.label2);
            this.gpCustomer.Controls.Add(this.label1);
            this.gpCustomer.Controls.Add(this.txtCName);
            this.gpCustomer.Controls.Add(this.txtCID);
            this.gpCustomer.Controls.Add(this.pictureBox1);
            this.gpCustomer.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpCustomer.Location = new System.Drawing.Point(0, 136);
            this.gpCustomer.Name = "gpCustomer";
            this.gpCustomer.Size = new System.Drawing.Size(431, 423);
            this.gpCustomer.TabIndex = 28;
            this.gpCustomer.TabStop = false;
            this.gpCustomer.Text = "Customer Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "CustomerID";
            // 
            // txtCName
            // 
            this.txtCName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtCName.Location = new System.Drawing.Point(183, 343);
            this.txtCName.Name = "txtCName";
            this.txtCName.ReadOnly = true;
            this.txtCName.Size = new System.Drawing.Size(237, 33);
            this.txtCName.TabIndex = 2;
            // 
            // txtCID
            // 
            this.txtCID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtCID.Location = new System.Drawing.Point(183, 259);
            this.txtCID.Name = "txtCID";
            this.txtCID.ReadOnly = true;
            this.txtCID.Size = new System.Drawing.Size(237, 33);
            this.txtCID.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblAName
            // 
            this.lblAName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAName.Location = new System.Drawing.Point(12, 114);
            this.lblAName.Name = "lblAName";
            this.lblAName.Size = new System.Drawing.Size(200, 33);
            this.lblAName.TabIndex = 0;
            this.lblAName.Text = "Appliance Name\r\n";
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // appliancesTableAdapter
            // 
            this.appliancesTableAdapter.ClearBeforeFill = true;
            // 
            // gpAppliance
            // 
            this.gpAppliance.BackColor = System.Drawing.Color.Transparent;
            this.gpAppliance.Controls.Add(this.txtCategoryName);
            this.gpAppliance.Controls.Add(this.txtBrandName);
            this.gpAppliance.Controls.Add(this.lblBrandID);
            this.gpAppliance.Controls.Add(this.lblBrandName);
            this.gpAppliance.Controls.Add(this.txtBrandID);
            this.gpAppliance.Controls.Add(this.lblCategoryID);
            this.gpAppliance.Controls.Add(this.lblCategoryName);
            this.gpAppliance.Controls.Add(this.txtCaID);
            this.gpAppliance.Controls.Add(this.txtAID);
            this.gpAppliance.Controls.Add(this.lblAID);
            this.gpAppliance.Controls.Add(this.lblAName);
            this.gpAppliance.Controls.Add(this.cboAName);
            this.gpAppliance.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpAppliance.Location = new System.Drawing.Point(431, 135);
            this.gpAppliance.Name = "gpAppliance";
            this.gpAppliance.Size = new System.Drawing.Size(431, 423);
            this.gpAppliance.TabIndex = 29;
            this.gpAppliance.TabStop = false;
            this.gpAppliance.Text = "Appliance Info";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtCategoryName.Location = new System.Drawing.Point(233, 243);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.ReadOnly = true;
            this.txtCategoryName.Size = new System.Drawing.Size(176, 33);
            this.txtCategoryName.TabIndex = 13;
            // 
            // txtBrandName
            // 
            this.txtBrandName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtBrandName.Location = new System.Drawing.Point(233, 374);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.ReadOnly = true;
            this.txtBrandName.Size = new System.Drawing.Size(176, 33);
            this.txtBrandName.TabIndex = 12;
            // 
            // lblBrandID
            // 
            this.lblBrandID.AutoSize = true;
            this.lblBrandID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBrandID.Location = new System.Drawing.Point(12, 314);
            this.lblBrandID.Name = "lblBrandID";
            this.lblBrandID.Size = new System.Drawing.Size(91, 25);
            this.lblBrandID.TabIndex = 11;
            this.lblBrandID.Text = "BrandID";
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBrandName.Location = new System.Drawing.Point(12, 377);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(132, 25);
            this.lblBrandName.TabIndex = 10;
            this.lblBrandName.Text = "Brand Name";
            // 
            // txtBrandID
            // 
            this.txtBrandID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtBrandID.Location = new System.Drawing.Point(233, 311);
            this.txtBrandID.Name = "txtBrandID";
            this.txtBrandID.ReadOnly = true;
            this.txtBrandID.Size = new System.Drawing.Size(176, 33);
            this.txtBrandID.TabIndex = 9;
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategoryID.Location = new System.Drawing.Point(9, 182);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(121, 25);
            this.lblCategoryID.TabIndex = 7;
            this.lblCategoryID.Text = "CategoryID";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategoryName.Location = new System.Drawing.Point(12, 246);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(162, 25);
            this.lblCategoryName.TabIndex = 6;
            this.lblCategoryName.Text = "Category Name";
            // 
            // txtCaID
            // 
            this.txtCaID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtCaID.Location = new System.Drawing.Point(233, 179);
            this.txtCaID.Name = "txtCaID";
            this.txtCaID.ReadOnly = true;
            this.txtCaID.Size = new System.Drawing.Size(176, 33);
            this.txtCaID.TabIndex = 4;
            // 
            // txtAID
            // 
            this.txtAID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtAID.Location = new System.Drawing.Point(233, 51);
            this.txtAID.Name = "txtAID";
            this.txtAID.ReadOnly = true;
            this.txtAID.Size = new System.Drawing.Size(176, 33);
            this.txtAID.TabIndex = 3;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.rental;
            // 
            // dgvview
            // 
            this.dgvview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvview.Location = new System.Drawing.Point(0, 560);
            this.dgvview.Name = "dgvview";
            this.dgvview.RowTemplate.Height = 24;
            this.dgvview.Size = new System.Drawing.Size(891, 342);
            this.dgvview.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnMainMenu);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnReview);
            this.panel1.Controls.Add(this.btnHistory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1294, 67);
            this.panel1.TabIndex = 40;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMainMenu.Image")));
            this.btnMainMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainMenu.Location = new System.Drawing.Point(835, -1);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(210, 74);
            this.btnMainMenu.TabIndex = 7;
            this.btnMainMenu.Text = "MainMenu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1215, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-1, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "Rent Now";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(626, -1);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(210, 74);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnReview
            // 
            this.btnReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReview.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReview.Image = ((System.Drawing.Image)(resources.GetObject("btnReview.Image")));
            this.btnReview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReview.Location = new System.Drawing.Point(208, -1);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(210, 74);
            this.btnReview.TabIndex = 5;
            this.btnReview.Text = "Review";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Location = new System.Drawing.Point(417, -1);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(210, 74);
            this.btnHistory.TabIndex = 6;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1294, 67);
            this.panel2.TabIndex = 39;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(900, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(292, 35);
            this.textBox1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(87, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1129, 67);
            this.label3.TabIndex = 13;
            this.label3.Text = "Lumani Rental Store";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(87, 67);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(1216, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 67);
            this.button3.TabIndex = 16;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.btnRent);
            this.panel3.Controls.Add(this.lbltotalduration);
            this.panel3.Controls.Add(this.lblfinalamount);
            this.panel3.Controls.Add(this.btnCart);
            this.panel3.Controls.Add(this.lblTopic);
            this.panel3.Location = new System.Drawing.Point(889, 560);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(404, 342);
            this.panel3.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 36);
            this.label6.TabIndex = 46;
            this.label6.Text = "Total Amount";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 36);
            this.label4.TabIndex = 45;
            this.label4.Text = "Total Duartion";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(114, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(213, 1);
            this.panel4.TabIndex = 44;
            // 
            // btnRent
            // 
            this.btnRent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRent.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRent.Image = ((System.Drawing.Image)(resources.GetObject("btnRent.Image")));
            this.btnRent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRent.Location = new System.Drawing.Point(220, 253);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(155, 63);
            this.btnRent.TabIndex = 43;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click_2);
            // 
            // lbltotalduration
            // 
            this.lbltotalduration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(208)))), ((int)(((byte)(51)))));
            this.lbltotalduration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltotalduration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbltotalduration.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalduration.Location = new System.Drawing.Point(220, 86);
            this.lbltotalduration.Name = "lbltotalduration";
            this.lbltotalduration.Size = new System.Drawing.Size(155, 36);
            this.lbltotalduration.TabIndex = 41;
            // 
            // lblfinalamount
            // 
            this.lblfinalamount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(208)))), ((int)(((byte)(51)))));
            this.lblfinalamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblfinalamount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblfinalamount.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfinalamount.Location = new System.Drawing.Point(220, 167);
            this.lblfinalamount.Name = "lblfinalamount";
            this.lblfinalamount.Size = new System.Drawing.Size(155, 36);
            this.lblfinalamount.TabIndex = 40;
            // 
            // btnCart
            // 
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCart.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.Image = ((System.Drawing.Image)(resources.GetObject("btnCart.Image")));
            this.btnCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.Location = new System.Drawing.Point(36, 253);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(150, 61);
            this.btnCart.TabIndex = 42;
            this.btnCart.Text = "Cart";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click_1);
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.BackColor = System.Drawing.Color.Transparent;
            this.lblTopic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTopic.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTopic.Location = new System.Drawing.Point(107, 9);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(220, 37);
            this.lblTopic.TabIndex = 39;
            this.lblTopic.Text = "Shopping Cart";
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(208)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1294, 902);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvview);
            this.Controls.Add(this.gpRentData);
            this.Controls.Add(this.gpCustomer);
            this.Controls.Add(this.gpAppliance);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rent";
            this.Text = "Rent";
            this.Load += new System.EventHandler(this.Rent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appliancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rental)).EndInit();
            this.gpRentData.ResumeLayout(false);
            this.gpRentData.PerformLayout();
            this.gpCustomer.ResumeLayout(false);
            this.gpCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpAppliance.ResumeLayout(false);
            this.gpAppliance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvview)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAName;
        private System.Windows.Forms.BindingSource appliancesBindingSource;
        private Rental rental;
        private System.Windows.Forms.GroupBox gpRentData;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txttotalamount;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblMonthlyFees;
        private System.Windows.Forms.TextBox txtfees;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.TextBox txtRentID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAID;
        private System.Windows.Forms.GroupBox gpCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAName;
        private RentalTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private RentalTableAdapters.AppliancesTableAdapter appliancesTableAdapter;
        private System.Windows.Forms.GroupBox gpAppliance;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.Label lblBrandID;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.TextBox txtBrandID;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox txtCaID;
        private System.Windows.Forms.TextBox txtAID;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.DataGridView dgvview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Label lbltotalduration;
        private System.Windows.Forms.Label lblfinalamount;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;

    }
}