using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;

namespace Biblio
{
    class MySQLClient
    {
        public MySQLClient()
        {
        }

        public MySqlConnection Connect(String user, String mdp, String IP, String dbname)

        {
            MySqlConnection cnn = null ;
            //connectionString = ";
            cnn = new MySqlConnection("SERVER=" + IP + ";" + "UID=" + user + ";" + "PWD=" + mdp + ";" + "DATABASE=" + dbname + ";");
            return cnn;
        }

        public string[] ExecCommande(string pcommand, MySqlConnection cnn, string column){
            MySqlDataReader rdr = null;
            MySqlCommand cmd = new MySqlCommand(pcommand, cnn);
            
            cmd.Connection=cnn;
            cmd.CommandText = pcommand;
            cmd.ExecuteNonQuery();
            rdr = cmd.ExecuteReader();
            string[] retour = null;
            int i = 0;
            while (rdr.Read())
            {
                retour[i]= rdr.GetString(rdr.GetOrdinal(column));
                i++;
            }
            if (rdr != null)
            {
                rdr.Close();
            }
            return retour;
        }

        public void Close(MySqlConnection cnn)
        {
            if(cnn.Ping())cnn.Close();
        }

    }
}
