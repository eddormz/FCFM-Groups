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
        static Socket svr2;
        static IPAddress ip = IPAddress.Any;
        static public List<conectado> lista;
        static public List<Socket> upl;

        static void Main(string[] args)
        {
            upl = new List<Socket>();
            Console.WriteLine("Iniciando Servidor");
            svr = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            svr2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            lista = new List<conectado>();
            IPEndPoint ipe = new IPEndPoint(ip, 1806);
            IPEndPoint ipe2 = new IPEndPoint(ip, 1807);
            svr.Bind(ipe);
            svr2.Bind(ipe2);

            Thread escuchar = new Thread(ON);
            escuchar.Start();
            //agregar a lista
            Thread cl = new Thread(up_cl);
            cl.Start();
            //enviarlista
            Thread u = new Thread(actualizacion);
            u.Start();
        }

        public static void ON()
        {

            while (true)
            {
                Thread.Sleep(10);
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
                                    conectado c = new conectado(cliente);
                                    c.nombre = nombre;
                                    c.id = result;
                                    c.estado = "Conectado";
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

        public static void up_cl()
        {
            while (true)
            {
                Thread.Sleep(10);
                svr2.Listen(0);
                Socket cliente = svr2.Accept();
                upl.Add(cliente);

            }
        }

        public static void actualizacion()
        {
            while (true)
            {
                Thread.Sleep(1000);
                List<string[]> sl = new List<string[]>();

                foreach (conectado c in lista)
                {
                    string[] a = new string[3];
                    a[0] = c.estado;
                    a[1] = c.id.ToString();
                    a[2] = c.nombre;
                    sl.Add(a);
                }

                lista_usuarios l = new lista_usuarios();
                l.lista = sl;
                foreach (Socket i in upl)
                {
                    i.Send(l.toBytes());
                }
            }
        }
    }
}
