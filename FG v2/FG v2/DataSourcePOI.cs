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

        public DataTable getPublicacion(int id)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            cmd.Connection = datos.conectarbase();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT idPublicacion, publicacion, idGrupo, idUsuario FROM Publicacion where idGrupo = " + id;
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

        public bool insertPublicacion(string publicacion, int idGrupo, int idUsuario)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                cmd.Connection = datos.conectarbase();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Publicacion(publicacion,idGrupo,idUsuario)VALUES('"+ publicacion +"',"+ idGrupo +","+ idUsuario +")";
                cmd.ExecuteNonQuery();
                datos.desconectarbase();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool insertArchivo(string pathArchivo, int idPublicacion, int idMensaje)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                cmd.Connection = datos.conectarbase();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Archivo(pathArchivo,idPublicacion,idMensaje) VALUES('"+ pathArchivo +"',"+ idPublicacion +","+ idMensaje + ")";
                cmd.ExecuteNonQuery();
                datos.desconectarbase();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable getArchivosPubli(int id)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            cmd.Connection = datos.conectarbase();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT idArchivo,pathArchivo,idPublicacion,idMensaje FROM Archivo where idPublicacion = " + id;
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


        public DataTable getArchivosGrupo(int id)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            cmd.Connection = datos.conectarbase();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT idArchivo,pathArchivo,idPublicacion,idMensaje FROM Archivo where idMensaje = " + id;
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
