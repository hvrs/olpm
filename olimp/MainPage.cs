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

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regPage regPage = new regPage();
            regPage.Show();
        }

        private void авторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void наГлавнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
