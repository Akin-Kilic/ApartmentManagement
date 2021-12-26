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
    public partial class FrmManagerOperations : Form
    {
        public FrmManagerOperations()
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
            var da = db.ListDatasQuery("select * from yonetici_bilgileri order by id");
            dataGridView1.DataSource = da.Tables[0];
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Eklemek istediğinize emin misiniz?", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (TxtAd.Text == "" || TxtSoyad.Text == "" || TxtKullaniciAd.Text == "" || TxtSifre.Text == "" || TxtDaire.Text == "")
                {
                    MessageBox.Show("Hatalı bilgi girişi yapıldı");
                }
                else if (SayiMi(TxtId.Text))
                {
                    MessageBox.Show("Ekleme işleminde id girilemez");
                }
                else if (!SayiMi(TxtDaire.Text))
                {

                }
                else
                {
                    var da = db.Reader($"insert into yonetici_bilgileri (ad, soyad, daire_no, sifre, kullanici_adi) values ('{TxtAd.Text}', '{TxtSoyad.Text}', {Convert.ToInt32(TxtDaire.Text)}, '{TxtKullaniciAd.Text}', '{TxtSifre.Text}')");

                    MessageBox.Show("Yönetici kaydı başarılı bir şekilde gerçekleşti", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var da2 = db.ListDatasQuery("select * from yonetici_bilgileri order by id");
                    dataGridView1.DataSource = da2.Tables[0];

                    TxtAd.Clear();
                    TxtSoyad.Clear();
                    TxtKullaniciAd.Clear();
                    TxtSifre.Clear();
                    TxtDaire.Clear();
                    TxtAd.Focus();

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
                    var da = db.Reader($"delete from yonetici_bilgileri where id = {Convert.ToInt32(TxtId.Text)}");
                    MessageBox.Show("Yönetici silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    var da2 = db.ListDatasQuery($"select * from yonetici_bilgileri order by id");
                    dataGridView1.DataSource = da2.Tables[0];
                }
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Güncellemek istediğinize emin misiniz?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                var da = db.Reader($"update yonetici_bilgileri set ad = '{TxtAd.Text}', soyad = '{TxtSoyad.Text}', kullanici_adi = '{TxtKullaniciAd.Text}', sifre = '{TxtSifre.Text}', daire_no = '{Convert.ToInt32(TxtDaire.Text)}' where id = {Convert.ToInt32(TxtId.Text)}");
                MessageBox.Show("Yönetici güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                var da2 = db.ListDatasQuery($"select * from yonetici_bilgileri order by id");
                dataGridView1.DataSource = da2.Tables[0];
            }
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        //Color Code
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
                label4.ForeColor = ThemeColor.PrimaryColor;
                label5.ForeColor = ThemeColor.PrimaryColor;
                label6.ForeColor = ThemeColor.PrimaryColor;
                label7.ForeColor = ThemeColor.PrimaryColor;
            }
        }
    }
}
