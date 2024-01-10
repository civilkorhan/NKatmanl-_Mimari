using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Data_Acces_Layer
{
    internal class Baglanti
    {
        public static SqlConnection conn=new SqlConnection(@"Data Source=DESKTOP-Q60UHL2\SQLEXPRESS05;Initial Catalog=DB_PERSONEL;Integrated Security=True;");
            
    }
}
