namespace FG_v2
{
    partial class c_desplegar
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
            this.flp_comentarios = new System.Windows.Forms.FlowLayoutPanel();
            this.nombre = new System.Windows.Forms.Label();
            this.publicacion = new System.Windows.Forms.Label();
            this.input_publicacion = new System.Windows.Forms.RichTextBox();
            this.btn_Publicar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Publicar)).BeginInit();
            this.SuspendLayout();
            // 
            // flp_comentarios
            // 
            this.flp_comentarios.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_comentarios.Location = new System.Drawing.Point(14, 86);
            this.flp_comentarios.Name = "flp_comentarios";
            this.flp_comentarios.Size = new System.Drawing.Size(520, 61);
            this.flp_comentarios.TabIndex = 0;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(11, 17);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(35, 13);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "label1";
            // 
            // publicacion
            // 
            this.publicacion.AutoSize = true;
            this.publicacion.Location = new System.Drawing.Point(27, 30);
            this.publicacion.Name = "publicacion";
            this.publicacion.Size = new System.Drawing.Size(35, 13);
            this.publicacion.TabIndex = 2;
            this.publicacion.Text = "label1";
            // 
            // input_publicacion
            // 
            this.input_publicacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_publicacion.Location = new System.Drawing.Point(14, 56);
            this.input_publicacion.Name = "input_publicacion";
            this.input_publicacion.Size = new System.Drawing.Size(469, 24);
            this.input_publicacion.TabIndex = 3;
            this.input_publicacion.Text = "";
            // 
            // btn_Publicar
            // 
            this.btn_Publicar.Location = new System.Drawing.Point(489, 56);
            this.btn_Publicar.Name = "btn_Publicar";
            this.btn_Publicar.Size = new System.Drawing.Size(59, 24);
            this.btn_Publicar.TabIndex = 4;
            this.btn_Publicar.TabStop = false;
            this.btn_Publicar.Click += new System.EventHandler(this.btn_Publicar_Click);
            // 
            // c_desplegar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Publicar);
            this.Controls.Add(this.input_publicacion);
            this.Controls.Add(this.publicacion);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.flp_comentarios);
            this.Name = "c_desplegar";
            this.Size = new System.Drawing.Size(551, 150);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Publicar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_comentarios;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label publicacion;
        private System.Windows.Forms.RichTextBox input_publicacion;
        private System.Windows.Forms.PictureBox btn_Publicar;
    }
}
