using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBA
{
     partial class Bd
    {
        public SqlConnection connection = null;
        
        public void olox()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Voditeli"].ConnectionString);
            connection.Open();
        }
        public void Ololo()
        {
           
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO [Student] (Name,Surname) VALUES(N'Артем',N'Сиглов')", connection);
            Console.WriteLine(sqlCommand.ExecuteNonQuery());
         }   
        
    }
}
