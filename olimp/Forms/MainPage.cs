using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using olimp.Forms;

namespace olimp
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public static bool Sign = false;
        public static string email = "";

        private void наГлавнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int count = 64;
            string st = string.Empty;
            int r;
            char[] simb = "abcdefghijklmnoprstuvwxyzABCDEFGHUJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
            for (int i = 0; i < count; i++)
            {
                r = random.Next(simb.Length);
                st += simb[r];
            }
            MessageBox.Show(st);
        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            if (Sign)
            {
                btn_signUp.Visible = false;
                btn_signIN.Visible = false;
                btn_exit.Visible = true;
                btn_toAcc.Visible = true;
                lbl_NameApp.Text = "Количество добавленных приложений: {0}" ;
            }
        }
        private void btn_signUp_Click(object sender, EventArgs e)//Регистрация
        {
            regPage regPage = new regPage();
            regPage.Show();
            this.Hide();
        }

        private void btn_signIN_Click(object sender, EventArgs e)//Авторизация
        {
            SignInPage signInPage = new SignInPage();
            signInPage.Show();
            this.Hide();
        }

        private void btn_toAcc_Click(object sender, EventArgs e)
        {
            accPage accPage = new accPage();
            accPage.Show();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Sign = false;
            email = "";
            this.Visible = false;
            this.Visible = true;
        }
    }
}
