using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace olimp
{
    class connectToDatabase
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=1234567890;Database=olimp";
        public void signUp(string email, string password)
        {            
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"INSERT INTO users(email, password) VALUES ('{email}', '{password}')", npgSqlConnection);
            npgSqlCommand.ExecuteNonQuery();
            npgSqlConnection.Close();
        }
        public void signin(string email, out string password, out bool isUser)
        {           
            password = "";
            isUser = true;
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"SELECT password FROM users WHERE email = '{email}';", npgSqlConnection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
            if (npgSqlDataReader.HasRows)
                foreach (DbDataRecord DataRecord in npgSqlDataReader)
                    password = DataRecord["password"].ToString();
            if (npgSqlDataReader.HasRows == false)
                isUser = false;
            npgSqlConnection.Close();
        }
        public void checkEmailAdress(string email, out bool checkEmail)//Проверка на наличие в базе данных 
        {
            checkEmail = false;
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"SELECT email FROM users WHERE email = '{email}';", npgSqlConnection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
            if (!npgSqlDataReader.HasRows)
                checkEmail = true;
            npgSqlConnection.Close();
        }

        public void amountUserApps(string email, out int amountApps)
        {
            amountApps = 0;
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection(connectionString);
            npgsqlConnection.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand($"SELECT nameApp FROM app WHERE email = '{email}';", npgsqlConnection);
            NpgsqlDataReader npgSqlDataReader = npgsqlCommand.ExecuteReader();
            if (npgSqlDataReader.HasRows)
                foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
                    amountApps++;
        }
        public void addAplication(string nameApp, string uID, string email)
        {
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection(connectionString);
            npgsqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"INSERT INTO application(nameApp, uID, data, email) VALUES ('{nameApp}', '{uID}', '{DateTime.Now:g}', '{email}')", npgsqlConnection);
            npgSqlCommand.ExecuteNonQuery();
            npgsqlConnection.Close();
        }
    }
}
