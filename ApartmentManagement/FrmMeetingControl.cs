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
    public partial class FrmMeetingControl : Form
    {
        public FrmMeetingControl()
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

            
            var ds = db.ListDatas("meeting");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {

            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Eklemek istediğinize emin misiniz?", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (TxtBaslik.Text == "" || TxtKonu.Text == "")
                {
                    MessageBox.Show("Hatalı bilgi girişi yapıldı");
                }
                else if (SayiMi(TxtId.Text))
                {
                    MessageBox.Show("Ekleme işleminde id girilemez");
                }
                else
                {
                    db.ExecuteQuery($"insert into meeting (title, subject, location, date) values ('{TxtBaslik.Text}', '{TxtKonu.Text}', '{TxtKonum.Text}', '{dateTimePicker1.Value.ToShortDateString()}')");

                    MessageBox.Show("Toplantı kaydı başarılı bir şekilde gerçekleşti", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var ds = db.ListDatas("meeting");
                    dataGridView1.DataSource = ds.Tables[0];

                    TxtBaslik.Clear();
                    TxtKonu.Clear();
                    TxtKonum.Clear();
                    TxtBaslik.Focus();

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
                    db.ExecuteQuery($"delete from meeting where id={Convert.ToInt32(TxtId.Text)}");
                    MessageBox.Show("Toplantı silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    var ds = db.ListDatas("meeting");
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
                db.ExecuteQuery($"update meeting set title = '{TxtBaslik.Text}', subject = '{TxtKonu.Text}', location = '{TxtKonum.Text}', date = '{dateTimePicker1.Value.ToShortDateString()}' where id = {Convert.ToInt32(TxtId.Text)}");

                MessageBox.Show("Toplantı güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                var ds = db.ListDatas("meeting");
                dataGridView1.DataSource = ds.Tables[0];

                TxtId.Clear();
                TxtBaslik.Clear();
                TxtKonu.Clear();
                TxtKonum.Clear();
                TxtId.Focus();
            }

        }

        private void FrmMeetingControl_Load(object sender, EventArgs e)
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
                label4.ForeColor = ThemeColor.PrimaryColor;
                label5.ForeColor = ThemeColor.PrimaryColor;
                label6.ForeColor = ThemeColor.PrimaryColor;
            }
        }
    }
}
