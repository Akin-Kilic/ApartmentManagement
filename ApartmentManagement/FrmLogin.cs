using ApartmentManagement.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentManagement
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        DB db = new DB();
        FrmHome fr2 = new FrmHome();

        

        private string admin_bilgileri = "admin";
        private string yonetici_bilgileri = "manager";
        private string ev_sahibi_bilgileri = "ev_sahibi_bilgileri";
        

        private bool IsSign = false;
        private void Sign(string table_name)
        {
            var da = db.Reader($"select * from {table_name} where username='{TxtKullaniciAd.Text}' and password='{TxtSifre.Text}'");

            if (da.Read())
            {


                if (admin_bilgileri.ToString() == table_name.ToString())
                {
                    fr2.b = 1;



                }
                else if (yonetici_bilgileri.ToString() == table_name.ToString())
                {
                    fr2.b = 2;

                }
                else 
                {
                    fr2.b = 3;

                }
                
                IsSign = true;

                
            }
        }
        private void BtnGiris_Click(object sender, EventArgs e)
        {

            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                TxtSifre.isPassword = false;

            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                TxtSifre.isPassword = true;

            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnGiris_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtKullaniciAd.Text) || string.IsNullOrWhiteSpace(TxtSifre.Text))
                {

                    MessageBox.Show("Boşluk olamaz!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    Sign("admin");
                    Sign("manager");
                    Sign("homeowner");
                    
                   
                    if (IsSign)
                    {
                        
                        fr2.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı mevcut değil!");
                        
                        TxtKullaniciAd.Focus();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("err" + MessageBox.Show(err.Message) + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
