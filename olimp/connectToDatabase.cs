using System.Windows.Forms.DataVisualization.Charting;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"INSERT INTO app(nameApp, uid, data, email, view, edit) VALUES ('{nameApp}', '{uID}', '{DateTime.Now:g}', '{email}', '0', '0')", npgsqlConnection);
            npgSqlCommand.ExecuteNonQuery();
            npgsqlConnection.Close();
        }
        private DataSet dataSet = new DataSet();
        private DataTable Dae = new DataTable();
        public void getListApps(string email, DataGridView dataGridView)
        {
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection(connectionString);
            npgsqlConnection.Open();
          //  NpgsqlCommand npgsqlCommand = new NpgsqlCommand($"SELECT 'Уникальный идентификатор' = SUBSTRING(app.uid,1,50), 'Название' = SUBSTRING(app.nameApp,1,50), 'Дата добавления' = SUBSTRING(app.data) FROM app WHERE email = '{email}'", npgsqlConnection);
            string conn = $"SELECT 'Уникальный идентификатор' = SUBSTRING(app.uid,1,50), 'Название' = SUBSTRING(app.nameApp,1,50), 'Дата добавления' = SUBSTRING(app.data) FROM app WHERE email = '{email}'";
            /*NpgsqlDataReader npgsqlDataReader = npgsqlCommand.ExecuteReader();*/
            NpgsqlDataAdapter DA = new NpgsqlDataAdapter(conn, connectionString);
            dataSet.Reset();
            DA.Fill(dataSet);
            Dae = dataSet.Tables[0];
            dataGridView.DataSource = Dae;
            npgsqlConnection.Close();
        }
        public void checkuid(string uid, out bool isUid)
        {
            isUid = false;
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"SELECT uid FROM app WHERE uid = '{uid}';", npgSqlConnection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
            if (npgSqlDataReader.HasRows)
                isUid = true;
            npgSqlConnection.Close();
        }
        public void statApp(string email, Chart chart)
        {
            int view = 0,  edit = 0;
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection(connectionString);
            npgsqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"SELECT view, edit FROM app WHERE email = '{email}';", npgsqlConnection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
            if (npgSqlDataReader.HasRows)
                foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
                {
                    view = int.Parse(dbDataRecord["view"].ToString());
                    edit = int.Parse(dbDataRecord["edit"].ToString());
                }
            chart.Series[0].Points.AddXY(view);
            chart.Series[1].Points.AddXY(edit);
        }
    }
}
