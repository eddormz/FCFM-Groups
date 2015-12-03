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
            cmd.CommandText = "select * from grupo where nombreGrupo is not null";
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
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();


                cmd.Connection = datos.conectarbase();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT p.idPublicacion, p.publicacion, p.idGrupo, p.idUsuario, u.correo, p.nombreArchivo FROM Publicacion p inner join usuario u on p.idUsuario = u.idUsuario where p.idGrupo = " + id;
                da.SelectCommand = cmd;
                da.Fill(dt);
                datos.desconectarbase();
            }
            catch (Exception ex)
            {
                return null;
            }

            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                return null;
            }
        }

        public DataTable insertPublicacion(string publicacion, int idGrupo, int idUsuario)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                cmd.Connection = datos.conectarbase();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Publicacion(publicacion,idGrupo,idUsuario, nombreArchivo)VALUES('" + publicacion + "'," + idGrupo + "," + idUsuario + ", null) select SCOPE_IDENTITY()";
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
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable insertPublicacionArchivo(string publicacion, int idGrupo, int idUsuario, string nombreArchivo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                cmd.Connection = datos.conectarbase();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Publicacion(publicacion,idGrupo,idUsuario, nombreArchivo)VALUES('" + publicacion + "'," + idGrupo + "," + idUsuario + ", '" + nombreArchivo + "') select SCOPE_IDENTITY()";
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
            catch (Exception ex)
            {
                return null;
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
                cmd.CommandText = "INSERT INTO Archivo(pathArchivo,idPublicacion,idMensaje) VALUES('" + pathArchivo + "'," + idPublicacion + "," + idMensaje + ")";
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

        public bool insertSubGrupo(int idUsuario, int idGrupo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                cmd.Connection = datos.conectarbase();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO UsuarioSubGrupo(idUsuario,idGrupo) VALUES(" + idUsuario + "," + idGrupo + ")";
                cmd.ExecuteNonQuery();
                datos.desconectarbase();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable getSubGrupo(int id)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            cmd.Connection = datos.conectarbase();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT usg.idGrupo, g.nombreSubGrupo FROM UsuarioSubGrupo usg inner join Usuario u on usg.idUsuario = u.idUsuario LEFT join Grupo g on g.idGrupo = usg.idGrupo where u.idUsuario = " + id;
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


        public DataTable getGrupo(int id)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            cmd.Connection = datos.conectarbase();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT nombreGrupo FROM Grupo where idGrupo = " + id;
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

        public bool insertTarea(string tarea, int idGrupo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                cmd.Connection = datos.conectarbase();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Tarea(tarea,idGrupo) VALUES ('" + tarea + "', " + idGrupo + ")";
                cmd.ExecuteNonQuery();
                datos.desconectarbase();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void actualizarTarea(int status, int idTarea)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                cmd.Connection = datos.conectarbase();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE tareaAlumno set Status = " + status + " WHERE idTarea = " + idTarea;
                cmd.ExecuteNonQuery();
                datos.desconectarbase();
            }
            catch (Exception ex)
            {
            }
        }
        public void insertarTareaAlumno(int status, int idTarea, int idUsuario)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                cmd.Connection = datos.conectarbase();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO tareaAlumno (idTarea,idUsuario,Status) VALUES (" + idTarea + " , " + idUsuario + ", " + status + ")";
                cmd.ExecuteNonQuery();
                datos.desconectarbase();
            }
            catch (Exception ex)
            {
            }
        }

        public DataTable getTarea(int id)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            cmd.Connection = datos.conectarbase();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT idTarea,tarea,idGrupo FROM Tarea where idGrupo = " + id;
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

        public DataTable getTareaAlumno(int idTarea, int idUsuario)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            cmd.Connection = datos.conectarbase();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT idTarea,Status FROM tareaAlumno where idUsuario = " + idUsuario + " and idTarea = " + idTarea;
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

        public bool insertComentario(int idPublicacion, string comentario, int idUsuario)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                cmd.Connection = datos.conectarbase();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Comentario(idPublicacion,comentario,idUsuario) VALUES (" + idPublicacion + ", '" + comentario + "', " + idUsuario + " )";
                cmd.ExecuteNonQuery();
                datos.desconectarbase();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable getComentario(int id)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            cmd.Connection = datos.conectarbase();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT c.comentario, c.idPublicacion FROM Comentario c inner join Publicacion p on c.idPublicacion = p.idPublicacion inner join Usuario u on c.idUsuario = u.idUsuario where c.idPublicacion = " + id;
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

        public int insertSubgruponom(int idGrupo, string nombreSubgrupo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                cmd.Connection = datos.conectarbase();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Grupo (nombreSubGrupo,idPertenencia) VALUES('" + nombreSubgrupo + "', " + idGrupo + ") select SCOPE_IDENTITY()";
                da.SelectCommand = cmd;
                da.Fill(dt);
                datos.desconectarbase();
                if (dt.Rows.Count > 0)
                {
                    return int.Parse(dt.Rows[0][0].ToString());
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public DataTable getnotmygroups(int idUsuario)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            cmd.Connection = datos.conectarbase();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT idGrupo,nombreGrupo,nombreSubGrupo,idPertenencia FROM Grupo where idPertenencia is not null and idGrupo not in (SELECT idGrupo FROM UsuarioSubGrupo where idUsuario = " + idUsuario + ")";
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

        public DataTable getUsuariosMail(int idGrupo, int id)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            cmd.Connection = datos.conectarbase();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select correo from Usuario where idGrupo = " + idGrupo + " and idUsuario <> " + id;
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