using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class baseDatos
    {
        public SqlConnection conectada;

        public SqlConnection conectarbase()
        {
            try
            {
               conectada = new SqlConnection("Data Source=2ND; Initial Catalog=POI; User Id=sa; Password=sa; Connection Lifetime=60; Max Pool Size=50; Min Pool Size=3");

                //   conectada = new SqlConnection("Data Source=erickterri; Initial Catalog=POI; User Id=sa; Password=terri10dx; Connection Lifetime=60; Max Pool Size=50; Min Pool Size=3");

                //conectada = new SqlConnection("Data Source = brendacazares; Initial Catalog = POI; User Id = sa; Password = 1234; Connection Lifetime = 60; Max Pool Size = 50; Min Pool Size = 3");

                conectada.Open();
            }
            catch (Exception ex)
            { }
            return conectada;
        }

        public void desconectarbase()
        {
            conectada.Close();
        }

    }
}
