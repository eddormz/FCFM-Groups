﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Data;
using System.IO;
using System.Data;


namespace Server
{
    class conectado
    {
        public Socket cliente;
        public string nombre { set; get; }
        public int id { set; get; }
        public string estado { set; get; }
        public bool end = false;
        DataSourcePOIData dspd = new DataSourcePOIData();
        DataTable dt;

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

                                #region Mensaje a grupo con espera
                                bool enviado = false;
                                dt = dspd.getUsuarios(d.idGrupo);
                                for (int b = 0; b < dt.Rows.Count-1; b++)
                                {
                                    foreach (conectado u in Server._server.lista)
                                    {
                                        if (int.Parse(dt.Rows[b][0].ToString()) == u.id)
                                        {

                                            u.cliente.Send(d.toBytes());
                                            enviado = true;
                                        }
                                    }
                                
                                    if (!enviado)
                                    {
                                            Thread j = new Thread(()=>esperarmensaje(int.Parse(dt.Rows[b][0].ToString()), d));
                                            j.Start();
                                    }
                                }
                                #endregion

                                break;

                        case Data.Mensaje.tipo.mensajeprivado:

                                #region Mensaje privado
                                cliente.Send(d.toBytes());
                               
                            int result = d.idDestino;

                                foreach (conectado u in Server._server.lista)
                            {
                                if (u.id == result)
                                {
                                    u.cliente.Send(d.toBytes());
                                }
                            }
                                #endregion

                                break;

                        case Data.Mensaje.tipo.zumbido:

                                envio(d);

                            break;

                        case Data.Mensaje.tipo.estado:

                            estado = d.mensaje;
                            break;

                        case Data.Mensaje.tipo.archivo:

                                envio(d);
                                
                                break;

                         case Data.Mensaje.tipo.cerrar:

                                #region Mensaje cerrar
                                    cliente.Send(d.toBytes());
                                    end = true;
                                    _server.lista.Remove(this);
                                    cliente.Disconnect(true);
                                #endregion

                                break;

                         #region publicar archivo

                            case Data.Mensaje.tipo.publicacionarchivo:
                                
                                d.archi.ByteArrayToFile();
                                break;

                            case Data.Mensaje.tipo.solicitudArchivo:

                                byte[] array = File.ReadAllBytes((d.archi.j));


                                archivo a = new archivo(array, d.archi.j);

                                Mensaje m = new Mensaje();
                                m.archi = a;
                                m.tipoo = Mensaje.tipo.solicitudArchivo;

                                cliente.Send(m.toBytes());

                                break;
                                #endregion

                        }
                    }
                }
                catch
                {
                    end = true;
                }
            }


        }

        public void envio(Mensaje d)
        {
            if (d.idDestino == 0)
            {
                dt = dspd.getUsuarios(d.idGrupo);
                for (int b = 0; b < dt.Rows.Count - 1; b++)
                {
                    foreach (conectado u in Server._server.lista)
                    {
                        if (int.Parse(dt.Rows[b][0].ToString()) == u.id)
                        {

                            u.cliente.Send(d.toBytes());
                        }
                    }
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
        }

        public void esperarmensaje(int id,Mensaje d)
        {
            bool enviado = false;
            while (!enviado)
            {
                Thread.Sleep(10);
                foreach(conectado u in Server._server.lista)
                {
                    try {
                        if (u.id == id)
                        {
                            u.cliente.Send(d.toBytes());
                            enviado = true;
                        }
                    }
                    catch
                    {

                    }
                }
            }
        }

    }
}
