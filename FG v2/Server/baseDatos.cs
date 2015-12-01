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
        public SqlConnection conectada = new SqlConnection();
        public SqlConnection conectarbase()
        {
            try
            {
                  conectada = new SqlConnection("Server=(local); DataBase=POI; Trusted_Connection=True");

                //conectada = new SqlConnection("Data Source=erickterri; Initial Catalog=POI; User Id=sa; Password=terri10dx; Connection Lifetime=60; Max Pool Size=50; Min Pool Size=3");

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
