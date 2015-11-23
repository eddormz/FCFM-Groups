using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace baseDatos
{
    public class BDMensajes
    {
        public void agregarMensaje(Mensaje mensajes)
        {
            POIEntities context = new POIEntities();
            try
            {
                context.Mensajes.Add(mensajes);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                //error
            }
        }

        public List<Mensaje> getMensaje(int idEnvia, int idRecibe)
        {
            POIEntities context = new POIEntities();

            try
            {
                var mensajes = from tMensaje in context.Mensajes
                               where tMensaje.idEnvia == idEnvia && tMensaje.idRecibe == idRecibe
                               select tMensaje;

                if (mensajes.Count() > 0)
                    return mensajes.AsEnumerable<Mensaje>().ToList();
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
