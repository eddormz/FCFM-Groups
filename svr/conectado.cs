using System;
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
        public string contrasenia { set; get; }
        public int id { set; get; }

        public conectado() { }
        public conectado(Socket c)
        {
            cliente = c;
            escucharcliente();

        }

        public void escucharcliente() {
            new Thread(() =>
            {
                int readbytes;
                while (true)
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
                                /*
                                
                                */
                            break;

                            case Mensaje.tipo.mensajeprivado:

                            break;

                            case Mensaje.tipo.zumbido:

                            break;

                        }


                    }
                   
                }
            }).Start();


        }
    }
}
