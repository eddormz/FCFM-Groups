namespace FG_v2
{
    partial class Chat
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
            this.txt_recibido = new System.Windows.Forms.RichTextBox();
            this.txt_enviar = new System.Windows.Forms.RichTextBox();
            this.btn_enviar = new System.Windows.Forms.PictureBox();
            this.btn_emoticon = new System.Windows.Forms.PictureBox();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.btn_video = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_enviar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_emoticon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_video)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_recibido
            // 
            this.txt_recibido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_recibido.Location = new System.Drawing.Point(3, 29);
            this.txt_recibido.Name = "txt_recibido";
            this.txt_recibido.Size = new System.Drawing.Size(278, 207);
            this.txt_recibido.TabIndex = 0;
            this.txt_recibido.Text = "";
            // 
            // txt_enviar
            // 
            this.txt_enviar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_enviar.Location = new System.Drawing.Point(3, 242);
            this.txt_enviar.Name = "txt_enviar";
            this.txt_enviar.Size = new System.Drawing.Size(234, 38);
            this.txt_enviar.TabIndex = 1;
            this.txt_enviar.Text = "";
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(243, 242);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(37, 37);
            this.btn_enviar.TabIndex = 2;
            this.btn_enviar.TabStop = false;
            // 
            // btn_emoticon
            // 
            this.btn_emoticon.Location = new System.Drawing.Point(3, 286);
            this.btn_emoticon.Name = "btn_emoticon";
            this.btn_emoticon.Size = new System.Drawing.Size(25, 25);
            this.btn_emoticon.TabIndex = 3;
            this.btn_emoticon.TabStop = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Image = global::FG_v2.Properties.Resources.Soyuz_TMA_18M_Mission_Patch;
            this.btn_cerrar.Location = new System.Drawing.Point(255, 3);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(25, 25);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_video
            // 
            this.btn_video.Location = new System.Drawing.Point(212, 3);
            this.btn_video.Name = "btn_video";
            this.btn_video.Size = new System.Drawing.Size(25, 25);
            this.btn_video.TabIndex = 5;
            this.btn_video.TabStop = false;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn_video);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_emoticon);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.txt_enviar);
            this.Controls.Add(this.txt_recibido);
            this.Name = "Chat";
            this.Size = new System.Drawing.Size(284, 316);
            ((System.ComponentModel.ISupportInitialize)(this.btn_enviar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_emoticon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_video)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_recibido;
        private System.Windows.Forms.RichTextBox txt_enviar;
        private System.Windows.Forms.PictureBox btn_enviar;
        private System.Windows.Forms.PictureBox btn_emoticon;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private System.Windows.Forms.PictureBox btn_video;
    }
}
