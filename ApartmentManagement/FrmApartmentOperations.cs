
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
    public partial class FrmApartmentOperations : Form
    {
        public FrmApartmentOperations()
        {
            InitializeComponent();
        }

        DB db = new DB();


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            db.Reader($"insert into apartment_names (apartment_name, block, address, flat_units, manager_id) values ('{TxtApartmentName.Text}','{TxtBlock.Text}','{TxtAddress.Text}',{Convert.ToInt32(TxtFlatUnits.Text)}, {Convert.ToInt32(comboBox1.SelectedValue.ToString())} )");
            MessageBox.Show("Apartment added!");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            db.Reader($"delete from apartment_names where id = {Convert.ToInt32(TxtId.Text)}");
            MessageBox.Show("Apartment deleted");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            db.ExecuteQuery($"update apartment_names set apartment_name='{TxtApartmentName.Text}', block='{TxtBlock.Text}', address='{TxtAddress.Text}', flat_units = '{TxtFlatUnits.Text}', manager_id = '{Convert.ToInt32(comboBox1.SelectedValue.ToString())}' where id={Convert.ToInt32(TxtId.Text)}");
            MessageBox.Show("Apartment updated");
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            var da = db.ListDatas("apartment_names");
            dataGridView1.DataSource = da.Tables[0];

        }

        private void FrmApartmentOperations_Load(object sender, EventArgs e)
        {
            LoadTheme();
            var dt = db.ListComboBox("manager");
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = dt;

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
                label3.ForeColor = ThemeColor.PrimaryColor;
                label4.ForeColor = ThemeColor.PrimaryColor;
                label5.ForeColor = ThemeColor.PrimaryColor;
                label6.ForeColor = ThemeColor.PrimaryColor;
            }
        }
    }
}
