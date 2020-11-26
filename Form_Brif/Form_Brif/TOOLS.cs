using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Form_Brif
{
    class TOOLS
    {
        //declaration des objets sql
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();

        //declaration de la methode connecter
        public void CONNECTER()
        {
            if(con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                con.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = GestionApprenants; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                con.Open();
            }
        }

        //declaration de la methode deconnecter
        public void DECONNECTER()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
