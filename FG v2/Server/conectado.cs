using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Data;
using baseDatos;

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

            //BDPublicacion publi = new BDPublicacion();
            //Publicacion publicaciones = new Publicacion();
            //publicaciones.idUsuario = 1;
            //publicaciones.idGrupo = 1;
            //publicaciones.publicacion1 = "";
            //publi.agregarPublicacion(publicaciones);

            //BDPublicacion publi = new BDPublicacion();
            //int idGrupop = 1;
            //publi.getPublicacionGrupo(idGrupop);

            //BDGrupos grupo = new BDGrupos();
            //int idGrupop = 1;
            //List<Grupo> subgrupos = grupo.obtenerSubGrupos(idGrupop);

            //BDGrupos grupo = new BDGrupos();
            //int idGrupop = 1;
            //Grupo gpo = new Grupo();
            //gpo.idPertenencia = idGrupop;
            //gpo.nombreSubGrupo = "";
            //grupo.addSubgrupo(gpo);

            //BDTarea task = new BDTarea();
            //int idGrupop = 1;
            //task.getTarea(idGrupop);

            BDTarea task = new BDTarea();
            int idGrupop = 1;
            Tarea tarea = new Tarea();
            tarea.idGrupo = idGrupop;
            tarea.status =true;


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

                                BDArchivos archi = new BDArchivos();
                                Archivo archivos = new Archivo();
                                archivos.pathArchivo = "path";
                                archivos.idMensaje = 2;
                                archi.agregarArchivo(archivos);

                                break;

                        case Data.Mensaje.tipo.mensajeprivado:


                            int result = 0; // <-----id destino

                            foreach (conectado u in Server._server.lista)
                            {
                                if (u.id == result)
                                {
                                    u.cliente.Send(d.toBytes());
                                }
                            }

                                BDArchivos archi2 = new BDArchivos();
                                Archivo archivos2 = new Archivo();
                                archivos2.pathArchivo = "path";
                                archivos2.idMensaje = 1;
                                archi2.agregarArchivo(archivos2);

                                break;

                        case Data.Mensaje.tipo.zumbido:

                            break;

                        case Data.Mensaje.tipo.estado:

                            estado = d.mensaje;
                            break;

                        case Data.Mensaje.tipo.registrar:

                                Usuario usua = new Usuario();
                                usua.correo = d.nombre;
                                usua.contrasenia = d.contrasenia;
                                usua.idGrupo = 1;//d.idGrupo;

                                BDUsuarios usuario = new BDUsuarios();
                                usuario.agregarUsuario(usua);

                                break;

                        case Data.Mensaje.tipo.video:

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
