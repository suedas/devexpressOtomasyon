using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace proje_otomasyon
{
    class sqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-MVUUGIE\ZULAL;Initial Catalog=DboOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
        
    }
}
