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
    public partial class applicationStatistic : Form
    {
        public applicationStatistic()
        {
            InitializeComponent();
        }
        public static string email = "";
        private void applicationStatistic_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            if (GridListApps.Rows.Count !=0)
            {
                GridListApps.Visible = true;
                GridListApps.DataSource = dataTable;
                GridListApps.Update();
            }
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
