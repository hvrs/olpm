using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace olimp
{
    public partial class regPage : Form
    {
        public regPage()
        {
            InitializeComponent();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {

            if (tb_Pasw.Text != tb_PaswRe.Text || tb_Pasw.Text == string.Empty)
            {
                lbl_typeErr.Visible = true;
                lbl_typeErr.Text = "Пароли не совпадают";
            }
           else if (tb_Email.Text == string.Empty)
            {
                lbl_typeErr.Visible = true;
                lbl_typeErr.Text = "Пожалуйста введите Email";
            }            
            if (IsEmail(tb_Email.Text) == false)
            {
                lbl_typeErr.Visible = true;
                lbl_typeErr.Text = "Неверная почта";
            }
            
        }
        static bool IsEmail(string s)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(s);
                return addr.Address == s;
            }
            catch
            {

                return false;
            }
        }
    }
}
