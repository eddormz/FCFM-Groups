﻿namespace FG_v2
{
    partial class tarea
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tarea));
            this.btnaddTarea = new System.Windows.Forms.Button();
            this.flpTarea = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAgregarNueva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreTarea = new System.Windows.Forms.TextBox();
            this.pbGamification = new System.Windows.Forms.ProgressBar();
            this.pnlAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnaddTarea
            // 
            this.btnaddTarea.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnaddTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddTarea.ForeColor = System.Drawing.Color.White;
            this.btnaddTarea.Location = new System.Drawing.Point(20, 3);
            this.btnaddTarea.Name = "btnaddTarea";
            this.btnaddTarea.Size = new System.Drawing.Size(122, 23);
            this.btnaddTarea.TabIndex = 0;
            this.btnaddTarea.Text = "Agregar Tarea";
            this.btnaddTarea.UseVisualStyleBackColor = false;
            this.btnaddTarea.Click += new System.EventHandler(this.btnaddTarea_Click);
            // 
            // flpTarea
            // 
            this.flpTarea.AutoScroll = true;
            this.flpTarea.Location = new System.Drawing.Point(3, 32);
            this.flpTarea.Name = "flpTarea";
            this.flpTarea.Size = new System.Drawing.Size(149, 285);
            this.flpTarea.TabIndex = 1;
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.Transparent;
            this.pnlAdd.Controls.Add(this.btnCancel);
            this.pnlAdd.Controls.Add(this.btnAgregarNueva);
            this.pnlAdd.Controls.Add(this.label1);
            this.pnlAdd.Controls.Add(this.txtNombreTarea);
            this.pnlAdd.Location = new System.Drawing.Point(3, 3);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(149, 342);
            this.pnlAdd.TabIndex = 2;
            this.pnlAdd.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(12, 84);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAgregarNueva
            // 
            this.btnAgregarNueva.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNueva.ForeColor = System.Drawing.Color.White;
            this.btnAgregarNueva.Location = new System.Drawing.Point(12, 55);
            this.btnAgregarNueva.Name = "btnAgregarNueva";
            this.btnAgregarNueva.Size = new System.Drawing.Size(127, 23);
            this.btnAgregarNueva.TabIndex = 2;
            this.btnAgregarNueva.Text = "Agregar Nueva";
            this.btnAgregarNueva.UseVisualStyleBackColor = false;
            this.btnAgregarNueva.Click += new System.EventHandler(this.btnAgregarNueva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de la tarea";
            // 
            // txtNombreTarea
            // 
            this.txtNombreTarea.Location = new System.Drawing.Point(12, 29);
            this.txtNombreTarea.Name = "txtNombreTarea";
            this.txtNombreTarea.Size = new System.Drawing.Size(127, 20);
            this.txtNombreTarea.TabIndex = 0;
            // 
            // pbGamification
            // 
            this.pbGamification.Location = new System.Drawing.Point(6, 323);
            this.pbGamification.Name = "pbGamification";
            this.pbGamification.Size = new System.Drawing.Size(144, 10);
            this.pbGamification.TabIndex = 3;
            // 
            // tarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.pbGamification);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.flpTarea);
            this.Controls.Add(this.btnaddTarea);
            this.Name = "tarea";
            this.Size = new System.Drawing.Size(155, 368);
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnaddTarea;
        private System.Windows.Forms.FlowLayoutPanel flpTarea;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Button btnAgregarNueva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreTarea;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ProgressBar pbGamification;
    }
}
