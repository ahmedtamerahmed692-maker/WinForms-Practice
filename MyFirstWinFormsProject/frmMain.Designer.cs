namespace MyFirstWinFormsProject
{
    partial class frmMain
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
            } base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picNotifications = new System.Windows.Forms.PictureBox();
            this.picLanguage = new System.Windows.Forms.PictureBox();
            this.picDarkMode = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.picUserAvatar = new System.Windows.Forms.PictureBox();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnAccountSettle = new System.Windows.Forms.Button();
            this.btnFactorySearch = new System.Windows.Forms.Button();
            this.btnLoans = new System.Windows.Forms.Button();
            this.lblHeaderManager = new System.Windows.Forms.Label();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnReceiveInvoice = new System.Windows.Forms.Button();
            this.lblHeaderResponsible = new System.Windows.Forms.Label();
            this.lblSystemTitle = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.pnlSearchFactory = new System.Windows.Forms.Panel();
            this.pnlAdvance = new System.Windows.Forms.Panel();
            this.pnlStore = new System.Windows.Forms.Panel();
            this.pnlAttendance = new System.Windows.Forms.Panel();
            this.pnlSales = new System.Windows.Forms.Panel();
            this.pnlReceiveInvoice = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNotifications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pnlHeader.Controls.Add(this.picNotifications);
            this.pnlHeader.Controls.Add(this.picLanguage);
            this.pnlHeader.Controls.Add(this.picDarkMode);
            this.pnlHeader.Controls.Add(this.lblUserName);
            this.pnlHeader.Controls.Add(this.picUserAvatar);
            this.pnlHeader.Controls.Add(this.lblAppTitle);
            this.pnlHeader.Controls.Add(this.picLogo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1538, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // picNotifications
            // 
            this.picNotifications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picNotifications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNotifications.Location = new System.Drawing.Point(1293, 26);
            this.picNotifications.Name = "picNotifications";
            this.picNotifications.Size = new System.Drawing.Size(28, 28);
            this.picNotifications.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNotifications.TabIndex = 6;
            this.picNotifications.TabStop = false;
            // 
            // picLanguage
            // 
            this.picLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLanguage.Location = new System.Drawing.Point(1333, 26);
            this.picLanguage.Name = "picLanguage";
            this.picLanguage.Size = new System.Drawing.Size(28, 28);
            this.picLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLanguage.TabIndex = 5;
            this.picLanguage.TabStop = false;
            // 
            // picDarkMode
            // 
            this.picDarkMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picDarkMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDarkMode.Location = new System.Drawing.Point(1373, 26);
            this.picDarkMode.Name = "picDarkMode";
            this.picDarkMode.Size = new System.Drawing.Size(28, 28);
            this.picDarkMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDarkMode.TabIndex = 4;
            this.picDarkMode.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(1413, 30);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(147, 50);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "Ahmed";
            // 
            // picUserAvatar
            // 
            this.picUserAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picUserAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picUserAvatar.Location = new System.Drawing.Point(1478, 22);
            this.picUserAvatar.Name = "picUserAvatar";
            this.picUserAvatar.Size = new System.Drawing.Size(36, 36);
            this.picUserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserAvatar.TabIndex = 2;
            this.picUserAvatar.TabStop = false;
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(90, 27);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(361, 62);
            this.lblAppTitle.TabIndex = 1;
            this.lblAppTitle.Text = "Factory System";
            this.lblAppTitle.Click += new System.EventHandler(this.lblAppTitle_Click);
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(20, 10);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(60, 60);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlSidebar.Controls.Add(this.btnAccountSettle);
            this.pnlSidebar.Controls.Add(this.btnFactorySearch);
            this.pnlSidebar.Controls.Add(this.btnLoans);
            this.pnlSidebar.Controls.Add(this.lblHeaderManager);
            this.pnlSidebar.Controls.Add(this.btnInventory);
            this.pnlSidebar.Controls.Add(this.btnAttendance);
            this.pnlSidebar.Controls.Add(this.btnSales);
            this.pnlSidebar.Controls.Add(this.btnReceiveInvoice);
            this.pnlSidebar.Controls.Add(this.lblHeaderResponsible);
            this.pnlSidebar.Controls.Add(this.lblSystemTitle);
            this.pnlSidebar.Controls.Add(this.lblCompany);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSidebar.Location = new System.Drawing.Point(1298, 80);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Padding = new System.Windows.Forms.Padding(10);
            this.pnlSidebar.Size = new System.Drawing.Size(240, 791);
            this.pnlSidebar.TabIndex = 1;
            // 
            // btnAccountSettle
            // 
            this.btnAccountSettle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAccountSettle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccountSettle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccountSettle.FlatAppearance.BorderSize = 0;
            this.btnAccountSettle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAccountSettle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountSettle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnAccountSettle.ForeColor = System.Drawing.Color.White;
            this.btnAccountSettle.Location = new System.Drawing.Point(10, 380);
            this.btnAccountSettle.Name = "btnAccountSettle";
            this.btnAccountSettle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnAccountSettle.Size = new System.Drawing.Size(220, 42);
            this.btnAccountSettle.TabIndex = 10;
            this.btnAccountSettle.Text = "  ☑️  تسوية حساب";
            this.btnAccountSettle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccountSettle.UseVisualStyleBackColor = false;
            // 
            // btnFactorySearch
            // 
            this.btnFactorySearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnFactorySearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFactorySearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFactorySearch.FlatAppearance.BorderSize = 0;
            this.btnFactorySearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnFactorySearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactorySearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnFactorySearch.ForeColor = System.Drawing.Color.White;
            this.btnFactorySearch.Location = new System.Drawing.Point(10, 338);
            this.btnFactorySearch.Name = "btnFactorySearch";
            this.btnFactorySearch.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnFactorySearch.Size = new System.Drawing.Size(220, 42);
            this.btnFactorySearch.TabIndex = 9;
            this.btnFactorySearch.Text = "  🔍  بحث مصنع";
            this.btnFactorySearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFactorySearch.UseVisualStyleBackColor = false;
            // 
            // btnLoans
            // 
            this.btnLoans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnLoans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoans.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoans.FlatAppearance.BorderSize = 0;
            this.btnLoans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLoans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoans.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnLoans.ForeColor = System.Drawing.Color.White;
            this.btnLoans.Location = new System.Drawing.Point(10, 296);
            this.btnLoans.Name = "btnLoans";
            this.btnLoans.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnLoans.Size = new System.Drawing.Size(220, 42);
            this.btnLoans.TabIndex = 8;
            this.btnLoans.Text = "  💳  السلف";
            this.btnLoans.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoans.UseVisualStyleBackColor = false;
            // 
            // lblHeaderManager
            // 
            this.lblHeaderManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeaderManager.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHeaderManager.ForeColor = System.Drawing.Color.DarkGray;
            this.lblHeaderManager.Location = new System.Drawing.Point(10, 261);
            this.lblHeaderManager.Name = "lblHeaderManager";
            this.lblHeaderManager.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.lblHeaderManager.Size = new System.Drawing.Size(220, 35);
            this.lblHeaderManager.TabIndex = 7;
            this.lblHeaderManager.Text = "للمدير";
            this.lblHeaderManager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Location = new System.Drawing.Point(10, 219);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnInventory.Size = new System.Drawing.Size(220, 42);
            this.btnInventory.TabIndex = 6;
            this.btnInventory.Text = "  💼  المخزن";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInventory.UseVisualStyleBackColor = false;
            // 
            // btnAttendance
            // 
            this.btnAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.Location = new System.Drawing.Point(10, 177);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnAttendance.Size = new System.Drawing.Size(220, 42);
            this.btnAttendance.TabIndex = 5;
            this.btnAttendance.Text = "  👤  الحضور";
            this.btnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAttendance.UseVisualStyleBackColor = false;
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.Location = new System.Drawing.Point(10, 135);
            this.btnSales.Name = "btnSales";
            this.btnSales.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSales.Size = new System.Drawing.Size(220, 42);
            this.btnSales.TabIndex = 4;
            this.btnSales.Text = "  💲  المبيعات";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSales.UseVisualStyleBackColor = false;
            // 
            // btnReceiveInvoice
            // 
            this.btnReceiveInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnReceiveInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceiveInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceiveInvoice.FlatAppearance.BorderSize = 0;
            this.btnReceiveInvoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnReceiveInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceiveInvoice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceiveInvoice.ForeColor = System.Drawing.Color.White;
            this.btnReceiveInvoice.Location = new System.Drawing.Point(10, 90);
            this.btnReceiveInvoice.Name = "btnReceiveInvoice";
            this.btnReceiveInvoice.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnReceiveInvoice.Size = new System.Drawing.Size(220, 45);
            this.btnReceiveInvoice.TabIndex = 3;
            this.btnReceiveInvoice.Text = "  📄  فاتورة استلام";
            this.btnReceiveInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReceiveInvoice.UseVisualStyleBackColor = false;
            // 
            // lblHeaderResponsible
            // 
            this.lblHeaderResponsible.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeaderResponsible.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHeaderResponsible.ForeColor = System.Drawing.Color.DarkGray;
            this.lblHeaderResponsible.Location = new System.Drawing.Point(10, 60);
            this.lblHeaderResponsible.Name = "lblHeaderResponsible";
            this.lblHeaderResponsible.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblHeaderResponsible.Size = new System.Drawing.Size(220, 30);
            this.lblHeaderResponsible.TabIndex = 2;
            this.lblHeaderResponsible.Text = "للمسؤول";
            this.lblHeaderResponsible.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSystemTitle
            // 
            this.lblSystemTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSystemTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblSystemTitle.ForeColor = System.Drawing.Color.White;
            this.lblSystemTitle.Location = new System.Drawing.Point(10, 30);
            this.lblSystemTitle.Name = "lblSystemTitle";
            this.lblSystemTitle.Size = new System.Drawing.Size(220, 30);
            this.lblSystemTitle.TabIndex = 1;
            this.lblSystemTitle.Text = "لوحة التحكم";
            this.lblSystemTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompany
            // 
            this.lblCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCompany.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCompany.ForeColor = System.Drawing.Color.Gray;
            this.lblCompany.Location = new System.Drawing.Point(10, 10);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(220, 20);
            this.lblCompany.TabIndex = 0;
            this.lblCompany.Text = "مصنع النور";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlContent.Controls.Add(this.pnlSettings);
            this.pnlContent.Controls.Add(this.pnlSearchFactory);
            this.pnlContent.Controls.Add(this.pnlAdvance);
            this.pnlContent.Controls.Add(this.pnlStore);
            this.pnlContent.Controls.Add(this.pnlAttendance);
            this.pnlContent.Controls.Add(this.pnlSales);
            this.pnlContent.Controls.Add(this.pnlReceiveInvoice);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 80);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1298, 791);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlSettings
            // 
            this.pnlSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSettings.Location = new System.Drawing.Point(0, 0);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(1298, 791);
            this.pnlSettings.TabIndex = 6;
            this.pnlSettings.Visible = false;
            this.pnlSettings.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSettings_Paint);
            // 
            // pnlSearchFactory
            // 
            this.pnlSearchFactory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlSearchFactory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearchFactory.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchFactory.Name = "pnlSearchFactory";
            this.pnlSearchFactory.Size = new System.Drawing.Size(1298, 791);
            this.pnlSearchFactory.TabIndex = 5;
            this.pnlSearchFactory.Visible = false;
            // 
            // pnlAdvance
            // 
            this.pnlAdvance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlAdvance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdvance.Location = new System.Drawing.Point(0, 0);
            this.pnlAdvance.Name = "pnlAdvance";
            this.pnlAdvance.Size = new System.Drawing.Size(1298, 791);
            this.pnlAdvance.TabIndex = 4;
            this.pnlAdvance.Visible = false;
            // 
            // pnlStore
            // 
            this.pnlStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStore.Location = new System.Drawing.Point(0, 0);
            this.pnlStore.Name = "pnlStore";
            this.pnlStore.Size = new System.Drawing.Size(1298, 791);
            this.pnlStore.TabIndex = 3;
            this.pnlStore.Visible = false;
            // 
            // pnlAttendance
            // 
            this.pnlAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAttendance.Location = new System.Drawing.Point(0, 0);
            this.pnlAttendance.Name = "pnlAttendance";
            this.pnlAttendance.Size = new System.Drawing.Size(1298, 791);
            this.pnlAttendance.TabIndex = 2;
            this.pnlAttendance.Visible = false;
            // 
            // pnlSales
            // 
            this.pnlSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSales.Location = new System.Drawing.Point(0, 0);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(1298, 791);
            this.pnlSales.TabIndex = 1;
            this.pnlSales.Visible = false;
            // 
            // pnlReceiveInvoice
            // 
            this.pnlReceiveInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlReceiveInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReceiveInvoice.Location = new System.Drawing.Point(0, 0);
            this.pnlReceiveInvoice.Name = "pnlReceiveInvoice";
            this.pnlReceiveInvoice.Size = new System.Drawing.Size(1298, 791);
            this.pnlReceiveInvoice.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 50F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1538, 871);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برنامج إدارة الحسابات والفواتير - Factory System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNotifications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.PictureBox picUserAvatar;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox picDarkMode;
        private System.Windows.Forms.PictureBox picLanguage;
        private System.Windows.Forms.PictureBox picNotifications;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblSystemTitle;
        private System.Windows.Forms.Label lblHeaderResponsible;
        private System.Windows.Forms.Button btnReceiveInvoice;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Label lblHeaderManager;
        private System.Windows.Forms.Button btnLoans;
        private System.Windows.Forms.Button btnFactorySearch;
        private System.Windows.Forms.Button btnAccountSettle;
        private System.Windows.Forms.Panel pnlReceiveInvoice;
        private System.Windows.Forms.Panel pnlSales;
        private System.Windows.Forms.Panel pnlAttendance;
        private System.Windows.Forms.Panel pnlStore;
        private System.Windows.Forms.Panel pnlAdvance;
        private System.Windows.Forms.Panel pnlSearchFactory;
        private System.Windows.Forms.Panel pnlSettings;
    }
}