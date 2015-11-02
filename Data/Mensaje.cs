using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
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
            public string nombre = null;
            public string contrasenia = null;
            public IPAddress ip = null;
        
        #endregion

        String mensaje=null;
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
            zumbido
        }
    }
}
