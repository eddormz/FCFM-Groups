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
                    Data.Mensaje d = new Data.Mensaje(reciveBuffer);


                    switch (d.tipoo)
                    {
                        case Data.Mensaje.tipo.mensaje:


                            foreach (conectado u in Server._server.lista)
                            {
                                u.cliente.Send(d.toBytes());
                            }
                                break;

                        case Data.Mensaje.tipo.mensajeprivado:

                                cliente.Send(d.toBytes());
                               
                            int result = d.idDestino;

                                foreach (conectado u in Server._server.lista)
                            {
                                if (u.id == result)
                                {
                                    u.cliente.Send(d.toBytes());
                                }
                            }
                                break;

                        case Data.Mensaje.tipo.zumbido:

                                if (d.idDestino == 0)
                                {
                                    foreach (conectado u in Server._server.lista)
                                    {
                                        u.cliente.Send(d.toBytes());
                                    }
                                }

                            break;

                        case Data.Mensaje.tipo.estado:

                            estado = d.mensaje;
                            break;

                            case Data.Mensaje.tipo.archivo:

                                if (d.idDestino == 0)
                                {
                                    foreach (conectado u in Server._server.lista)
                                    {
                                        u.cliente.Send(d.toBytes());
                                    }
                                }
                                else
                                {
                                    foreach (conectado u in Server._server.lista)
                                    {
                                        if (d.idDestino == u.id)
                                        {
                                            u.cliente.Send(d.toBytes());
                                        }
                                    }
                                }
                                break;

                            case Data.Mensaje.tipo.cerrar:
                                cliente.Send(d.toBytes());
                                end = true;
                                _server.lista.Remove(this);
                                cliente.Close();
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
