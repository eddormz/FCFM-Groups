using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace baseDatos
{
    public class BDGrupos
    {
        public List<Grupo> obtenerGrupos()
        {
            POIEntities context = new POIEntities();

            try
            {
                var grupos = from tGrupo in context.Grupoes
                             select tGrupo;

                if (grupos.Count() > 0)
                    return grupos.AsEnumerable<Grupo>().ToList();
                else
                    return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public List<Grupo> obtenerSubGrupos(int idPertenencia)
        {
            POIEntities context = new POIEntities();

            try
            {
                var grupos = from tGrupo in context.Grupoes
                             where tGrupo.idPertenencia == idPertenencia
                             select tGrupo;

                if (grupos.Count() > 0)
                    return grupos.AsEnumerable<Grupo>().ToList();
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
