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
           else if (IsEmail(tb_Email.Text) == false)
            {
                lbl_typeErr.Visible = true;
                lbl_typeErr.Text = "Неверная почта";
            }
           else
           {
                string hash = CreateMD5Hash(tb_Pasw.Text);
                connectToDatabase connectToDatabase = new connectToDatabase();               
                SignInPage signInPage = new SignInPage();
                connectToDatabase.checkEmailAdress(tb_Email.Text, out bool checkEmail);
                if (checkEmail == true)
                {
                    connectToDatabase.signUp(tb_Email.Text, hash.ToLower());
                    signInPage.Show();
                    this.Close();
                }
                else
                    lbl_typeErr.Visible = true; lbl_typeErr.Text = "Пользователь с данным email уже существует";

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
    }  
}
