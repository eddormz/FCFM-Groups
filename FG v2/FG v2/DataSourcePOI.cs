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
        public int iniciarSesion(string correo, string contra)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            cmd.Connection = datos.conectarbase();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT id from Usuario where correo = '" + correo + "', and contrasenia = '" + contra + "')";
            da.SelectCommand = cmd;
            da.Fill(dt);
            datos.desconectarbase();

            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            else
            {
                return 0;
            }

        }

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

    }
}
