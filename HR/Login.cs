using HR.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            txb_username.GotFocus += txb_username_focus;
            txb_password.GotFocus += txb_password_focus;
        }

        private void txb_username_focus(object sender, EventArgs e)
        {
            txb_username.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txb_password.BackColor = SystemColors.Control;
        }

        private void txb_password_focus(object sender, EventArgs e)
        {
            txb_password.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
            txb_username.BackColor = SystemColors.Control;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txb_password.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txb_password.UseSystemPasswordChar = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình", "Thoát chương trình?", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txb_username.Text;
            string password = txb_password.Text;
            if (login(username,password))
            {
                fManager fManager = new fManager();
                this.Hide();
                fManager.ShowDialog();
                this.Show();
            } else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
        }

        bool login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }

        private void txb_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
/*
class Program
{
    delegate int MyDelegate(string s);
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;

        MyDelegate showString = new MyDelegate(ShowString);

        NhapVaShowTen(showString);

        Console.ReadLine();
    }

    static void NhapVaShowTen(MyDelegate showTen)
    {
        Console.WriteLine("Mời nhập tên của bạn:");
        string ten = Console.ReadLine();
        showTen(ten);
    }

    static int ShowString(string stringValue)
    {
        Console.WriteLine(stringValue);
        return 0;
    }
}*/