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
