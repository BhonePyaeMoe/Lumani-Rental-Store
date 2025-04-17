namespace Lumani_Rental_Store
{
    partial class CustomerReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerReview));
            this.appliancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rental = new Lumani_Rental_Store.Rental();
            this.lblReviewID = new System.Windows.Forms.Label();
            this.appliancesTableAdapter = new Lumani_Rental_Store.RentalTableAdapters.AppliancesTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCID = new System.Windows.Forms.Label();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txtReviewID = new System.Windows.Forms.TextBox();
            this.txtAID = new System.Windows.Forms.TextBox();
            this.lblAID = new System.Windows.Forms.Label();
            this.lblCName = new System.Windows.Forms.Label();
            this.lblAName = new System.Windows.Forms.Label();
            this.cboAName = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbstar51 = new System.Windows.Forms.PictureBox();
            this.pbstar41 = new System.Windows.Forms.PictureBox();
            this.pbstar31 = new System.Windows.Forms.PictureBox();
            this.pbstar21 = new System.Windows.Forms.PictureBox();
            this.pbstar11 = new System.Windows.Forms.PictureBox();
            this.pbstar2 = new System.Windows.Forms.PictureBox();
            this.pbstar3 = new System.Windows.Forms.PictureBox();
            this.pbstar4 = new System.Windows.Forms.PictureBox();
            this.pbstar5 = new System.Windows.Forms.PictureBox();
            this.pbstar1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.btnReview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appliancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rental)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbstar51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbstar41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbstar31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbstar21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbstar11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbstar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbstar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbstar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbstar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbstar1)).BeginInit();
            this.SuspendLayout();
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
            // lblReviewID
            // 
            this.lblReviewID.BackColor = System.Drawing.Color.Transparent;
            this.lblReviewID.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewID.Image = ((System.Drawing.Image)(resources.GetObject("lblReviewID.Image")));
            this.lblReviewID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblReviewID.Location = new System.Drawing.Point(295, 37);
            this.lblReviewID.Name = "lblReviewID";
            this.lblReviewID.Size = new System.Drawing.Size(201, 37);
            this.lblReviewID.TabIndex = 7;
            this.lblReviewID.Text = "ReviewID";
            this.lblReviewID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // appliancesTableAdapter
            // 
            this.appliancesTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnMainMenu);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnRent);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnReview);
            this.panel1.Controls.Add(this.btnHistory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 73);
            this.panel1.TabIndex = 28;
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
            this.pictureBox2.Location = new System.Drawing.Point(1045, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_2);
            // 
            // btnRent
            // 
            this.btnRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRent.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRent.Image = ((System.Drawing.Image)(resources.GetObject("btnRent.Image")));
            this.btnRent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRent.Location = new System.Drawing.Point(-1, -2);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(210, 74);
            this.btnRent.TabIndex = 1;
            this.btnRent.Text = "Rent Now";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
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
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 67);
            this.panel2.TabIndex = 27;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(734, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(292, 35);
            this.textBox1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(87, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(959, 67);
            this.label2.TabIndex = 13;
            this.label2.Text = "Lumani Rental Store";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.button3.Location = new System.Drawing.Point(1046, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 67);
            this.button3.TabIndex = 16;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblReviewID);
            this.panel3.Controls.Add(this.lblCID);
            this.panel3.Controls.Add(this.txtCName);
            this.panel3.Controls.Add(this.txtReviewID);
            this.panel3.Controls.Add(this.txtAID);
            this.panel3.Controls.Add(this.lblAID);
            this.panel3.Controls.Add(this.lblCName);
            this.panel3.Controls.Add(this.lblAName);
            this.panel3.Controls.Add(this.cboAName);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.txtCID);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1124, 701);
            this.panel3.TabIndex = 29;
            // 
            // lblCID
            // 
            this.lblCID.AutoSize = true;
            this.lblCID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCID.Location = new System.Drawing.Point(3, 143);
            this.lblCID.Name = "lblCID";
            this.lblCID.Size = new System.Drawing.Size(116, 26);
            this.lblCID.TabIndex = 22;
            this.lblCID.Text = "CustomerID";
            // 
            // txtCName
            // 
            this.txtCName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCName.Location = new System.Drawing.Point(167, 234);
            this.txtCName.Multiline = true;
            this.txtCName.Name = "txtCName";
            this.txtCName.ReadOnly = true;
            this.txtCName.Size = new System.Drawing.Size(233, 34);
            this.txtCName.TabIndex = 21;
            // 
            // txtReviewID
            // 
            this.txtReviewID.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReviewID.Location = new System.Drawing.Point(493, 37);
            this.txtReviewID.Multiline = true;
            this.txtReviewID.Name = "txtReviewID";
            this.txtReviewID.ReadOnly = true;
            this.txtReviewID.Size = new System.Drawing.Size(218, 37);
            this.txtReviewID.TabIndex = 1;
            // 
            // txtAID
            // 
            this.txtAID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAID.Location = new System.Drawing.Point(591, 135);
            this.txtAID.Multiline = true;
            this.txtAID.Name = "txtAID";
            this.txtAID.ReadOnly = true;
            this.txtAID.Size = new System.Drawing.Size(239, 34);
            this.txtAID.TabIndex = 20;
            // 
            // lblAID
            // 
            this.lblAID.AutoSize = true;
            this.lblAID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAID.Location = new System.Drawing.Point(431, 143);
            this.lblAID.Name = "lblAID";
            this.lblAID.Size = new System.Drawing.Size(119, 26);
            this.lblAID.TabIndex = 19;
            this.lblAID.Text = "ApplianceID";
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCName.Location = new System.Drawing.Point(3, 242);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(156, 26);
            this.lblCName.TabIndex = 18;
            this.lblCName.Text = "Customer Name";
            // 
            // lblAName
            // 
            this.lblAName.AutoSize = true;
            this.lblAName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAName.Location = new System.Drawing.Point(426, 242);
            this.lblAName.Name = "lblAName";
            this.lblAName.Size = new System.Drawing.Size(159, 26);
            this.lblAName.TabIndex = 17;
            this.lblAName.Text = "Appliance Name";
            // 
            // cboAName
            // 
            this.cboAName.DataSource = this.appliancesBindingSource;
            this.cboAName.DisplayMember = "ApplianceName";
            this.cboAName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAName.FormattingEnabled = true;
            this.cboAName.Location = new System.Drawing.Point(591, 234);
            this.cboAName.Name = "cboAName";
            this.cboAName.Size = new System.Drawing.Size(239, 34);
            this.cboAName.TabIndex = 16;
            this.cboAName.ValueMember = "ApplianceName";
            this.cboAName.SelectedIndexChanged += new System.EventHandler(this.cboAName_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(835, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // txtCID
            // 
            this.txtCID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCID.Location = new System.Drawing.Point(167, 135);
            this.txtCID.Multiline = true;
            this.txtCID.Name = "txtCID";
            this.txtCID.ReadOnly = true;
            this.txtCID.Size = new System.Drawing.Size(233, 34);
            this.txtCID.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.datetime);
            this.panel4.Controls.Add(this.btnSubmit);
            this.panel4.Controls.Add(this.txtFeedback);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pbstar51);
            this.panel4.Controls.Add(this.pbstar41);
            this.panel4.Controls.Add(this.pbstar31);
            this.panel4.Controls.Add(this.pbstar21);
            this.panel4.Controls.Add(this.pbstar11);
            this.panel4.Controls.Add(this.pbstar2);
            this.panel4.Controls.Add(this.pbstar3);
            this.panel4.Controls.Add(this.pbstar4);
            this.panel4.Controls.Add(this.pbstar5);
            this.panel4.Controls.Add(this.pbstar1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lblFeedback);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 460);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1124, 381);
            this.panel4.TabIndex = 30;
            // 
            // datetime
            // 
            this.datetime.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime.Location = new System.Drawing.Point(734, 136);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(360, 31);
            this.datetime.TabIndex = 15;
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(836, 263);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(144, 57);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // txtFeedback
            // 
            this.txtFeedback.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeedback.Location = new System.Drawing.Point(282, 224);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(373, 122);
            this.txtFeedback.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 13.8F);
            this.label3.Location = new System.Drawing.Point(48, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 44);
            this.label3.TabIndex = 12;
            this.label3.Text = "Feedback";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbstar51
            // 
            this.pbstar51.Image = global::Lumani_Rental_Store.Properties.Resources.icons8_red_star_48;
            this.pbstar51.Location = new System.Drawing.Point(591, 127);
            this.pbstar51.Name = "pbstar51";
            this.pbstar51.Size = new System.Drawing.Size(64, 59);
            this.pbstar51.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbstar51.TabIndex = 11;
            this.pbstar51.TabStop = false;
            this.pbstar51.Visible = false;
            this.pbstar51.Click += new System.EventHandler(this.pbstar51_Click);
            // 
            // pbstar41
            // 
            this.pbstar41.Image = global::Lumani_Rental_Store.Properties.Resources.icons8_red_star_48;
            this.pbstar41.Location = new System.Drawing.Point(516, 128);
            this.pbstar41.Name = "pbstar41";
            this.pbstar41.Size = new System.Drawing.Size(64, 59);
            this.pbstar41.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbstar41.TabIndex = 10;
            this.pbstar41.TabStop = false;
            this.pbstar41.Visible = false;
            this.pbstar41.Click += new System.EventHandler(this.pbstar41_Click);
            // 
            // pbstar31
            // 
            this.pbstar31.Image = global::Lumani_Rental_Store.Properties.Resources.icons8_red_star_48;
            this.pbstar31.Location = new System.Drawing.Point(440, 127);
            this.pbstar31.Name = "pbstar31";
            this.pbstar31.Size = new System.Drawing.Size(64, 59);
            this.pbstar31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbstar31.TabIndex = 9;
            this.pbstar31.TabStop = false;
            this.pbstar31.Visible = false;
            this.pbstar31.Click += new System.EventHandler(this.pbstar31_Click);
            // 
            // pbstar21
            // 
            this.pbstar21.Image = global::Lumani_Rental_Store.Properties.Resources.icons8_red_star_48;
            this.pbstar21.Location = new System.Drawing.Point(361, 128);
            this.pbstar21.Name = "pbstar21";
            this.pbstar21.Size = new System.Drawing.Size(64, 59);
            this.pbstar21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbstar21.TabIndex = 8;
            this.pbstar21.TabStop = false;
            this.pbstar21.Visible = false;
            this.pbstar21.Click += new System.EventHandler(this.pbstar21_Click);
            // 
            // pbstar11
            // 
            this.pbstar11.Image = global::Lumani_Rental_Store.Properties.Resources.icons8_red_star_48;
            this.pbstar11.Location = new System.Drawing.Point(282, 128);
            this.pbstar11.Name = "pbstar11";
            this.pbstar11.Size = new System.Drawing.Size(64, 59);
            this.pbstar11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbstar11.TabIndex = 7;
            this.pbstar11.TabStop = false;
            this.pbstar11.Visible = false;
            this.pbstar11.Click += new System.EventHandler(this.pbstar11_Click);
            // 
            // pbstar2
            // 
            this.pbstar2.Image = global::Lumani_Rental_Store.Properties.Resources.icons8_star_48;
            this.pbstar2.Location = new System.Drawing.Point(361, 128);
            this.pbstar2.Name = "pbstar2";
            this.pbstar2.Size = new System.Drawing.Size(64, 58);
            this.pbstar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbstar2.TabIndex = 6;
            this.pbstar2.TabStop = false;
            this.pbstar2.Click += new System.EventHandler(this.pbstar2_Click);
            // 
            // pbstar3
            // 
            this.pbstar3.Image = global::Lumani_Rental_Store.Properties.Resources.icons8_star_481;
            this.pbstar3.Location = new System.Drawing.Point(440, 128);
            this.pbstar3.Name = "pbstar3";
            this.pbstar3.Size = new System.Drawing.Size(64, 58);
            this.pbstar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbstar3.TabIndex = 5;
            this.pbstar3.TabStop = false;
            this.pbstar3.Click += new System.EventHandler(this.pbstar3_Click);
            // 
            // pbstar4
            // 
            this.pbstar4.Image = global::Lumani_Rental_Store.Properties.Resources.icons8_star_48;
            this.pbstar4.Location = new System.Drawing.Point(516, 128);
            this.pbstar4.Name = "pbstar4";
            this.pbstar4.Size = new System.Drawing.Size(64, 58);
            this.pbstar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbstar4.TabIndex = 4;
            this.pbstar4.TabStop = false;
            this.pbstar4.Click += new System.EventHandler(this.pbstar4_Click);
            // 
            // pbstar5
            // 
            this.pbstar5.Image = ((System.Drawing.Image)(resources.GetObject("pbstar5.Image")));
            this.pbstar5.Location = new System.Drawing.Point(591, 128);
            this.pbstar5.Name = "pbstar5";
            this.pbstar5.Size = new System.Drawing.Size(64, 58);
            this.pbstar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbstar5.TabIndex = 3;
            this.pbstar5.TabStop = false;
            this.pbstar5.Click += new System.EventHandler(this.pbstar5_Click);
            // 
            // pbstar1
            // 
            this.pbstar1.Image = global::Lumani_Rental_Store.Properties.Resources.icons8_star_48;
            this.pbstar1.Location = new System.Drawing.Point(282, 128);
            this.pbstar1.Name = "pbstar1";
            this.pbstar1.Size = new System.Drawing.Size(64, 58);
            this.pbstar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbstar1.TabIndex = 2;
            this.pbstar1.TabStop = false;
            this.pbstar1.Click += new System.EventHandler(this.pbstar1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rating";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFeedback
            // 
            this.lblFeedback.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFeedback.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFeedback.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.Location = new System.Drawing.Point(0, 0);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(1122, 79);
            this.lblFeedback.TabIndex = 0;
            this.lblFeedback.Text = "Feedback";
            this.lblFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReview
            // 
            this.btnReview.Enabled = false;
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
            // CustomerReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(208)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1124, 841);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Review";
            this.Load += new System.EventHandler(this.Review_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appliancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rental)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbstar51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbstar41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbstar31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbstar21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbstar11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbstar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbstar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbstar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbstar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbstar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblReviewID;
        private Rental rental;
        private System.Windows.Forms.BindingSource appliancesBindingSource;
        private RentalTableAdapters.AppliancesTableAdapter appliancesTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCID;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.TextBox txtAID;
        private System.Windows.Forms.Label lblAID;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.Label lblAName;
        private System.Windows.Forms.ComboBox cboAName;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.TextBox txtReviewID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.PictureBox pbstar2;
        private System.Windows.Forms.PictureBox pbstar3;
        private System.Windows.Forms.PictureBox pbstar4;
        private System.Windows.Forms.PictureBox pbstar5;
        private System.Windows.Forms.PictureBox pbstar1;
        private System.Windows.Forms.PictureBox pbstar51;
        private System.Windows.Forms.PictureBox pbstar41;
        private System.Windows.Forms.PictureBox pbstar31;
        private System.Windows.Forms.PictureBox pbstar21;
        private System.Windows.Forms.PictureBox pbstar11;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.Button btnReview;
    }
}