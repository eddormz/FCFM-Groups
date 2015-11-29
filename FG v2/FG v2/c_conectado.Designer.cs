namespace FG_v2
{
    partial class c_conectado
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_nombreConectado = new System.Windows.Forms.Label();
            this.pb_estatus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_estatus)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombreConectado
            // 
            this.txt_nombreConectado.AutoSize = true;
            this.txt_nombreConectado.Location = new System.Drawing.Point(34, 10);
            this.txt_nombreConectado.Name = "txt_nombreConectado";
            this.txt_nombreConectado.Size = new System.Drawing.Size(44, 13);
            this.txt_nombreConectado.TabIndex = 0;
            this.txt_nombreConectado.Text = "Nombre";
            // 
            // pb_estatus
            // 
            this.pb_estatus.Location = new System.Drawing.Point(3, 3);
            this.pb_estatus.Name = "pb_estatus";
            this.pb_estatus.Size = new System.Drawing.Size(25, 25);
            this.pb_estatus.TabIndex = 1;
            this.pb_estatus.TabStop = false;
            // 
            // c_conectado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb_estatus);
            this.Controls.Add(this.txt_nombreConectado);
            this.Name = "c_conectado";
            this.Size = new System.Drawing.Size(175, 31);
            this.Load += new System.EventHandler(this.conectado_Load);
            this.DoubleClick += new System.EventHandler(this.conectado_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pb_estatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_nombreConectado;
        private System.Windows.Forms.PictureBox pb_estatus;
    }
}
