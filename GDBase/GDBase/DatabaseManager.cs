using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDBase
{
    public class DatabaseManager
    {
        private const int NUM_COLUMNS = 3;

        private string _database;
        private string _connectPath;
        private SQLiteConnection _connection;
        private SQLiteCommand _command;

        public DatabaseManager()
        {
            _database = "gdbase.db";
            _connectPath = "Data Source=gdbase.db;Version=3;Compress=true;";

            if(!File.Exists(_database))
                SQLiteConnection.CreateFile(_database);

            createGameTable();
        }

        public void updateInventory(List<A_Component> updates, List<A_Component> removals)
        {
            validateObject(updates);
            foreach (A_Component item in updates)
            {
                validateObject(item);
                add(item.Name, item.System, item.Year);
            }

            foreach (A_Component item in removals)
            {
                validateObject(item);
                remove(item.Name);
            }
        }

        private void add(string name, string system, int year)
        {
            string query = "INSERT OR IGNORE INTO Games (Name, System, Year)"
                + "VALUES (@name, @system, @year);";

            setConnection();
            _connection.Open();
            _command = _connection.CreateCommand();
            _command.CommandText = query;

            _command.Parameters.AddWithValue("@name", name);
            _command.Parameters.AddWithValue("@system", system);
            _command.Parameters.AddWithValue("@year", year);
            
            _command.ExecuteNonQuery();
            _connection.Close();
        }

        private void remove(string name)
        {
            string query = "DELETE FROM Games WHERE Name = \'" + name + "\';";
            executeQuery(query);
        }

        public List<A_Component> queryAllInventory()
        {
            SQLiteDataAdapter dataAdapter;
            DataTable dataTable = new DataTable();
            List<A_Component> inventoryList = new List<A_Component>();

            setConnection();
            _connection.Open();
            _command = new SQLiteCommand("SELECT * FROM Games", _connection);
            dataAdapter = new SQLiteDataAdapter();
            dataAdapter.SelectCommand = _command;
            dataAdapter.Fill(dataTable);
            inventoryList = buildInventory(dataTable);
            _connection.Close();

            return inventoryList;
        }

        private List<A_Component> buildInventory(DataTable dataTable)
        {
            int i;
            Object[] data;
            List<A_Component> list = new List<A_Component>();

            foreach (DataRow row in dataTable.Rows)
            {
                i = 0;
                data = new Object[NUM_COLUMNS];

                foreach (DataColumn col in dataTable.Columns)
                {
                    data[i] = row[col];
                    i++;
                }
                
                list.Add(new Game((string)data[0], (string)data[1],
                    (int)data[2]));
            }

            return list;
        }

        private void setConnection()
        {
            _connection = new SQLiteConnection(_connectPath);
        }
        private void executeQuery(string text)
        {
            setConnection();
            _connection.Open();
            _command = _connection.CreateCommand();
            _command.CommandText = text;
            _command.ExecuteNonQuery();
            _connection.Close();
        }

        private void createGameTable()
        {
            string table = "CREATE TABLE IF NOT EXISTS Games ("
                + "Name VARCHAR(100) PRIMARY KEY NOT NULL,"
                + "System VARCHAR(100) NOT NULL,"
                + "Year INT);";

            executeQuery(table);
        }

        private void validateObject(Object obj)
        {
            if (obj == null)
                throw new NullReferenceException("Database Error: Object from calling method was null.");
        }

    }
}
