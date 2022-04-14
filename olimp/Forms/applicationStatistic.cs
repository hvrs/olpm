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
    }
}
