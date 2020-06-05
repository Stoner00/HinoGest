using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace HinoGest
{
    public class Conection
    {
        public void Connect()
        {
            string connectionString = "Data Source=DESKTOP-4OS0TGP\SQLEXPRESS;Initial Catalog=TunaGestDB;Integrated Security=True";
            SqlConnection connection;
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public void NewUser()
        {
            Connect();
            //   String a = Guid.NewGuid().ToString();
            String insert = "insert into table tb_users (userLOGIN, userPASSWD, userNAME, userADDRESS, userPHONE, userBIRTH) values (@userLOGIN, @userPASSWD, @userNAME, @userADRESS, @userPHONE, @userBIRTH) ";
            var command = new SqlCommand(insert, );
        }
        

        



    }
}
