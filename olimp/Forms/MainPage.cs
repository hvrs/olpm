using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace olimp
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public static bool Sign = false;
        private void авторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignInPage signInPage = new SignInPage();
            signInPage.Show();
        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regPage regPage = new regPage();
            regPage.Show();
            this.Hide();
        }

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
            if (Sign == true)
            {
                регистрацияToolStripMenuItem.Visible = false;
                авторизацияToolStripMenuItem.Visible = false;

            }
        }
    }
}
