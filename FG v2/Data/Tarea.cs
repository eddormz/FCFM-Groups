using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class Tarea
    {
        public String _tarea;
        public bool status;
        public int idGrupo;

        public Tarea(String tarea, bool status, int idGrupo)
        {
            this._tarea = tarea;
            this.status = status;
            this.idGrupo = idGrupo;
        }
    }
}
