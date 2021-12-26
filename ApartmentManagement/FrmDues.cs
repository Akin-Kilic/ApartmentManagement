using ApartmentManagement.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentManagement
{
    public partial class FrmDues : Form
    {
        public FrmDues()
        {
            InitializeComponent();
        }

        DB db = new DB();
        public Boolean SayiMi(String text)
        {
            if (String.IsNullOrEmpty(text) == true)
            {
                return false;
            }
            else
            {
                Regex desen = new Regex("^[0-9]*$");
                return desen.IsMatch(text);
            }
        }
        public bool IsHasWiteSpace(string text)
        {
            bool den = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Equals(' '))
                {
                    den = true;
                }
            }
            return den;

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var ds = db.ListDatas("dues");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Eklemek istediğinize emin misiniz?", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (TxtAdidatUcret.Text == "")
                {
                    MessageBox.Show("Hatalı bilgi girişi yapıldı");
                }
                else if (SayiMi(TxtId.Text))
                {
                    MessageBox.Show("Ekleme işleminde id girilemez");
                }
                else
                {
                    db.ExecuteQuery($"insert into dues (dues_fee) values ('{TxtAdidatUcret.Text}')");
                    MessageBox.Show("Aidat kaydı başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var ds = db.ListDatas("dues");
                    dataGridView1.DataSource = ds.Tables[0];

                    TxtAdidatUcret.Clear();
                    TxtAdidatUcret.Focus();
                }
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (SayiMi(TxtId.Text))
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    db.ExecuteQuery($"delete from dues where id={Convert.ToInt32(TxtId.Text)}");
                    MessageBox.Show("Aidat silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    var ds = db.ListDatas("dues");
                    dataGridView1.DataSource = ds.Tables[0];
                    TxtId.Clear();
                    TxtId.Focus();
                }
            }
            else
            {
                MessageBox.Show("geçersiz id");
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Güncellemek istediğinize emin misiniz?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.ExecuteQuery($"update dues set dues_fee={Convert.ToInt32(TxtAdidatUcret.Text)} where id={Convert.ToInt32(TxtId.Text)}");
                MessageBox.Show("Aidat güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                var ds = db.ListDatas("dues");
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {

        }

        private void FrmDues_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {

                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

                }
                label1.ForeColor = ThemeColor.PrimaryColor;
                label2.ForeColor = ThemeColor.PrimaryColor;
            }
        }
    }
}
