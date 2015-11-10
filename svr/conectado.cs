﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Data;
namespace svr
{
    class conectado
    {
        Socket cliente;
        public string nombre { set; get; }
        public int id { set; get; }
        public string estado { set; get; }
        static public bool end = false;

        public conectado() { }

        public conectado(Socket c)
        {
            cliente = c;
            Thread escuchar = new Thread(escucharcliente);
            escuchar.Start();

        }

        public void escucharcliente() {
                int readbytes;

                while (cliente.Connected)
                {
                    Thread.Sleep(10);
                    byte[] reciveBuffer = new byte[cliente.SendBufferSize];

                    readbytes =cliente.Receive(reciveBuffer);

                    if (readbytes > 0)
                    {
                        Mensaje d = new Mensaje(reciveBuffer);


                        switch (d.tipoo)
                        {
                            case Mensaje.tipo.mensaje:
                                
                            
                                foreach(conectado u in svr.Program.lista)
                            {
                                u.cliente.Send(d.toBytes());
                            }
                            break;

                            case Mensaje.tipo.mensajeprivado:


                                int result = 0; // <-----id destino
                            
                                        foreach(conectado u in svr.Program.lista)
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

                            estado = d.getMsj();

                            break;

                        }


                    }
                   
                }
            }

        }
    }