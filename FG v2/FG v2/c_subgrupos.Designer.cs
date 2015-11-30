namespace FG_v2
{
    partial class c_subgrupos
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
            this.lstSubgrupos = new System.Windows.Forms.ListView();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.btnAddSubgrupo = new System.Windows.Forms.Button();
            this.pnlsubgrup = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombreSubgrupo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlsubgrup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSubgrupos
            // 
            this.lstSubgrupos.BackColor = System.Drawing.SystemColors.Window;
            this.lstSubgrupos.BackgroundImage = global::FG_v2.Properties.Resources.fondo1___copia;
            this.lstSubgrupos.Location = new System.Drawing.Point(13, 70);
            this.lstSubgrupos.Name = "lstSubgrupos";
            this.lstSubgrupos.Size = new System.Drawing.Size(153, 210);
            this.lstSubgrupos.TabIndex = 0;
            this.lstSubgrupos.UseCompatibleStateImageBehavior = false;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(3, 42);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(34, 13);
            this.lblGrupo.TabIndex = 1;
            this.lblGrupo.Text = "grupo";
            // 
            // btnAddSubgrupo
            // 
            this.btnAddSubgrupo.Location = new System.Drawing.Point(13, 3);
            this.btnAddSubgrupo.Name = "btnAddSubgrupo";
            this.btnAddSubgrupo.Size = new System.Drawing.Size(140, 23);
            this.btnAddSubgrupo.TabIndex = 2;
            this.btnAddSubgrupo.Text = "Crear SubGrupo";
            this.btnAddSubgrupo.UseVisualStyleBackColor = true;
            this.btnAddSubgrupo.Click += new System.EventHandler(this.btnAddSubgrupo_Click);
            // 
            // pnlsubgrup
            // 
            this.pnlsubgrup.Controls.Add(this.btnCancelar);
            this.pnlsubgrup.Controls.Add(this.btnAgregar);
            this.pnlsubgrup.Controls.Add(this.txtNombreSubgrupo);
            this.pnlsubgrup.Controls.Add(this.label1);
            this.pnlsubgrup.Location = new System.Drawing.Point(0, 0);
            this.pnlsubgrup.Name = "pnlsubgrup";
            this.pnlsubgrup.Size = new System.Drawing.Size(169, 280);
            this.pnlsubgrup.TabIndex = 3;
            this.pnlsubgrup.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(3, 87);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(163, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(3, 58);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(163, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombreSubgrupo
            // 
            this.txtNombreSubgrupo.Location = new System.Drawing.Point(3, 32);
            this.txtNombreSubgrupo.Name = "txtNombreSubgrupo";
            this.txtNombreSubgrupo.Size = new System.Drawing.Size(163, 20);
            this.txtNombreSubgrupo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del SubGrupo";
            // 
            // c_subgrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlsubgrup);
            this.Controls.Add(this.btnAddSubgrupo);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.lstSubgrupos);
            this.Name = "c_subgrupos";
            this.Size = new System.Drawing.Size(169, 283);
            this.pnlsubgrup.ResumeLayout(false);
            this.pnlsubgrup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstSubgrupos;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Button btnAddSubgrupo;
        private System.Windows.Forms.Panel pnlsubgrup;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombreSubgrupo;
        private System.Windows.Forms.Label label1;
    }
}
