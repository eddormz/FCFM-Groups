using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace baseDatos
{
    public class BDPublicacion
    {
        public void agregarPublicacion(Publicacion publicaciones)
        {
            POIEntities context = new POIEntities();
            try
            {
                context.Publicacions.Add(publicaciones);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                //error
            }
        }

        public List<Publicacion> getPublicacionGrupo(int idGrupo)
        {
            POIEntities context = new POIEntities();

            try
            {
                var publicaciones = from tPublicacion in context.Publicacions
                               where tPublicacion.idGrupo == idGrupo
                               select tPublicacion;

                if (publicaciones.Count() > 0)
                    return publicaciones.AsEnumerable<Publicacion>().ToList();
                else
                    return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public List<Publicacion> getPublicacionUsuario(int idUsuario)
        {
            POIEntities context = new POIEntities();

            try
            {
                var publicaciones = from tPublicacion in context.Publicacions
                                    where tPublicacion.idUsuario == idUsuario
                                    select tPublicacion;

                if (publicaciones.Count() > 0)
                    return publicaciones.AsEnumerable<Publicacion>().ToList();
                else
                    return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }

    }
}
