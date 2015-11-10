using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class Publicacion
    {
        public String pub;
        public int idgrupo;
        public int idusuario;

        public Publicacion(String publicacion, int idGrupo, int idUsuario)
        {
            this.pub = publicacion;
            this.idgrupo = idGrupo;
            this.idusuario = idUsuario;
        }
    }
}
