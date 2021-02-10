using MySqlConnector;
using System;

namespace Orders_app
{
    public class MyException : ApplicationException
    {
        public string ShowMessage { get; private set; }
        public MyException()
        {
            ShowMessage = "You haven't entered the order's number, don't leave this field empty.";
        }
    }

    static class Global
    {
        private static int _globalID = -1;

        public static int GlobalVar
        {
            get { return _globalID; }
            set { _globalID = value; }
        }
    }

    class Data_Base
    {
        MySqlConnection connection = new MySqlConnection("server = 5.79.66.145; port = 3306; username	= nikolaypen; password = $-+_/b7Q); database = nikolaypen");
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
