using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    [Serializable]
   public class lista_usuarios
    {
        public List<string[]> lista { set; get; }
        public lista_usuarios() { }
        public lista_usuarios(byte[] datosbytes)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream(datosbytes);

            lista_usuarios d = (lista_usuarios)bf.Deserialize(ms);
            this.lista=d.lista;
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
    }
}
