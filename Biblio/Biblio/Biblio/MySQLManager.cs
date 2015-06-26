using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;

namespace Biblio
{
    public class MySQLManager
    {
        private MySQLRequestBuilder requestbuilder;
        private MySQLClient mysqlclientl;
        private MySqlConnection cnn;
        
        
        public bool Start(){
            //Creation client
            mysqlclientl = new MySQLClient();
            requestbuilder = new MySQLRequestBuilder();
            
            //Connection
            cnn = mysqlclientl.Connect("root", "", "127.0.0.1", "sitemv");

            try
            {
                cnn.Open();
                
                return true;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.Print(e.ToString());
                return false;
            }
            
        }

        public void SeekProductKnow(string parechercher, string produit){
           // mysqlclientl.ExecCommande("SELECT * FROM `user`", cnn, parechercher);
        }

        public void SeekProductUnKnow()
        {
        }

        public void SeekPartialProduct()
        {
        }

        public void CreateNewProduct(string name)
        {
        }

        public void CreateNewTypeOfProduct(string name)
        { 
        }

        public void CreateNewUser()
        {
            //mysqlclientl.ExecCommande("INSERT INTO `sitemv`.`user` (`idUser`, `UserPseudo`, `UserName`, `UserPass`, `UserMail`, `UserInscription`, `UserAvatar`, `UserGroup`) VALUES (NULL, 'test2', 'test2', 'test2', 'test2', '2015-02-13 00:00:00', 'test2', 'test2')",cnn,"");
        }

        public void DeleteProduct()
        {
        }

        public void DeleteTypeOfProduct()
        {
        }

        public void DeleteUser()
        {
        }

        public void NewRent()
        {
        }

        public void ResolveRent()
        {
        }

        public void Exit(Form1 form){
            form.Close();
            mysqlclientl.Close(cnn);
        }
    }
}
