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

        public c_desplegar(string nombre,string publicacion,int id)
        {
           
            InitializeComponent();
            this.nombre.Text = nombre;
            this.publicacion.Text = publicacion;
            idpublicacion = id;
        }

        private void btn_Publicar_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
