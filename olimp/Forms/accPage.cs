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
    public partial class accPage : Form
    {
        public accPage()
        {
            InitializeComponent();
        }
        public static string email;
        private void accPage_Load(object sender, EventArgs e)
        {
            label1.Text = email;
        }

        private void btn_mainMenu_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            MainPage.email = email;
            MainPage.Sign = true;
            mainPage.Show();
            this.Close();
        }

        private void btn_addApp_Click(object sender, EventArgs e)
        {
            addAplication addAplication = new addAplication();
            addAplication.email = email;
            addAplication.Show();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            MainPage.email = "";
            MainPage.Sign = false;
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }

        private void btn_statistic_Click(object sender, EventArgs e)
        {
            applicationList applicationStatistic = new applicationList();
            applicationList.email = email;
            applicationStatistic.Show();
            this.Close();
        }

        private void btn_diagramm_Click(object sender, EventArgs e)
        {
            applicationStats appstat = new applicationStats();
            
            appstat.Show();
            this.Close();
        }
    }
}
