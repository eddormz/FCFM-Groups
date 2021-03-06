﻿using System;
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
    public partial class tarea : UserControl
    {
        int idGrupo;
        int id;
        CheckBox chkTarea = null;
        Socket tareas;
        FlowLayoutPanel flp;


        public tarea(int idGrupo, int id, Socket tareas, FlowLayoutPanel flp)
        {
            InitializeComponent();

            this.id = id;
            this.tareas = tareas;
            this.flp = flp;


            DataSourcePOI dsp = new DataSourcePOI();

            DataTable dt = dsp.getTarea(idGrupo);

            pbGamification.Maximum = dt.Rows.Count;

            if (dt != null)
            {
                for (int bc = 0; bc < dt.Rows.Count; bc++)
                {
                    DataTable dtt = dsp.getTareaAlumno(int.Parse(dt.Rows[bc][0].ToString()), id);

                    chkTarea = new CheckBox();
                    chkTarea.Text = dt.Rows[bc][0].ToString() + ", " + dt.Rows[bc][1].ToString();

                    if (dtt != null)
                    {
                        bool stado = bool.Parse(dtt.Rows[0][1].ToString());
                        chkTarea.Checked = stado;

                        if (stado)
                        {
                            pbGamification.Increment(1);
                        }
                    }
                    chkTarea.AutoSize = true;
                    chkTarea.CheckedChanged += new EventHandler(chkTarea_CheckedChanged);
                    flpTarea.Controls.Add(chkTarea);

                }
            }

            this.idGrupo = idGrupo;
        }

        private void btnaddTarea_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
        }

        private void btnAgregarNueva_Click(object sender, EventArgs e)
        {
            if (txtNombreTarea.Text != "")
            {
                DataSourcePOI dsp = new DataSourcePOI();
                bool agregado = dsp.insertTarea(txtNombreTarea.Text, idGrupo);
                if (agregado)
                    pnlAdd.Visible = false;
                FG fg = new FG();
                fg.tareas(id, idGrupo, tareas, flp);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = false;
        }

        private void chkTarea_CheckedChanged(object sender, EventArgs e)
        {
            chkTarea = (CheckBox)sender;
            bool checado = chkTarea.Checked;
            DataSourcePOI dsp = new DataSourcePOI();


            int status = 0;

            string[] texto = chkTarea.Text.Split(',');

            if (checado)
            {
                status = 1;
                pbGamification.Increment(1);
            }
            else {
                pbGamification.Value--;
            }

            DataTable dtt = dsp.getTareaAlumno(int.Parse(texto[0]), id);
            if (dtt != null)
                dsp.actualizarTarea(status, int.Parse(texto[0]));
            else
                dsp.insertarTareaAlumno(status, int.Parse(texto[0]), id);

        }
    }
}
