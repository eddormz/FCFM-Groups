namespace FG_v2
{
    partial class FG
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flp_conectados = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_chats = new System.Windows.Forms.FlowLayoutPanel();
            this.test = new System.Windows.Forms.Button();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.flp_publicacion = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flp_conectados
            // 
            this.flp_conectados.BackColor = System.Drawing.Color.Transparent;
            this.flp_conectados.Location = new System.Drawing.Point(1088, 58);
            this.flp_conectados.Name = "flp_conectados";
            this.flp_conectados.Size = new System.Drawing.Size(129, 638);
            this.flp_conectados.TabIndex = 0;
            // 
            // flp_chats
            // 
            this.flp_chats.BackColor = System.Drawing.Color.Transparent;
            this.flp_chats.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flp_chats.Location = new System.Drawing.Point(179, 379);
            this.flp_chats.Name = "flp_chats";
            this.flp_chats.Size = new System.Drawing.Size(905, 316);
            this.flp_chats.TabIndex = 1;
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(927, 304);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(97, 23);
            this.test.TabIndex = 0;
            this.test.Text = "Boton de Prueba";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // flp_publicacion
            // 
            this.flp_publicacion.Location = new System.Drawing.Point(304, 58);
            this.flp_publicacion.Name = "flp_publicacion";
            this.flp_publicacion.Size = new System.Drawing.Size(596, 638);
            this.flp_publicacion.TabIndex = 2;
            // 
            // FG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1220, 700);
            this.Controls.Add(this.test);
            this.Controls.Add(this.flp_chats);
            this.Controls.Add(this.flp_conectados);
            this.Controls.Add(this.flp_publicacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FG";
            this.Text = "FG";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.FG_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_conectados;
        private System.Windows.Forms.FlowLayoutPanel flp_chats;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.FlowLayoutPanel flp_publicacion;
    }
}