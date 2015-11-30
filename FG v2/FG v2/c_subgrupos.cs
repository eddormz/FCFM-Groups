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
    public partial class c_subgrupos : UserControl
    {
        public c_subgrupos(int id)
        {
            InitializeComponent();
            DataSourcePOI dsp = new DataSourcePOI();
            DataTable dt = dsp.getSubGrupo(id);

            DataTable dtt = dsp.getGrupo(id);

            if (dtt != null)
                lblGrupo.Text = dtt.Rows[0][0].ToString();

            if (dt != null)
            {
                for (int bc = 0; bc < dt.Rows.Count; bc++)
                {
                    lstSubgrupos.Items.Add(dt.Rows[bc][1].ToString());
                }
            }
        }

        private void btnAddSubgrupo_Click(object sender, EventArgs e)
        {

        }
    }
}
