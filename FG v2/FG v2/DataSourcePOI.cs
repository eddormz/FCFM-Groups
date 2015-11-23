using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Data;

namespace FG_v2
{
    public class DataSourcePOI
    {
        public baseDatos datos = new baseDatos();
   
        public DataTable getGrupos()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            cmd.Connection = datos.conectarbase();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from grupo";
            da.SelectCommand = cmd;
            da.Fill(dt);
            datos.desconectarbase();

            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                return null;
            }
        }

        public bool registrarse(string correo, string contra, int idgrupo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                cmd.Connection = datos.conectarbase();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Usuario(correo,contrasenia,idGrupo)VALUES('" + correo + "', '" + contra + "', " + idgrupo + ")";
                cmd.ExecuteNonQuery();
                datos.desconectarbase();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
