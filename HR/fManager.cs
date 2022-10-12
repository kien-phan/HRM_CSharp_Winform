using HR.others;
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

namespace HR
{
    public partial class fManager : Form
    {
        //fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        //

        public fManager()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;

            //CONTROL FORM
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //drop down user menu
            customDesign();
        }


        #region decoration
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
            if (btnSender != null)
            {
                DisableButton();
                if (currentButton != (Button)btnSender)
                {
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    lbLogo.ForeColor = Color.White;
                    lbTitle.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);

                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);

                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(47, 79, 79);
                    previousBtn.ForeColor = Color.LightGreen;
                    previousBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }


        //CLICK BTN SIDEBAR
        private void btn_hrm_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.fHRM(), sender);
        }

        private void btn_salary_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.fSalary(), sender);
        }

        private void btn_training_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.fTraining(), sender);
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.fSetting(), sender);
        }



        //CLOSE BTN
        private void btn_statistic_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.fStatistic(), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Reset();
            }
        }

        private void Reset()
        {
            DisableButton();
            lbTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.DarkSlateGray;
            panelLogo.BackColor = Color.FromArgb(60, 90, 90);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        #endregion

        //FORM CONTROL
        public void openChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            lbTitle.Text = (btnSender as Button).Text;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState |= FormWindowState.Minimized;
        }

        //DROP DOWN MENU
        private void customDesign()
        {
            panel_user_container.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panel_user_container.Visible == true)
            {
                panel_user_container.Visible = false;
            }
        }
        private void showMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void btn_user_option_Click(object sender, EventArgs e)
        {
            showMenu(panel_user_container);
        }

        private void btn_user_option_logOut_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
    }
}
