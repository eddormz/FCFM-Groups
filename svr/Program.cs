using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using Data;
namespace svr
{
    class Program
    {
        static Socket svr;
        static IPAddress ip = obtenerip();
        static List<conectado> lista;


        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando Servidor");
            svr = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            lista = new List<conectado>();
            IPEndPoint ipe = new IPEndPoint(ip, 1806);
            svr.Bind(ipe);

            Thread escuchar = new Thread(ON);
            escuchar.Start();
            
        }

        public static void ON()
        {
            while (true)
            {
                int readbytes;
                while (true)
                {
                    try
                    {
                        svr.Listen(0);
                        Socket cliente = svr.Accept();
                        byte[] entrando = new byte[cliente.SendBufferSize];

                        readbytes = cliente.Receive(entrando);

                        if (readbytes > 0)
                        {
                            Mensaje d = new Mensaje(entrando);
                            if (d.tipoo == Mensaje.tipo.login)
                            {
                                string nombre = d.nombre;
                                string contra = d.contrasenia;
                                string ipuser = d.ip.ToString();

                                int result = 1;/*result de query*/

                                if (result > 0)
                                {
                                    /*insertar ip query*/

                                    conectado c = new conectado(cliente);
                                    c.nombre = nombre;
                                    c.contrasenia = contra;
                                    c.id = result;
                                    lista.Add(c);

                                    d.iduser = result;

                                    cliente.Send(d.toBytes());
                                }

                            }

                        }


                    }
                    catch { }
                }
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
