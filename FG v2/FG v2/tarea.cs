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
    public partial class tarea : UserControl
    {
        int idGrupo;
        int id;

        public tarea(int idGrupo, int id)
        {
            InitializeComponent();

            this.id = id;

            DataSourcePOI dsp = new DataSourcePOI();

            DataTable dt = dsp.getSubGrupo(id);

            if(dt!=null)
            for (int bc = 0; bc < dt.Rows.Count; bc++)
            {
                CheckBox chkTarea = new CheckBox();
                chkTarea.Text = dt.Rows[bc][0].ToString() + ", " + dt.Rows[bc][1].ToString();

                flpTarea.Controls.Add(chkTarea);
            }

            this.idGrupo = idGrupo;
        }

        private void btnaddTarea_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
        }

        private void btnAgregarNueva_Click(object sender, EventArgs e)
        {
            DataSourcePOI dsp = new DataSourcePOI();
            bool agregado = dsp.insertTarea(txtNombreTarea.Text, idGrupo);
            if (agregado)
                pnlAdd.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = false;
        }
    }
}
