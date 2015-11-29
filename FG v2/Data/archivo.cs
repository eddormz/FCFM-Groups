using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    [Serializable]

    public class archivo
    {

        FileStream h;
        string j;

        public archivo(FileStream i,string s)
        {
            h = i;
            j = s;
        }

        public void convertirfile()
        {
            if (!Directory.Exists("Descarga\\"))
            {
                Directory.CreateDirectory("Descarga\\");
            }

            FileStream wFile;
            wFile = new FileStream("Descarga\\" + j,FileMode.Append);
            h.CopyTo(wFile);
            wFile.Close();
        }

    }
}
