using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsGyumolcs;

namespace tobbform
{

    internal class Database
    {
        static public MySqlCommand command;
        static public MySqlConnection connection;

        public Database(string server = "localhost", string user = "root", string password = "", string db = "gyumolcsok")
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = server;
            builder.UserID = user;
            builder.Password = password;
            builder.Database = db;
            connection = new MySqlConnection(builder.ConnectionString);
            if (Kapcsolatok())
            {
                command = connection.CreateCommand();
            }
        }
        private bool Kapcsolatok()
        {
            try
            {
                connection.Open();
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public List<Gyumolcsok> getAllGyumolcs()
        {
            List<Gyumolcsok> list = new List<Gyumolcsok>();
            command.CommandText = "SELECT * FROM gyumolcsok;";
            connection.Open();
            using (MySqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    Gyumolcsok gyumolcs = new Gyumolcsok(dr.GetInt32("id"), dr.GetString("nev"), dr.GetDouble("egysegar"), dr.GetDouble("mennyiseg"));
                    list.Add(gyumolcs);
                }
            }
            connection.Close();
            return list;
        }
        internal bool updateGyumolcs(Gyumolcsok updateGyumolcs)
        {

            command.CommandText = "UPDATE `gyumolcsok` SET `nev`= @nev,`egysegar`= @egysegar,`mennyiseg`= @mennyiseg WHERE `id`=@id;";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", Program.gyumolcsUpdate.textBox_id.Text);
            command.Parameters.AddWithValue("@nev", Program.gyumolcsUpdate.textBox_nev.Text);
            command.Parameters.AddWithValue("@egysegar", Program.gyumolcsUpdate.numericUpDown_egysegar.Value);
            command.Parameters.AddWithValue("@mennyiseg", Program.gyumolcsUpdate.numericUpDown_mennyiseg.Value);
            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
        internal bool insertGyumolcs(Gyumolcsok insertGyumolcs)
        {
            command.CommandText = "INSERT INTO `gyumolcsok`(`id`, `nev`, `egysegar`, `mennyiseg`) VALUES (null, @nev, @egysegar, @mennyiseg);";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nev", insertGyumolcs.Nev);
            command.Parameters.AddWithValue("@egysegar", insertGyumolcs.Egysegar);
            command.Parameters.AddWithValue("@mennyiseg", insertGyumolcs.Mennyiseg);
            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
        internal bool deleteGyumolcs(Gyumolcsok deleteGyumolcs)
        {

            command.CommandText = "DELETE FROM `gyumolcsok` WHERE `id` = @id;";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", Program.gyumolcsDelete.textBox_id.Text);
            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
    }
}


