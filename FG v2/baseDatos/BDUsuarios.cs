using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace baseDatos
{
    public class BDUsuarios
    {
        public int inicioSesion(String correo, String contra)
        {
            POIEntities context = new POIEntities();
            try
            {
                var idUsuario = from tUsuario in context.Usuarios
                                where tUsuario.correo == correo && tUsuario.contrasenia == contra
                                select tUsuario.idUsuario;

                if (idUsuario.Count() > 0)
                    return idUsuario.First();
                else
                    return 0;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public void agregarUsuario(Usuario usua)
        {
            POIEntities context = new POIEntities();
            try
            {
                context.Usuarios.Add(usua);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
