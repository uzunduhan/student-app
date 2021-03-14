using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FACEDELAYER
{
    public class SQLBAGLANTISI
    {
        public static SqlConnection Baglanti = new SqlConnection(@"Data Source=DESKTOP-NJEA2TT\SQLEXPRESS;Initial Catalog=DBTESTKATMAN;Integrated Security=True");
    }
}
