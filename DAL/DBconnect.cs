using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBconnect
    {
        protected SqlConnection _con = new SqlConnection(@"Data Source=DESKTOP-OL9F6HJ\SQLEXPRESS;Initial Catalog=QLdiemdaihocspktHungYen;Integrated Security=True");
        
        
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public void thucthisql(string sql)
        {
            _con.Open();
            cmd = new SqlCommand(sql, _con); 
            cmd.ExecuteReader();
            _con.Close();
        }
       
    }
}
