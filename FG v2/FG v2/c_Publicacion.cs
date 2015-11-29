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

namespace FG_v2
{
    public partial class c_Publicacion : UserControl
    {
        bool file = false;
        public c_Publicacion()
        {
            InitializeComponent();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            DataSourcePOI dsp = new DataSourcePOI();

            bool resultado = dsp.insertPublicacion(Publicacion.Text, 2, 2);

            if (resultado)
            {
                DataTable dt = dsp.getPublicacion(2);

                for (int bc = 0; bc < dt.Rows.Count; bc++)
                {
                    c_desplegar c = new c_desplegar(dt.Rows[bc][4] + "", dt.Rows[bc][1] + "", 1);

                }

                Publicacion.Text = "";
                Publicacion.Focus();
            }
        }

        private void btn_addfile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}
