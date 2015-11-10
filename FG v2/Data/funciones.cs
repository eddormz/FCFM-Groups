using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public static class funciones
    {
        public static string obtenersvr(string host)

        {

            try

            {

                IPAddress[] ips = Dns.GetHostAddresses(host);

                foreach (IPAddress i in ips)

                {

                    if (i.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)

                    {

                        return i.ToString();

                    }

                }



                return "127.0.0.1";

            }

            catch

            {

                //("Error al tratar de obtener IP de Servidor, Intentelo mas tarde");

                return null;

            }

        }

        public static IPAddress obtenerip()

        {

            try

            {

                IPAddress[] ips = Dns.GetHostAddresses(Dns.GetHostName());

                foreach (IPAddress i in ips)

                {

                    if (i.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)

                    {

                        return i;

                    }

                }

                return IPAddress.Parse("127.0.0.1");

            }

            catch

            {

                //("Error al tratar de obtener IP, Intentelo mas tarde");

                return null;

            }

        }
    }
}
