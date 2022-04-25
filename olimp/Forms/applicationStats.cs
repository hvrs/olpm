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
    public partial class applicationStats : Form
    {
        public applicationStats()
        {
            InitializeComponent();
        }
        public static string email;
        private void applicationStats_Load(object sender, EventArgs e)
        {
            connectToDatabase connectToDatabase = new connectToDatabase();
            connectToDatabase.statApp(email, chart1);
        }

        private void btn_toAcc_Click(object sender, EventArgs e)
        {
            accPage.email = email;
            accPage acPage = new accPage();
            acPage.Show();
            this.Close();
        }

        private void btn_mainMenu_Click(object sender, EventArgs e)
        {
            MainPage.email = email;
            MainPage.Sign = true;
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            email = "";
            MainPage.email = "";
            MainPage.Sign = false;
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }
    }
}
