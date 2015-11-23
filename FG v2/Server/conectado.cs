using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Data;

namespace Server
{
    class conectado
    {
        Socket cliente;
        public string nombre { set; get; }
        public int id { set; get; }
        public string estado { set; get; }
        public bool end = false;

        public conectado() { }

        public conectado(Socket c)
        {
            cliente = c;
            Thread escuchar = new Thread(escucharcliente);
            escuchar.Start();

        }

        public void escucharcliente()
        {
            int readbytes;

            while (!end)
            {
                try { 
                Thread.Sleep(10);
                byte[] reciveBuffer = new byte[cliente.SendBufferSize];

                readbytes = cliente.Receive(reciveBuffer);

                if (readbytes > 0)
                {
                    Mensaje d = new Mensaje(reciveBuffer);


                    switch (d.tipoo)
                    {
                        case Mensaje.tipo.mensaje:


                            foreach (conectado u in Server._server.lista)
                            {
                                u.cliente.Send(d.toBytes());
                            }
                            break;

                        case Mensaje.tipo.mensajeprivado:


                            int result = 0; // <-----id destino

                            foreach (conectado u in Server._server.lista)
                            {
                                if (u.id == result)
                                {
                                    u.cliente.Send(d.toBytes());
                                }
                            }

                            break;

                        case Mensaje.tipo.zumbido:

                            break;

                        case Mensaje.tipo.estado:

                            estado = d.mensaje;
                            break;
                        case Mensaje.tipo.video:

                            foreach (conectado u in Server._server.lista)
                            {
                                if (u.id == d.idDestino)
                                {
                                    u.cliente.Send(d.toBytes());
                                }
                            }
                            break;
                    }
                }
                }
                catch
                {
                    end = true;
                }
            }
        }

    }
}
