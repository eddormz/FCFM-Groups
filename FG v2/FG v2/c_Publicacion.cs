using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Data;
using System.Net.Sockets;

namespace FG_v2
{
    public partial class c_Publicacion : UserControl
    {
        bool file = false;
        archivo a;
        int id = 0;
        int idGrupo = 0;
        Socket socketPublicacion;
        FlowLayoutPanel flp;

        public c_Publicacion(int id, int idGrupo, Socket socketnuevo, FlowLayoutPanel flp)
        {
            InitializeComponent();
            this.id = id;
            this.idGrupo = idGrupo;
            this.socketPublicacion = socketnuevo;
            this.flp = flp;
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            if (!file)
            {

                DataSourcePOI dsp = new DataSourcePOI();

                DataTable dtt = dsp.insertPublicacion(Publicacion.Text, idGrupo, id);

                if (dtt.Rows[0][0].ToString() != "null")
                {
                    DataTable dt = dsp.getPublicacion(idGrupo);

                    for (int bc = 0; bc < dt.Rows.Count; bc++)
                    {



                        c_desplegar c = new c_desplegar(dt.Rows[bc][4] + "", dt.Rows[bc][1] + "", int.Parse(dtt.Rows[0][0].ToString()), idGrupo, id, file, dt.Rows[bc][5].ToString(), socketPublicacion);

                    }
                    Publicacion.Text = "";
                    flp.Controls.Clear();
                    FG fg = new FG();
                    fg.publicaciones(id, idGrupo, socketPublicacion, flp);
                }
            }
            else {
                Mensaje mensaje = new Mensaje();
                mensaje.archi = a;
                mensaje.tipoo = Mensaje.tipo.publicacionarchivo;

                DataSourcePOI dsp = new DataSourcePOI();

                DataTable dtt = dsp.insertPublicacionArchivo(Publicacion.Text, idGrupo, id, a.j);

                if (dtt.Rows[0][0].ToString() != "null")
                {
                    DataTable dt = dsp.getPublicacion(idGrupo);

                    for (int bc = 0; bc < dt.Rows.Count; bc++)
                    {
                        c_desplegar c = new c_desplegar(dt.Rows[bc][4] + "", dt.Rows[bc][1] + "", int.Parse(dtt.Rows[0][0].ToString()), idGrupo, id, file, dt.Rows[bc][5].ToString(), socketPublicacion);

                    }
                    Publicacion.Text = "";
                    flp.Controls.Clear();
                    FG fg = new FG();
                    fg.publicaciones(id, idGrupo, socketPublicacion, flp);
                }
                socketPublicacion.Send(mensaje.toBytes());
                file = false;
            }
        }

        private void btn_addfile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                byte[] array = File.ReadAllBytes((openFileDialog1.FileName));


                 a = new archivo(array, openFileDialog1.SafeFileName);
                file = true;
                MessageBox.Show("Archivo esperando ser Publicado");
            }
        }
    }
}
