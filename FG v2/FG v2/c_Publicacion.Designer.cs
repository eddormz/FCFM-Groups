﻿namespace FG_v2
{
    partial class c_Publicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(c_Publicacion));
            this.Publicacion = new System.Windows.Forms.RichTextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.btn_addfile = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addfile)).BeginInit();
            this.SuspendLayout();
            // 
            // Publicacion
            // 
            this.Publicacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Publicacion.Location = new System.Drawing.Point(16, 13);
            this.Publicacion.Name = "Publicacion";
            this.Publicacion.Size = new System.Drawing.Size(491, 96);
            this.Publicacion.TabIndex = 0;
            this.Publicacion.Text = "";
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.ForeColor = System.Drawing.Color.White;
            this.btn_enviar.Location = new System.Drawing.Point(432, 115);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(75, 32);
            this.btn_enviar.TabIndex = 1;
            this.btn_enviar.Text = "Publicar";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // btn_addfile
            // 
            this.btn_addfile.BackColor = System.Drawing.Color.Transparent;
            this.btn_addfile.Image = ((System.Drawing.Image)(resources.GetObject("btn_addfile.Image")));
            this.btn_addfile.Location = new System.Drawing.Point(16, 115);
            this.btn_addfile.Name = "btn_addfile";
            this.btn_addfile.Size = new System.Drawing.Size(30, 32);
            this.btn_addfile.TabIndex = 2;
            this.btn_addfile.TabStop = false;
            this.btn_addfile.Click += new System.EventHandler(this.btn_addfile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // c_Publicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn_addfile);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.Publicacion);
            this.Name = "c_Publicacion";
            this.Size = new System.Drawing.Size(525, 150);
            ((System.ComponentModel.ISupportInitialize)(this.btn_addfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Publicacion;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.PictureBox btn_addfile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
