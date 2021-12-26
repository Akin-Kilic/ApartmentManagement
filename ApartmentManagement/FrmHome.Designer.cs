namespace ApartmentManagement
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BtnCikis = new FontAwesome.Sharp.IconButton();
            this.BtnKapici = new FontAwesome.Sharp.IconButton();
            this.BtnEvSahibi = new FontAwesome.Sharp.IconButton();
            this.BtnYonetici = new FontAwesome.Sharp.IconButton();
            this.BtnAdmin = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseChild = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rjDropdownMenuAdmin = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.yöneticiİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apartmanİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rjDropdownMenuYonetici = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.toplantıİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aidatİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kasaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rjDropdownMenuEvSahibi = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.rjDropdownMenuAdmin.SuspendLayout();
            this.rjDropdownMenuYonetici.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.panelMenu.Controls.Add(this.BtnCikis);
            this.panelMenu.Controls.Add(this.BtnKapici);
            this.panelMenu.Controls.Add(this.BtnEvSahibi);
            this.panelMenu.Controls.Add(this.BtnYonetici);
            this.panelMenu.Controls.Add(this.BtnAdmin);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 607);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // BtnCikis
            // 
            this.BtnCikis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnCikis.FlatAppearance.BorderSize = 0;
            this.BtnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCikis.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.ForeColor = System.Drawing.Color.White;
            this.BtnCikis.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.BtnCikis.IconColor = System.Drawing.Color.White;
            this.BtnCikis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCikis.IconSize = 30;
            this.BtnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCikis.Location = new System.Drawing.Point(0, 561);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnCikis.Size = new System.Drawing.Size(230, 46);
            this.BtnCikis.TabIndex = 5;
            this.BtnCikis.Tag = "Çıkış";
            this.BtnCikis.Text = "   Çıkış";
            this.BtnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // BtnKapici
            // 
            this.BtnKapici.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnKapici.FlatAppearance.BorderSize = 0;
            this.BtnKapici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKapici.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKapici.ForeColor = System.Drawing.Color.White;
            this.BtnKapici.IconChar = FontAwesome.Sharp.IconChar.Spa;
            this.BtnKapici.IconColor = System.Drawing.Color.White;
            this.BtnKapici.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnKapici.IconSize = 30;
            this.BtnKapici.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKapici.Location = new System.Drawing.Point(0, 198);
            this.BtnKapici.Name = "BtnKapici";
            this.BtnKapici.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnKapici.Size = new System.Drawing.Size(230, 46);
            this.BtnKapici.TabIndex = 4;
            this.BtnKapici.Tag = "Kapıcı";
            this.BtnKapici.Text = "   Kapıcı";
            this.BtnKapici.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKapici.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnKapici.UseVisualStyleBackColor = true;
            // 
            // BtnEvSahibi
            // 
            this.BtnEvSahibi.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEvSahibi.FlatAppearance.BorderSize = 0;
            this.BtnEvSahibi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEvSahibi.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEvSahibi.ForeColor = System.Drawing.Color.White;
            this.BtnEvSahibi.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.BtnEvSahibi.IconColor = System.Drawing.Color.White;
            this.BtnEvSahibi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEvSahibi.IconSize = 30;
            this.BtnEvSahibi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEvSahibi.Location = new System.Drawing.Point(0, 152);
            this.BtnEvSahibi.Name = "BtnEvSahibi";
            this.BtnEvSahibi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnEvSahibi.Size = new System.Drawing.Size(230, 46);
            this.BtnEvSahibi.TabIndex = 3;
            this.BtnEvSahibi.Tag = "Ev Sahibi";
            this.BtnEvSahibi.Text = "   Ev Sahibi";
            this.BtnEvSahibi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEvSahibi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEvSahibi.UseVisualStyleBackColor = true;
            this.BtnEvSahibi.Click += new System.EventHandler(this.BtnEvSahibi_Click);
            // 
            // BtnYonetici
            // 
            this.BtnYonetici.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnYonetici.FlatAppearance.BorderSize = 0;
            this.BtnYonetici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnYonetici.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYonetici.ForeColor = System.Drawing.Color.White;
            this.BtnYonetici.IconChar = FontAwesome.Sharp.IconChar.Hubspot;
            this.BtnYonetici.IconColor = System.Drawing.Color.White;
            this.BtnYonetici.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnYonetici.IconSize = 30;
            this.BtnYonetici.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnYonetici.Location = new System.Drawing.Point(0, 106);
            this.BtnYonetici.Name = "BtnYonetici";
            this.BtnYonetici.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnYonetici.Size = new System.Drawing.Size(230, 46);
            this.BtnYonetici.TabIndex = 2;
            this.BtnYonetici.Tag = "Yönetici";
            this.BtnYonetici.Text = "   Yönetici";
            this.BtnYonetici.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnYonetici.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnYonetici.UseVisualStyleBackColor = true;
            this.BtnYonetici.Click += new System.EventHandler(this.BtnYonetici_Click);
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAdmin.FlatAppearance.BorderSize = 0;
            this.BtnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdmin.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdmin.ForeColor = System.Drawing.Color.White;
            this.BtnAdmin.IconChar = FontAwesome.Sharp.IconChar.Atlassian;
            this.BtnAdmin.IconColor = System.Drawing.Color.White;
            this.BtnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAdmin.IconSize = 30;
            this.BtnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdmin.Location = new System.Drawing.Point(0, 60);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnAdmin.Size = new System.Drawing.Size(230, 46);
            this.BtnAdmin.TabIndex = 1;
            this.BtnAdmin.Tag = "Admin";
            this.BtnAdmin.Text = "   Admin";
            this.BtnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAdmin.UseVisualStyleBackColor = true;
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnMenu);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(230, 60);
            this.panelLogo.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 30;
            this.btnMenu.Location = new System.Drawing.Point(188, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(42, 60);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Controls.Add(this.btnCloseChild);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(230, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1046, 60);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(419, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "HOME";
            // 
            // btnCloseChild
            // 
            this.btnCloseChild.FlatAppearance.BorderSize = 0;
            this.btnCloseChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChild.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnCloseChild.IconColor = System.Drawing.Color.White;
            this.btnCloseChild.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseChild.IconSize = 30;
            this.btnCloseChild.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChild.Name = "btnCloseChild";
            this.btnCloseChild.Size = new System.Drawing.Size(45, 60);
            this.btnCloseChild.TabIndex = 5;
            this.btnCloseChild.UseVisualStyleBackColor = true;
            this.btnCloseChild.Click += new System.EventHandler(this.btnCloseChild_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(130)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(885, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(54, 57);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(130)))));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(937, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(53, 57);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(130)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(989, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(52, 57);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panelDesktopPanel.Controls.Add(this.pictureBox2);
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(230, 60);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1046, 547);
            this.panelDesktopPanel.TabIndex = 2;
            this.panelDesktopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(223, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(512, 512);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // rjDropdownMenuAdmin
            // 
            this.rjDropdownMenuAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rjDropdownMenuAdmin.IsMainMenu = false;
            this.rjDropdownMenuAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yöneticiİşlemleriToolStripMenuItem,
            this.apartmanİşlemleriToolStripMenuItem});
            this.rjDropdownMenuAdmin.MenuItemHeight = 50;
            this.rjDropdownMenuAdmin.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenuAdmin.Name = "rjDropdownMenuAdmin";
            this.rjDropdownMenuAdmin.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(161)))), ((int)(((byte)(224)))));
            this.rjDropdownMenuAdmin.Size = new System.Drawing.Size(175, 48);
            // 
            // yöneticiİşlemleriToolStripMenuItem
            // 
            this.yöneticiİşlemleriToolStripMenuItem.Name = "yöneticiİşlemleriToolStripMenuItem";
            this.yöneticiİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.yöneticiİşlemleriToolStripMenuItem.Text = "Yönetici İşlemleri";
            this.yöneticiİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.yöneticiİşlemleriToolStripMenuItem_Click);
            // 
            // apartmanİşlemleriToolStripMenuItem
            // 
            this.apartmanİşlemleriToolStripMenuItem.Name = "apartmanİşlemleriToolStripMenuItem";
            this.apartmanİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.apartmanİşlemleriToolStripMenuItem.Text = "Apartman İşlemleri";
            this.apartmanİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.apartmanİşlemleriToolStripMenuItem_Click);
            // 
            // rjDropdownMenuYonetici
            // 
            this.rjDropdownMenuYonetici.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rjDropdownMenuYonetici.IsMainMenu = false;
            this.rjDropdownMenuYonetici.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toplantıİşlemleriToolStripMenuItem,
            this.aidatİşlemleriToolStripMenuItem,
            this.ustaİşlemleriToolStripMenuItem,
            this.kasaİşlemleriToolStripMenuItem,
            this.gelirİşlemleriToolStripMenuItem,
            this.giderİşlemleriToolStripMenuItem});
            this.rjDropdownMenuYonetici.MenuItemHeight = 50;
            this.rjDropdownMenuYonetici.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenuYonetici.Name = "rjDropdownMenuYonetici";
            this.rjDropdownMenuYonetici.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(161)))), ((int)(((byte)(224)))));
            this.rjDropdownMenuYonetici.Size = new System.Drawing.Size(164, 136);
            // 
            // toplantıİşlemleriToolStripMenuItem
            // 
            this.toplantıİşlemleriToolStripMenuItem.Name = "toplantıİşlemleriToolStripMenuItem";
            this.toplantıİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.toplantıİşlemleriToolStripMenuItem.Text = "Toplantı İşlemleri";
            this.toplantıİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.toplantıİşlemleriToolStripMenuItem_Click);
            // 
            // aidatİşlemleriToolStripMenuItem
            // 
            this.aidatİşlemleriToolStripMenuItem.Name = "aidatİşlemleriToolStripMenuItem";
            this.aidatİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.aidatİşlemleriToolStripMenuItem.Text = "Aidat İşlemleri";
            this.aidatİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.aidatİşlemleriToolStripMenuItem_Click);
            // 
            // ustaİşlemleriToolStripMenuItem
            // 
            this.ustaİşlemleriToolStripMenuItem.Name = "ustaİşlemleriToolStripMenuItem";
            this.ustaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.ustaİşlemleriToolStripMenuItem.Text = "Usta İşlemleri";
            this.ustaİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.ustaİşlemleriToolStripMenuItem_Click);
            // 
            // kasaİşlemleriToolStripMenuItem
            // 
            this.kasaİşlemleriToolStripMenuItem.Name = "kasaİşlemleriToolStripMenuItem";
            this.kasaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.kasaİşlemleriToolStripMenuItem.Text = "Kasa İşlemleri";
            this.kasaİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.kasaİşlemleriToolStripMenuItem_Click);
            // 
            // gelirİşlemleriToolStripMenuItem
            // 
            this.gelirİşlemleriToolStripMenuItem.Name = "gelirİşlemleriToolStripMenuItem";
            this.gelirİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.gelirİşlemleriToolStripMenuItem.Text = "Gelir İşlemleri";
            this.gelirİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.gelirİşlemleriToolStripMenuItem_Click);
            // 
            // giderİşlemleriToolStripMenuItem
            // 
            this.giderİşlemleriToolStripMenuItem.Name = "giderİşlemleriToolStripMenuItem";
            this.giderİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.giderİşlemleriToolStripMenuItem.Text = "Gider İşlemleri";
            this.giderİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.giderİşlemleriToolStripMenuItem_Click);
            // 
            // rjDropdownMenuEvSahibi
            // 
            this.rjDropdownMenuEvSahibi.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rjDropdownMenuEvSahibi.IsMainMenu = false;
            this.rjDropdownMenuEvSahibi.MenuItemHeight = 25;
            this.rjDropdownMenuEvSahibi.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenuEvSahibi.Name = "rjDropdownMenuEvSahibi";
            this.rjDropdownMenuEvSahibi.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenuEvSahibi.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 607);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1292, 600);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktopPanel.ResumeLayout(false);
            this.panelDesktopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.rjDropdownMenuAdmin.ResumeLayout(false);
            this.rjDropdownMenuYonetici.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private FontAwesome.Sharp.IconButton BtnAdmin;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton BtnKapici;
        private FontAwesome.Sharp.IconButton BtnEvSahibi;
        private FontAwesome.Sharp.IconButton BtnYonetici;
        private RJCodeAdvance.RJControls.RJDropdownMenu rjDropdownMenuAdmin;
        private System.Windows.Forms.ToolStripMenuItem yöneticiİşlemleriToolStripMenuItem;
        private RJCodeAdvance.RJControls.RJDropdownMenu rjDropdownMenuYonetici;
        private System.Windows.Forms.ToolStripMenuItem toplantıİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aidatİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btnCloseChild;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton BtnCikis;
        private RJCodeAdvance.RJControls.RJDropdownMenu rjDropdownMenuEvSahibi;
        private System.Windows.Forms.ToolStripMenuItem apartmanİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kasaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelirİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderİşlemleriToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

