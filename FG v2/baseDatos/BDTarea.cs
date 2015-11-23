using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace baseDatos
{
   public class BDTarea
    {
        public void agregarTarea(Tarea tarea)
        {
            POIEntities context = new POIEntities();
            try
            {
                context.Tareas.Add(tarea);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                //error
            }
        }

        public List<Tarea> getTarea(int idGrupo)
        {
            POIEntities context = new POIEntities();

            try
            {
                var tareas = from tTareas in context.Tareas
                               where tTareas.idGrupo == idGrupo
                             select tTareas;

                if (tareas.Count() > 0)
                    return tareas.AsEnumerable<Tarea>().ToList();
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
