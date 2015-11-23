using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace baseDatos
{
   public class BDArchivos
    {
        public void agregarArchivo(Archivo archivos)
        {
            POIEntities context = new POIEntities();
            try
            {
                context.Archivoes.Add(archivos);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                //error
            }
        }

        public List<Archivo> getArchivoPublicacion(int idPublicacion)
        {
            POIEntities context = new POIEntities();

            try
            {
                var archivos = from tArchivo in context.Archivoes
                               where tArchivo.idPublicacion == idPublicacion
                               select tArchivo;

                if (archivos.Count() > 0)
                    return archivos.AsEnumerable<Archivo>().ToList();
                else
                    return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public List<Archivo> getArchivoMensaje(int idMensaje)
        {
            POIEntities context = new POIEntities();

            try
            {
                var archivos = from tArchivo in context.Archivoes
                               where tArchivo.idMensaje == idMensaje
                               select tArchivo;

                if (archivos.Count() > 0)
                    return archivos.AsEnumerable<Archivo>().ToList();
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
