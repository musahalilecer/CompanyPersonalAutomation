using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer1
{
    public class Baglanti
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VICMA4R\\SQLEXPRESS;Initial Catalog=Employees;Integrated Security=True");
    }
}
