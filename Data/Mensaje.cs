using System;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Data
{
    [Serializable]

    public class Mensaje
    {
        #region datos usuario

            public int iduser = 0;
            public int idDestino = 0;
            public string nombre = null;
            public string contrasenia = null;
            public IPAddress ip = null;

        #endregion

        #region datos server
       
      //  List<conectado> lista;

        #endregion

        String mensaje =null;
        public tipo tipoo;

        public Mensaje() {}

        public Mensaje(byte[] datosbytes)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream(datosbytes);

            Mensaje d = (Mensaje)bf.Deserialize(ms);

            this.iduser = d.iduser;
            this.nombre = d.nombre;
            this.contrasenia = d.contrasenia;
            this.ip = d.ip;
            this.mensaje = d.mensaje;
            this.tipoo = d.tipoo;

            ms.Close();
        }

        public byte[] toBytes()
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, this);
            byte[] bytes = ms.ToArray();
            ms.Close();
            return bytes;
        }

        public void setid(int id) { iduser = id; }
        public int getip() { return iduser; }
        public void setMsj(String msj) { mensaje = msj; }
        public String getMsj() { return mensaje; }


        public enum tipo
        {
            login,
            mensaje,
            mensajeprivado,
            zumbido,
            estado
        }
    }

    public class Publicacion
    {

        public String pub;
        public int idgrupo;
        public int idusuario;

        public Publicacion(String publicacion, int idGrupo, int idUsuario)
        {
            this.pub= publicacion;
            this.idgrupo = idGrupo;
            this.idusuario = idUsuario;
        }
    }

    public class Tarea
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

    public class Grupo
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
