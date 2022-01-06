using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerUI
{
    class Myconnect
    {
        public SqlConnection con;
        public Myconnect()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
        }
        public static string type;
    }
}
