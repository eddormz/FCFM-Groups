using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    [Serializable]

    public class Mensaje
    {
        #region datos usuario

        public int iduser { set; get; }
        public int idDestino { set; get; }
        public string nombre { set; get; }
        public string contrasenia { set; get; }
        public IPAddress ip { set; get; }

        #endregion

        #region datos server

        //  List<conectado> lista;

        #endregion

        public string mensaje { set; get; }
        public tipo tipoo;

        public Mensaje() { }

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

        public enum tipo
        {
            login,
            mensaje,
            mensajeprivado,
            zumbido,
            estado
        }
    }
}
