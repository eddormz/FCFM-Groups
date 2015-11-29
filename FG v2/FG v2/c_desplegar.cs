using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FG_v2
{
    public partial class c_desplegar : UserControl
    {
        public int idpublicacion;
        public int idGrupo;
        public int id;

        public c_desplegar(string nombre,string publicacion,int idpublicacion, int idGrupo, int id)
        {
           
            InitializeComponent();
            this.nombre.Text = nombre;
            this.publicacion.Text = publicacion;
            this.idGrupo = idGrupo;
            this.idpublicacion = idpublicacion;
            this.id = id;
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
                    c_desplegar c = new c_desplegar("", publicacion.Text, idpublicacion, idGrupo, id);

                }
                input_publicacion.Text = "";
            }
        }
        
    }
}
