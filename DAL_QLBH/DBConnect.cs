using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBH
{
    public class DBConnect
    {
        //Data Source = DESKTOP - FR6RLCQ\SQLEXPRESS;Initial Catalog = A_DB_SOF205; Integrated Security = True
        //protected SqlConnection _conn = new SqlConnection(@"Data Source=DESKTOP-FR6RLCQ\SQLEXPRESS;Initial Catalog=A_DB_SOF205;User ID=sa;Password=12345678");
        protected SqlConnection _conn = new SqlConnection(@"Data Source=DESKTOP-FR6RLCQ\SQLEXPRESS;Initial Catalog=A_DB_SOF205;Integrated Security=True");
    }
}
