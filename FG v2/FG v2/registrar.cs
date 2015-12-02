using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using Data;

namespace FG_v2
{
    public partial class registrar : Form
    {
        public registrar()
        {
            InitializeComponent();
        }

        private void bt_In_Click(object sender, EventArgs e)
        {
            if (tb_correo.Text!=""&&tb_contra.Text!="") { }
            DataSourcePOI dspoi = new DataSourcePOI();
           bool result = dspoi.registrarse(tb_correo.Text, tb_contra.Text, Convert.ToInt32(cb_carrera.SelectedValue));
            if (result)
            {
                MessageBox.Show("Registro Exitoso", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Registro Fallido", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void registrar_Load(object sender, EventArgs e)
        {
            DataSourcePOI dspoi = new DataSourcePOI();

            cb_carrera.DisplayMember = "nombreGrupo";
            cb_carrera.ValueMember = "idGrupo";
            cb_carrera.DataSource = dspoi.getGrupos();

        }
    }
}
