using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.DataAccess
{
    public class DB
    {
       private NpgsqlConnection connection;
            public void Connection()
            {
                connection = new NpgsqlConnection("SERVER = localhost;Port = 5432; DATABASE = ApartmentManagement;   UID = postgres; PWD = 123456");
                connection.Open();
            }

            public void Disconnect()
            {
                connection.Close();
            }

            public NpgsqlDataReader Reader(string query)
            {
                Connection();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                NpgsqlDataReader myReader;
                myReader = command.ExecuteReader();

                return myReader;

            }

            public void ExecuteQuery(string query)
            {
                Connection();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.ExecuteReader();

            }

            public DataTable ListComboBox(string table)
            {
                Connection();
                string query = $"Select * from {table}";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }


            public DataSet ListDatas(string table)
            {
                Connection();
                string query = $"Select * from {table}";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            public DataSet ListDatasQuery(string query)
            {
                Connection();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
    }
}
