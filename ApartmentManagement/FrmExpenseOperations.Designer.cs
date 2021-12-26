namespace ApartmentManagement
{
    partial class FrmExpenseOperations
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAdidatUcret = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gider Listesi";
            // 
            // BtnSil
            // 
            this.BtnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
            this.BtnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.ForeColor = System.Drawing.Color.White;
            this.BtnSil.Location = new System.Drawing.Point(830, 283);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(167, 34);
            this.BtnSil.TabIndex = 83;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
            this.BtnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.ForeColor = System.Drawing.Color.White;
            this.BtnGuncelle.Location = new System.Drawing.Point(830, 323);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(167, 34);
            this.BtnGuncelle.TabIndex = 82;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
            this.BtnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEkle.ForeColor = System.Drawing.Color.White;
            this.BtnEkle.Location = new System.Drawing.Point(830, 243);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(167, 34);
            this.BtnEkle.TabIndex = 80;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            // 
            // BtnListele
            // 
            this.BtnListele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
            this.BtnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnListele.ForeColor = System.Drawing.Color.White;
            this.BtnListele.Location = new System.Drawing.Point(830, 203);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(167, 34);
            this.BtnListele.TabIndex = 79;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(692, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 78;
            // 
            // TxtAdidatUcret
            // 
            this.TxtAdidatUcret.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAdidatUcret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.TxtAdidatUcret.ForeColor = System.Drawing.Color.White;
            this.TxtAdidatUcret.Location = new System.Drawing.Point(830, 64);
            this.TxtAdidatUcret.Name = "TxtAdidatUcret";
            this.TxtAdidatUcret.Size = new System.Drawing.Size(167, 22);
            this.TxtAdidatUcret.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(756, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 76;
            this.label2.Text = "Apartman:";
            // 
            // TxtId
            // 
            this.TxtId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.TxtId.ForeColor = System.Drawing.Color.White;
            this.TxtId.Location = new System.Drawing.Point(830, 36);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(167, 22);
            this.TxtId.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(803, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 74;
            this.label4.Text = "İd:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(698, 325);
            this.dataGridView1.TabIndex = 73;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(830, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 22);
            this.textBox1.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(787, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 84;
            this.label5.Text = "Blok:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(830, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 22);
            this.textBox2.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(743, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 86;
            this.label6.Text = "Gider Ücreti:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(830, 148);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(167, 49);
            this.textBox3.TabIndex = 89;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(743, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 88;
            this.label7.Text = "Gider Tanımı:";
            // 
            // FrmExpenseOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1028, 374);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAdidatUcret);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmExpenseOperations";
            this.Text = "FrmExpenseOperations";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAdidatUcret;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
    }
}