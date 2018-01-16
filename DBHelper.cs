using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Frm_KY
{
    class DBHelper
    {
        private SqlConnection con;
        public SqlConnection Con {
            get {
                string Sqlcon = "Data Source=.;Initial Catalog=马天鹏;User ID=sa;Pwd=.";
                if (con == null)
                {
                    con = new SqlConnection(Sqlcon);
                }
                return con;
            }
        }
        public void Oper() {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }else if(con.State==ConnectionState.Broken){
                con.Close();
                con.Open();
            }
        }
        public void Close() { 
            if(con.State==ConnectionState.Closed||con.State==ConnectionState.Broken){
                con.Close();
            }
        }
    }
}
