using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace FG_v2
{
    public partial class c_subgrupos : UserControl
    {
        int id;
        int idGrupo;
        Socket subgrupos;
        FlowLayoutPanel flp;

        public c_subgrupos(int id, int idGrupo, Socket subgrupos, FlowLayoutPanel flp)
        {
            InitializeComponent();

            this.id = id;
            this.idGrupo = idGrupo;
            this.subgrupos = subgrupos;
            this.flp = flp;

            DataSourcePOI dsp = new DataSourcePOI();
            DataTable dt = dsp.getSubGrupo(id);

            DataTable dtt = dsp.getGrupo(idGrupo);

            if (dtt != null)
                lblGrupo.Text = dtt.Rows[0][0].ToString();

            if (dt != null)
            {
                for (int bc = 0; bc < dt.Rows.Count; bc++)
                {
                    lstSubgrupos.Items.Add(dt.Rows[bc][1].ToString());
                    lstSubgrupos.Items[bc].SubItems.Add(dt.Rows[bc][0].ToString());
                    lstSubgrupos.DoubleClick += new EventHandler(lstSubgrupos_DoubleClick);
                }
            }
        }

        private void lstSubgrupos_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(lstSubgrupos.Items.ToString(), lstSubgrupos.Items[0].SubItems.ToString());
        }

        private void btnAddSubgrupo_Click(object sender, EventArgs e)
        {
            pnlsubgrup.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlsubgrup.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombreSubgrupo.Text != "")
            {
                DataSourcePOI dsp = new DataSourcePOI();

                int idGrupinho = dsp.insertSubgruponom(idGrupo, txtNombreSubgrupo.Text);

                dsp.insertSubGrupo(id, idGrupinho);

                pnlsubgrup.Visible = false;

                FG fg = new FG();
                fg.subrgupos(id, idGrupo, subgrupos, flp);
            }
        }
    }
}
