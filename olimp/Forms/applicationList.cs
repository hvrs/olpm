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
    public partial class applicationList : Form
    {
        public applicationList()
        {
            InitializeComponent();
        }
        public static string email = "";
        private DataTable dtabl = new DataTable();

        private void applicationStatistic_Load(object sender, EventArgs e)
        {
            connectToDatabase connectToDatabase = new connectToDatabase();
            connectToDatabase.getListApps(email, GridListApps, dtabl);

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
            MainPage mainPage = new MainPage();
            MainPage.email = email;
            MainPage.Sign = true;
            mainPage.Show();
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
    }
}
