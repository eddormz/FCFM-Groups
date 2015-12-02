using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Data;

namespace Data
{
    public class DataSourcePOIData
    {
        public baseDatos datos = new baseDatos();
        public DataTable iniciarSesion(string correo, string contra)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                cmd.Connection = datos.conectarbase();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT idUsuario, idGrupo from Usuario where correo = '" + correo + "' and contrasenia = '" + contra + "'";
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
            catch (Exception e)
            {
                return null;
            }

        }

        public DataTable getUsuarios(int idGrupo)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            cmd.Connection = datos.conectarbase();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT idUsuario FROM Usuario where idGrupo =  " + idGrupo;
            da.SelectCommand = cmd;
            da.Fill(dt);
            datos.desconectarbase();

            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                cmd.Connection = datos.conectarbase();
                cmd.CommandType = CommandType.Text;
                
                cmd.CommandText = "SELECT idUsuario  FROM UsuarioSubGrupo  WHERE idGrupo = " + idGrupo;
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
}
