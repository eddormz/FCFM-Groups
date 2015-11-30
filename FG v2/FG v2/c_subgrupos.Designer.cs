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
            this.SuspendLayout();
            // 
            // lstSubgrupos
            // 
            this.lstSubgrupos.Location = new System.Drawing.Point(13, 36);
            this.lstSubgrupos.Name = "lstSubgrupos";
            this.lstSubgrupos.Size = new System.Drawing.Size(153, 244);
            this.lstSubgrupos.TabIndex = 0;
            this.lstSubgrupos.UseCompatibleStateImageBehavior = false;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(13, 17);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(34, 13);
            this.lblGrupo.TabIndex = 1;
            this.lblGrupo.Text = "grupo";
            // 
            // c_subgrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.lstSubgrupos);
            this.Name = "c_subgrupos";
            this.Size = new System.Drawing.Size(169, 283);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstSubgrupos;
        private System.Windows.Forms.Label lblGrupo;
    }
}
