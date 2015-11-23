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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(c_desplegar));
            this.nombre = new System.Windows.Forms.Label();
            this.publicacion = new System.Windows.Forms.Label();
            this.input_publicacion = new System.Windows.Forms.RichTextBox();
            this.btn_Publicar = new System.Windows.Forms.PictureBox();
            this.flp_comentarios = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Publicar)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.BackColor = System.Drawing.Color.Transparent;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.ForeColor = System.Drawing.Color.White;
            this.nombre.Location = new System.Drawing.Point(3, 12);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(52, 18);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "label1";
            // 
            // publicacion
            // 
            this.publicacion.AutoSize = true;
            this.publicacion.BackColor = System.Drawing.Color.Transparent;
            this.publicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicacion.ForeColor = System.Drawing.Color.White;
            this.publicacion.Location = new System.Drawing.Point(44, 30);
            this.publicacion.Name = "publicacion";
            this.publicacion.Size = new System.Drawing.Size(52, 18);
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
            this.btn_Publicar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Publicar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Publicar.Image")));
            this.btn_Publicar.Location = new System.Drawing.Point(477, 50);
            this.btn_Publicar.Name = "btn_Publicar";
            this.btn_Publicar.Size = new System.Drawing.Size(71, 30);
            this.btn_Publicar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Publicar.TabIndex = 4;
            this.btn_Publicar.TabStop = false;
            this.btn_Publicar.Click += new System.EventHandler(this.btn_Publicar_Click);
            // 
            // flp_comentarios
            // 
            this.flp_comentarios.AutoScroll = true;
            this.flp_comentarios.BackColor = System.Drawing.Color.White;
            this.flp_comentarios.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_comentarios.Location = new System.Drawing.Point(14, 86);
            this.flp_comentarios.Name = "flp_comentarios";
            this.flp_comentarios.Size = new System.Drawing.Size(520, 61);
            this.flp_comentarios.TabIndex = 0;
            this.flp_comentarios.WrapContents = false;
            // 
            // c_desplegar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
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
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label publicacion;
        private System.Windows.Forms.RichTextBox input_publicacion;
        private System.Windows.Forms.PictureBox btn_Publicar;
        public System.Windows.Forms.FlowLayoutPanel flp_comentarios;
    }
}
