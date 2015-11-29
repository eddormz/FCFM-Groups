using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using System.Net.Sockets;

namespace FG_v2
{
    public partial class c_desplegar : UserControl
    {
        public int idpublicacion;
        public int idGrupo;
        public int id;
        public string nombreArchivo;
        public bool isExistsFile = false;
        Socket archivoS;

        public c_desplegar(string nombre,string publicacion,int idpublicacion, int idGrupo, int id, bool isExistsFile, string nombreArchivo, Socket archivoS)
        {
           
            InitializeComponent();
            this.nombre.Text = nombre;
            this.publicacion.Text = publicacion;
            this.idGrupo = idGrupo;
            this.idpublicacion = idpublicacion;
            this.id = id;
            this.isExistsFile = isExistsFile;
            this.nombreArchivo = nombreArchivo;
            lnkNombreArchivo.Text = "Descargar:  "+nombreArchivo;
            lnkNombreArchivo.Visible = isExistsFile;
            this.archivoS = archivoS;
        }

        private void btn_Publicar_Click(object sender, EventArgs e)
        {
            DataSourcePOI dsp = new DataSourcePOI();

            bool resultado = dsp.insertComentario(idpublicacion, input_publicacion.Text, id);

            if (resultado)
            {
                DataTable dt = dsp.getComentario(idpublicacion);

                for (int bc = 0; bc < dt.Rows.Count; bc++)
                {
                    c_desplegar c = new c_desplegar(input_publicacion.Text, publicacion.Text, idpublicacion, idGrupo, id, isExistsFile, nombreArchivo, archivoS);

                }
                input_publicacion.Text = "";
            }
        }

        private void lnkNombreArchivo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            archivo a = new archivo(null, nombreArchivo);
            Mensaje m = new Mensaje();
            m.archi = a;
            m.tipoo = Mensaje.tipo.solicitudArchivo;
            archivoS.Send(m.toBytes());
        }
    }
}
