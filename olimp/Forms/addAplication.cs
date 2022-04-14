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
        public static string email = "";
        private void addAplication_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btn_mainMenu_Click(object sender, EventArgs e)//На главную
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }

        private void btn_toAcc_Click(object sender, EventArgs e)
        {
            accPage acc = new accPage();
            acc.Show();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            MainPage.email = "";
            email = "";
            accPage.email = "";
            MainPage.Sign = false;
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int count = 32;
            string uID = string.Empty;
            int r;
            char[] simb = "abcdefghijklmnoprstuvwxyzABCDEFGHUJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
            for (int i = 0; i < count; i++)
            {
                r = random.Next(simb.Length);
                uID += simb[r];
            }
            connectToDatabase connectToDatabase = new connectToDatabase();
            connectToDatabase.addAplication(tb_nameApp.Text, uID, email);

        }

    }
}
