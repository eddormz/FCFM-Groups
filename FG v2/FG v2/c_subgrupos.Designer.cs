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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 280);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // c_subgrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddSubgrupo);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.lstSubgrupos);
            this.Name = "c_subgrupos";
            this.Size = new System.Drawing.Size(169, 283);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstSubgrupos;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Button btnAddSubgrupo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
