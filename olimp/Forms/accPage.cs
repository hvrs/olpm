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

        private void добавитьПриложениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addAplication addAplication = new addAplication();
            addAplication.Show();
            this.Close();
        }

        private void наГлавнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }
    }
}
