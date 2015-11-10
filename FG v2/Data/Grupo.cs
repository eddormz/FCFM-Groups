using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class Grupo
    {
        public String nombre;
        public int idpertenencia;

        public Grupo(String nombre, int idpertenencia)
        {
            this.nombre = nombre;
            this.idpertenencia = idpertenencia;
        }
    }
}
