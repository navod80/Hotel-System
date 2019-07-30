using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Csharp_Hotel_System
{
    /*This class will make the connection between the app and the mysql database */
    class CONNECT
    {
        private MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Csharp_Hotel_DB");
        /*MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;*/

        //function that return the connection
        public MySqlConnection getConnection()
        {
            return connection;
        }

        // function to open the connection
        public void openConnection()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // function to close the connection
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Close();
            }
        }
/*
        public void searchData(string valueToSearch)
        {
            string query = "SELECT * FROM `clients` WHERE CONCAT(`id`, `first_name`, `last_name`, `phone`, `country`) like '%" + valueToSearch + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);

        }*/
    }
}
