namespace ApartmentManagement
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BtnGiris = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.TxtKullaniciAd = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtSifre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnExit = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.SandyBrown;
            this.linkLabel1.Location = new System.Drawing.Point(878, 419);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(108, 17);
            this.linkLabel1.TabIndex = 44;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi Unuttum";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(904, 328);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 21);
            this.checkBox1.TabIndex = 43;
            this.checkBox1.Text = "Parolayı Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // BtnGiris
            // 
            this.BtnGiris.AllowToggling = false;
            this.BtnGiris.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGiris.AnimationSpeed = 200;
            this.BtnGiris.AutoGenerateColors = false;
            this.BtnGiris.BackColor = System.Drawing.Color.Transparent;
            this.BtnGiris.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.BtnGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGiris.BackgroundImage")));
            this.BtnGiris.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnGiris.ButtonText = "Giriş";
            this.BtnGiris.ButtonTextMarginLeft = 0;
            this.BtnGiris.ColorContrastOnClick = 45;
            this.BtnGiris.ColorContrastOnHover = 45;
            this.BtnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BtnGiris.CustomizableEdges = borderEdges1;
            this.BtnGiris.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnGiris.DisabledBorderColor = System.Drawing.Color.Empty;
            this.BtnGiris.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnGiris.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnGiris.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnGiris.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.BtnGiris.ForeColor = System.Drawing.Color.White;
            this.BtnGiris.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGiris.IconMarginLeft = 11;
            this.BtnGiris.IconPadding = 10;
            this.BtnGiris.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGiris.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnGiris.IdleBorderRadius = 50;
            this.BtnGiris.IdleBorderThickness = 1;
            this.BtnGiris.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.BtnGiris.IdleIconLeftImage = null;
            this.BtnGiris.IdleIconRightImage = null;
            this.BtnGiris.IndicateFocus = false;
            this.BtnGiris.Location = new System.Drawing.Point(882, 358);
            this.BtnGiris.Name = "BtnGiris";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 50;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.BtnGiris.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 50;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.BtnGiris.OnPressedState = stateProperties2;
            this.BtnGiris.Size = new System.Drawing.Size(210, 45);
            this.BtnGiris.TabIndex = 46;
            this.BtnGiris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnGiris.TextMarginLeft = 0;
            this.BtnGiris.UseDefaultRadiusAndThickness = true;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click_1);
            // 
            // TxtKullaniciAd
            // 
            this.TxtKullaniciAd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtKullaniciAd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtKullaniciAd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtKullaniciAd.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtKullaniciAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtKullaniciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxtKullaniciAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtKullaniciAd.HintForeColor = System.Drawing.Color.Empty;
            this.TxtKullaniciAd.HintText = "";
            this.TxtKullaniciAd.isPassword = false;
            this.TxtKullaniciAd.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxtKullaniciAd.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtKullaniciAd.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TxtKullaniciAd.LineThickness = 3;
            this.TxtKullaniciAd.Location = new System.Drawing.Point(882, 237);
            this.TxtKullaniciAd.Margin = new System.Windows.Forms.Padding(4);
            this.TxtKullaniciAd.MaxLength = 32767;
            this.TxtKullaniciAd.Name = "TxtKullaniciAd";
            this.TxtKullaniciAd.Size = new System.Drawing.Size(313, 33);
            this.TxtKullaniciAd.TabIndex = 48;
            this.TxtKullaniciAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSifre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtSifre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtSifre.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxtSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtSifre.HintForeColor = System.Drawing.Color.Empty;
            this.TxtSifre.HintText = "";
            this.TxtSifre.isPassword = true;
            this.TxtSifre.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxtSifre.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtSifre.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TxtSifre.LineThickness = 3;
            this.TxtSifre.Location = new System.Drawing.Point(882, 278);
            this.TxtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSifre.MaxLength = 32767;
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(313, 33);
            this.TxtSifre.TabIndex = 49;
            this.TxtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(220)))));
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.PeachPuff;
            this.bunifuLabel1.Location = new System.Drawing.Point(750, 243);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(91, 22);
            this.bunifuLabel1.TabIndex = 51;
            this.bunifuLabel1.Text = "Kullanıcı Adı:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(220)))));
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.PeachPuff;
            this.bunifuLabel2.Location = new System.Drawing.Point(817, 284);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(40, 22);
            this.bunifuLabel2.TabIndex = 52;
            this.bunifuLabel2.Text = "Şifre:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(200, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(281, 313);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // BtnExit
            // 
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(220)))));
            this.BtnExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.BtnExit.IconColor = System.Drawing.Color.White;
            this.BtnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExit.Location = new System.Drawing.Point(1235, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(53, 50);
            this.BtnExit.TabIndex = 54;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtKullaniciAd);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1200, 720);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnGiris;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtKullaniciAd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtSifre;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton BtnExit;
    }
}