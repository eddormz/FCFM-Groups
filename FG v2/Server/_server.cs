using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class _server
    {
        static Socket svr;
        static IPAddress ip = IPAddress.Any;
        static public List<conectado> lista;

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
                Console.WriteLine("Proceso iniciado");
                int readbytes;
                while (true)
                {
                    try
                    {
                        svr.Listen(0);
                        Socket cliente = svr.Accept();
                        byte[] entrando = new byte[cliente.SendBufferSize];

                        Console.WriteLine("Servidor esperando");
                        readbytes = cliente.Receive(entrando);
                        Console.WriteLine("Cliente conectado");
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
    }
}
