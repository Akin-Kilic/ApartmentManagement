namespace ApartmentManagement
{
    partial class FrmEditMaster
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
            this.npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnAra = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSoayad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTC = new System.Windows.Forms.TextBox();
            this.TxtTelNo = new System.Windows.Forms.TextBox();
            this.TxtAdres = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // npgsqlCommandBuilder1
            // 
            this.npgsqlCommandBuilder1.QuotePrefix = "\"";
            this.npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // BtnSil
            // 
            this.BtnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
            this.BtnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.ForeColor = System.Drawing.Color.White;
            this.BtnSil.Location = new System.Drawing.Point(1127, 108);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(113, 34);
            this.BtnSil.TabIndex = 48;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
            this.BtnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.ForeColor = System.Drawing.Color.White;
            this.BtnGuncelle.Location = new System.Drawing.Point(1127, 148);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(113, 34);
            this.BtnGuncelle.TabIndex = 47;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnAra
            // 
            this.BtnAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
            this.BtnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAra.ForeColor = System.Drawing.Color.White;
            this.BtnAra.Location = new System.Drawing.Point(1127, 188);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(113, 34);
            this.BtnAra.TabIndex = 46;
            this.BtnAra.Text = "Ara";
            this.BtnAra.UseVisualStyleBackColor = false;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
            this.BtnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEkle.ForeColor = System.Drawing.Color.White;
            this.BtnEkle.Location = new System.Drawing.Point(1127, 68);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(113, 34);
            this.BtnEkle.TabIndex = 45;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
            this.BtnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnListele.ForeColor = System.Drawing.Color.White;
            this.BtnListele.Location = new System.Drawing.Point(1127, 28);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(113, 34);
            this.BtnListele.TabIndex = 44;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = false;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(907, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "TC:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(849, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Usta Soyadı:";
            // 
            // TxtSoayad
            // 
            this.TxtSoayad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSoayad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.TxtSoayad.ForeColor = System.Drawing.Color.White;
            this.TxtSoayad.Location = new System.Drawing.Point(943, 88);
            this.TxtSoayad.Name = "TxtSoayad";
            this.TxtSoayad.Size = new System.Drawing.Size(167, 23);
            this.TxtSoayad.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(703, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 40;
            // 
            // TxtAd
            // 
            this.TxtAd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.TxtAd.ForeColor = System.Drawing.Color.White;
            this.TxtAd.Location = new System.Drawing.Point(943, 58);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(167, 23);
            this.TxtAd.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(872, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Usta Adı:";
            // 
            // TxtId
            // 
            this.TxtId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.TxtId.ForeColor = System.Drawing.Color.White;
            this.TxtId.Location = new System.Drawing.Point(943, 28);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(167, 23);
            this.TxtId.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(879, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Usta ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(795, 290);
            this.dataGridView1.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(813, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Telefon Numarası:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(888, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "Adres:";
            // 
            // TxtTC
            // 
            this.TxtTC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.TxtTC.ForeColor = System.Drawing.Color.White;
            this.TxtTC.Location = new System.Drawing.Point(943, 117);
            this.TxtTC.Name = "TxtTC";
            this.TxtTC.Size = new System.Drawing.Size(167, 23);
            this.TxtTC.TabIndex = 51;
            // 
            // TxtTelNo
            // 
            this.TxtTelNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTelNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.TxtTelNo.ForeColor = System.Drawing.Color.White;
            this.TxtTelNo.Location = new System.Drawing.Point(943, 146);
            this.TxtTelNo.Name = "TxtTelNo";
            this.TxtTelNo.Size = new System.Drawing.Size(167, 23);
            this.TxtTelNo.TabIndex = 52;
            // 
            // TxtAdres
            // 
            this.TxtAdres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAdres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.TxtAdres.ForeColor = System.Drawing.Color.White;
            this.TxtAdres.Location = new System.Drawing.Point(943, 175);
            this.TxtAdres.Multiline = true;
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(167, 78);
            this.TxtAdres.TabIndex = 53;
            // 
            // FrmEditMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1252, 316);
            this.Controls.Add(this.TxtAdres);
            this.Controls.Add(this.TxtTelNo);
            this.Controls.Add(this.TxtTC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSoayad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEditMaster";
            this.Text = "FrmEditMaster";
            this.Load += new System.EventHandler(this.FrmEditMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSoayad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtTC;
        private System.Windows.Forms.TextBox TxtTelNo;
        private System.Windows.Forms.TextBox TxtAdres;
    }
}