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
    public partial class FrmEditMaster : Form
    {
        public FrmEditMaster()
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
            var ds = db.ListDatas("master");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void FrmUsta_Load(object sender, EventArgs e)
        {
            

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            //TxtAd.Text = comboBox1.SelectedValue.ToString();

            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Eklemek istediğinize emin misiniz?", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (TxtAd.Text == "" || TxtSoayad.Text == "")
                {
                    MessageBox.Show("Hatalı bilgi girişi yapıldı");
                }
                else if (SayiMi(TxtId.Text))
                {
                    MessageBox.Show("Ekleme işleminde id girilemez");
                }
                else
                {
                    db.ExecuteQuery($"insert into master (name, surname, identification_number, phone number, address) values ('{TxtAd.Text}', '{TxtSoayad.Text}', '{TxtTC.Text}', '{TxtTelNo.Text}', '{TxtAdres.Text}')");
                    MessageBox.Show("Usta kaydı başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var ds = db.ListDatas("master");
                    dataGridView1.DataSource = ds.Tables[0];
                    TxtAd.Clear();
                    TxtSoayad.Clear();

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
                    db.ExecuteQuery($"delete from master where id={Convert.ToInt32(TxtId.Text)}");
                    MessageBox.Show("Usta silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    var ds = db.ListDatas("master");
                    dataGridView1.DataSource = ds.Tables[0];
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
                db.ExecuteQuery($"update master set name='{TxtAd.Text}', surname='{TxtSoayad.Text}', identification_number = '{TxtTC.Text}', phone_number = '{TxtTelNo.Text}', address = '{TxtAdres.Text}'  where id={Convert.ToInt32(TxtId.Text)}");
                MessageBox.Show("Usta güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                var ds = db.ListDatas("master");
                dataGridView1.DataSource = ds.Tables[0];
                TxtAd.Clear();
                TxtSoayad.Clear();
            }
        }

        private void FrmEditMaster_Load(object sender, EventArgs e)
        {
            LoadTheme();
            //var dt = db.ListComboBox("master");
            //comboBox1.DisplayMember = "name";
            //comboBox1.ValueMember = "id";
            //comboBox1.DataSource = dt;
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
            }
        }
    }
}
