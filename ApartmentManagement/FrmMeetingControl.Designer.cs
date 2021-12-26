namespace ApartmentManagement
{
    partial class FrmMeetingControl
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
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnAra = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtKonu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBaslik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtKonum = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSil
            // 
            this.BtnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
            this.BtnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.ForeColor = System.Drawing.Color.White;
            this.BtnSil.Location = new System.Drawing.Point(995, 95);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(150, 35);
            this.BtnSil.TabIndex = 61;
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
            this.BtnGuncelle.Location = new System.Drawing.Point(995, 136);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(150, 35);
            this.BtnGuncelle.TabIndex = 60;
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
            this.BtnAra.Location = new System.Drawing.Point(995, 177);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(150, 35);
            this.BtnAra.TabIndex = 59;
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
            this.BtnEkle.Location = new System.Drawing.Point(995, 54);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(150, 35);
            this.BtnEkle.TabIndex = 58;
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
            this.BtnListele.Location = new System.Drawing.Point(995, 11);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(150, 35);
            this.BtnListele.TabIndex = 57;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = false;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(701, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "Toplantı Konu:";
            // 
            // TxtKonu
            // 
            this.TxtKonu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtKonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.TxtKonu.ForeColor = System.Drawing.Color.White;
            this.TxtKonu.Location = new System.Drawing.Point(807, 69);
            this.TxtKonu.Name = "TxtKonu";
            this.TxtKonu.Size = new System.Drawing.Size(167, 23);
            this.TxtKonu.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(684, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 54;
            // 
            // TxtBaslik
            // 
            this.TxtBaslik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBaslik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.TxtBaslik.ForeColor = System.Drawing.Color.White;
            this.TxtBaslik.Location = new System.Drawing.Point(807, 40);
            this.TxtBaslik.Name = "TxtBaslik";
            this.TxtBaslik.Size = new System.Drawing.Size(167, 23);
            this.TxtBaslik.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(697, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Toplantı Başlık:";
            // 
            // TxtId
            // 
            this.TxtId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.TxtId.ForeColor = System.Drawing.Color.White;
            this.TxtId.Location = new System.Drawing.Point(807, 11);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(167, 23);
            this.TxtId.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(721, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Toplantı ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(671, 286);
            this.dataGridView1.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(741, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 63;
            this.label5.Text = "Konum:";
            // 
            // TxtKonum
            // 
            this.TxtKonum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtKonum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.TxtKonum.ForeColor = System.Drawing.Color.White;
            this.TxtKonum.Location = new System.Drawing.Point(807, 100);
            this.TxtKonum.Multiline = true;
            this.TxtKonum.Name = "TxtKonum";
            this.TxtKonum.Size = new System.Drawing.Size(167, 74);
            this.TxtKonum.TabIndex = 62;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.BackColor = System.Drawing.Color.SeaGreen;
            this.dateTimePicker1.BorderRadius = 0;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.ForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker1.FormatCustom = null;
            this.dateTimePicker1.Location = new System.Drawing.Point(807, 180);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(167, 49);
            this.dateTimePicker1.TabIndex = 65;
            this.dateTimePicker1.Value = new System.DateTime(2021, 12, 24, 14, 22, 54, 674);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(752, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 66;
            this.label6.Text = "Tarih:";
            // 
            // FrmMeetingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1157, 309);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtKonum);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.TxtBaslik);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtKonu);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.BtnSil);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(767, 348);
            this.Name = "FrmMeetingControl";
            this.Text = "FrmMeetingControl";
            this.Load += new System.EventHandler(this.FrmMeetingControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtKonu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBaslik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtKonum;
        private Bunifu.Framework.UI.BunifuDatepicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
    }
}