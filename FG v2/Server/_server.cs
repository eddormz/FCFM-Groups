using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data;


namespace Server
{
    class _server
    {
        static Socket svr;
        static Socket svr2;
        static IPAddress ip = IPAddress.Any;
        static public List<conectado> lista;
        static public List<Socket> upl;
        static public string final = "no";
        static public bool server = true;

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
            while (final=="no")
            {
                final = Console.ReadLine();
                if (final == "end")
                {
                    end();
                }
            }
            
            Console.WriteLine("END");
        }

        public static void ON()
        {
                Thread.Sleep(10);
                Console.WriteLine("Proceso iniciado");
                int readbytes;


            while (server)
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
                            Data.Mensaje d = new Data.Mensaje(entrando);
                        if (d.tipoo == Data.Mensaje.tipo.login)
                        {
                            string nombre = d.nombre;
                            string contra = d.contrasenia;
                            string ipuser = d.ip.ToString();

                            DataSourcePOIData dspoi = new DataSourcePOIData();

                            DataTable dt = dspoi.iniciarSesion(nombre, contra);

                            int result = int.Parse(dt.Rows[0][0].ToString());
                            int idgroup = int.Parse(dt.Rows[0][1].ToString());

                            if (result > 0)
                            {
                                conectado c = new conectado(cliente);
                                c.nombre = nombre;
                                c.id = result;
                                c.estado = "Conectado";
                                lista.Add(c);

                                d.iduser = result;
                                d.idGrupo = idgroup;

                                cliente.Send(d.toBytes());
                            }

                        }

                        }


                    }
                    catch { }
                }
        }

        public static void up_cl()
        {
            while (server)
            {
                Thread.Sleep(10);
                svr2.Listen(0);
                Socket cliente = svr2.Accept();
                upl.Add(cliente);

            }
        }

        public static void actualizacion()
        {
            while (server)
            {
                Thread.Sleep(1000);

                try {
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
                catch
                {
                    server = false;
                }
            }
        }

        public static void end()
        {
            foreach(conectado i in lista)
            {
                i.end = false;
            }

            
            server = false;
        }
    }
}
