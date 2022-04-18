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
    }
}
