using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentManagement
{
    public partial class FrmHome : Form
    {

        //Fields
        private int borderSize = 2;
        private Button currentButton;
        private Random random;
        private int tempIndex;
        public int b;



        //Constructor
        public FrmHome()
        {
            InitializeComponent();
            CustomizeDesing();
            random = new Random();
            this.Padding = new Padding(borderSize); //Border Size
            this.BackColor = Color.FromArgb(98, 102, 244); //Border Color
        }

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);

        }


        private void ActivateButton(object btnSender)
        {
            
            Color color = SelectThemeColor();
            currentButton = (Button)btnSender;
            currentButton.BackColor = color;
            currentButton.ForeColor = Color.White;
            currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            panelTitleBar.BackColor = color;
            panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
            ThemeColor.PrimaryColor = color;
            ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
            
        }


        



        //Visible Buttons
        private void CustomizeDesing()
        {
            BtnAdmin.Visible = false;
            BtnYonetici.Visible = false;
            BtnEvSahibi.Visible = false;
            BtnKapici.Visible = false;
        }


        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg,int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Overridden Methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0X0083;

            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the windoe corresponded
            const int resizeAreaSize = 10;

            //Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of window
            const int HTLEFT = 10;  // LEFT BORDER OF WİNDOW, ALLOWS RESİZE HORİZONTALLY TO THE LEFT
            const int HTRIGHT = 11; //RIGHT BORDER OF WİNDOW, ALLOWS RESİZE HORİZONTALLY TO THE LEFT
            const int HTTOP = 12;
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15;
            const int HTBOTTOMLEFT = 16;
            const int HTBOTTOMRIGHT = 17;

            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)
                {
                    if ((int)m.Result == HTCLIENT)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);

                        if (clientPoint.Y <= resizeAreaSize)
                        {
                            if (clientPoint.X <= resizeAreaSize)
                            {
                                m.Result = (IntPtr)HTTOPLEFT;
                            }
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))
                            {
                                m.Result = (IntPtr)HTTOP;
                            }
                            else
                            {
                                m.Result = (IntPtr)HTTOPRIGHT;
                            }

                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize))
                        {
                            if (clientPoint.X <= resizeAreaSize)
                            {
                                m.Result = (IntPtr)HTLEFT;
                            }
                            else if (clientPoint.X > (this.Width - resizeAreaSize))
                            {
                                m.Result = (IntPtr)HTRIGHT;
                            }
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)
                            {
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            }
                            else if (clientPoint.X < (this.Width - resizeAreaSize))
                            {
                                m.Result = (IntPtr)HTBOTTOM;
                            }
                            else
                            {
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                            }
                        }
                    }
                    return;
                }
            }


            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        //event methods
        private void Form1_Resize(object sender, EventArgs e)
        {
            AddJustForm();
        }

        //private methods
        private void AddJustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0,8,8,0);
                    break;

                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                    {

                    }
                    this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
            
        }

        private void CollapseMenu()
        {
            if (this.panelMenu.Width>200) //Collapse menu
            {
                panelMenu.Width = 100;
                pictureBox1.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                btnMenu.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);

                }
            }
            else //expand menu
            {
                panelMenu.Width = 230;
                pictureBox1.Visible = true;
                btnMenu.Dock = DockStyle.None;
                btnMenu.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10,0,0,0);

                }
            }
        }
        

        //Form Active and Close

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktopPanel.Controls.Add(childForm);
            panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            btnCloseChild.Visible = true;

        }

        private void Reset()
        {


            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(98, 102, 244);
            currentButton = null;
            btnCloseChild.Visible = false;
        }
        private void btnCloseChild_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        //DropDownMenu Code
        private void Open_DropdownMenu(RJDropdownMenu dropdownMenu, object sender)
        {
            Control control = (Control)sender;
            dropdownMenu.VisibleChanged += new EventHandler((sender2, ev) 
                => DropdownMenu_VisibleChanged(sender2, ev, control));
            dropdownMenu.Show(control, control.Width, 0);
        }
        private void DropdownMenu_VisibleChanged(object sender, EventArgs e, Control ctrl)
        {
            RJDropdownMenu dropdownMenu = (RJDropdownMenu)sender;
            if (!DesignMode)
            {
                if (dropdownMenu.Visible)
                {
                    ctrl.BackColor = Color.FromArgb(159,161,224);
                }
                else
                {
                    ctrl.BackColor = Color.FromArgb(98,102,244);
                }
            }
        }
        //Load
        private void Form1_Load(object sender, EventArgs e)
        {



            BtnAdmin.Visible = false;
            BtnYonetici.Visible = false; ;
            BtnEvSahibi.Visible = false;
            BtnKapici.Visible = false;
            btnCloseChild.Visible = false;


            if (b == 1)
            {
                BtnAdmin.Visible = true;
            }
            else if (b == 2)
            {
                BtnYonetici.Visible = true;
            }
            else if (b == 3)
            {
                BtnEvSahibi.Visible = true;
            }
            else if (b == 4)
            {
                BtnKapici.Visible = true;
            }
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {



        }



        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        //Buttons

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Open_DropdownMenu(rjDropdownMenuAdmin, sender);
        }

        private void BtnYonetici_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Open_DropdownMenu(rjDropdownMenuYonetici, sender);
            
        }
        private void BtnEvSahibi_Click(object sender, EventArgs e)
        {

        }
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmLogin().Show();
        }

        //Dropdown Buttons
        //Admin
        private void yöneticiİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            openChildForm(new FrmManagerOperations());
        }
        private void apartmanİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmApartmentOperations());
        }
        //Manager

        private void toplantıİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmMeetingControl());

        }
        private void aidatİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmDues());
        }
        private void ustaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmEditMaster());
        }

        private void kasaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmMoneyVaultOperations());
        }

        private void gelirİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmIncomeOperations());
        }

        private void giderİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmExpenseOperations());
        }
    }
}
