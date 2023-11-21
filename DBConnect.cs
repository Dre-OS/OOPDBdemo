using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDBdemo
{
    public class DBConnect
    {

        public string server { get; set; }
        public string database { get; set; }
        public string uid { get; set; }
        public string password { get; set; }
        public string connectionString { get; set; }

        public MySqlConnection connection { get; set; }
        public MySqlCommand command { get; set; }

        public MySqlDataAdapter dataAdapter { get; set; }
        public DataTable dataTable { get; set; }

        public DBConnect()
        {
            connection = new MySqlConnection();
            command = new MySqlCommand();
            dataAdapter = new MySqlDataAdapter();
            dataTable = new DataTable();
            server = string.Empty;
            database = string.Empty;
            uid = string.Empty;
            password = string.Empty;
            connectionString = string.Empty;

        }

        public void OpenDB()
        {
            try
            {
                server = "localhost";
                database = "db_student";
                uid = "root";
                password= "root";
                connectionString = $"SERVER={this.server};DATABASE={this.database};UID={this.uid};PASSWORD={this.password}";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                //MessageBox.Show("You are now connected to database.");
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CloseDB()
        {
            connection.Close();
        }

        public DataTable ReadStudentRecord(string sql) 
        { 
            OpenDB();
            dataTable = new DataTable();
            command= new MySqlCommand(sql, connection);
            dataTable.Load(command.ExecuteReader());
            CloseDB();
            return dataTable;
            //dataAdapter = new MySqlDataAdapter();
        }
    }
}
