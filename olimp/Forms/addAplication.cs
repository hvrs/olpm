using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace olimp.Forms
{
    public partial class addAplication : Form
    {
        public addAplication()
        {
            InitializeComponent();
        }

        private void аккаунтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accPage acc = new accPage();
            acc.Show();
            this.Close();
        }

        private void addAplication_Load(object sender, EventArgs e)
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
            lbl_ID.Visible = true; lbl_ID.Text = st;
        }

        private void наГлавнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }
    }
}
