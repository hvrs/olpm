using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using olimp.Forms;

namespace olimp
{
    public partial class SignInPage : Form
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            bool isUser = true;
            string hash = "";
            string password = "";
            if (tb_Email.Text == string.Empty)
            {
                lbl_typeErr.Visible = true;
                lbl_typeErr.Text = "Введите Email";
                return;
            }
            else if (IsEmail(tb_Email.Text) == false)
            {
                lbl_typeErr.Visible = true;
                lbl_typeErr.Text = "Неверная почта";
                return;
            }
            else if (tb_Pasw.Text == string.Empty)
            {
                lbl_typeErr.Visible = true;
                lbl_typeErr.Text = "Введите пароль";
                return;
            }
            else
            {
                hash = CreateMD5Hash(tb_Pasw.Text);
                connectToDatabase connectToDatabase = new connectToDatabase();
                /*connectToDatabase.checkEmailAdress(tb_Email.Text, out bool checkEmail);*/
                connectToDatabase.signin(tb_Email.Text, out password, out isUser);
            }
            if (password.ToLower() == hash.ToLower() && isUser == true)
            {
                MainPage.email = tb_Email.Text;
                MainPage.Sign = true;
                accPage accPage = new accPage();
                accPage.email = tb_Email.Text;
                addAplication.email = tb_Email.Text;
                accPage.Show();
                this.Close();
            }
            else
            {
                lbl_typeErr.Visible = true; lbl_typeErr.Text = "Неверный пароль или логин";
            }
        }

        public string CreateMD5Hash(string input)
        {

            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);


            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
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
