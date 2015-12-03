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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FG));
            this.flp_conectados = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_chats = new System.Windows.Forms.FlowLayoutPanel();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.flp_publicacion = new System.Windows.Forms.FlowLayoutPanel();
            this.test = new System.Windows.Forms.Button();
            this.rb_conectado = new System.Windows.Forms.RadioButton();
            this.rb_ausente = new System.Windows.Forms.RadioButton();
            this.rb_desconectado = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCorreo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flp_conectados
            // 
            this.flp_conectados.BackColor = System.Drawing.Color.Transparent;
            this.flp_conectados.Location = new System.Drawing.Point(1088, 87);
            this.flp_conectados.Name = "flp_conectados";
            this.flp_conectados.Size = new System.Drawing.Size(129, 609);
            this.flp_conectados.TabIndex = 0;
            // 
            // flp_chats
            // 
            this.flp_chats.BackColor = System.Drawing.Color.Transparent;
            this.flp_chats.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flp_chats.Location = new System.Drawing.Point(177, 380);
            this.flp_chats.Name = "flp_chats";
            this.flp_chats.Size = new System.Drawing.Size(905, 316);
            this.flp_chats.TabIndex = 1;
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // flp_publicacion
            // 
            this.flp_publicacion.AutoScroll = true;
            this.flp_publicacion.BackColor = System.Drawing.Color.Transparent;
            this.flp_publicacion.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_publicacion.Location = new System.Drawing.Point(383, 58);
            this.flp_publicacion.Name = "flp_publicacion";
            this.flp_publicacion.Size = new System.Drawing.Size(585, 638);
            this.flp_publicacion.TabIndex = 2;
            this.flp_publicacion.WrapContents = false;
            // 
            // test
            // 
            this.test.BackColor = System.Drawing.Color.DodgerBlue;
            this.test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.test.ForeColor = System.Drawing.Color.White;
            this.test.Location = new System.Drawing.Point(1088, 58);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(126, 23);
            this.test.TabIndex = 0;
            this.test.Text = "Chat Grupal";
            this.test.UseVisualStyleBackColor = false;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // rb_conectado
            // 
            this.rb_conectado.AutoSize = true;
            this.rb_conectado.BackColor = System.Drawing.Color.Transparent;
            this.rb_conectado.Checked = true;
            this.rb_conectado.ForeColor = System.Drawing.Color.White;
            this.rb_conectado.Location = new System.Drawing.Point(1088, 1);
            this.rb_conectado.Name = "rb_conectado";
            this.rb_conectado.Size = new System.Drawing.Size(77, 17);
            this.rb_conectado.TabIndex = 5;
            this.rb_conectado.TabStop = true;
            this.rb_conectado.Text = "Conectado";
            this.rb_conectado.UseVisualStyleBackColor = false;
            this.rb_conectado.CheckedChanged += new System.EventHandler(this.rb_conectado_CheckedChanged);
            // 
            // rb_ausente
            // 
            this.rb_ausente.AutoSize = true;
            this.rb_ausente.BackColor = System.Drawing.Color.Transparent;
            this.rb_ausente.ForeColor = System.Drawing.Color.White;
            this.rb_ausente.Location = new System.Drawing.Point(1088, 16);
            this.rb_ausente.Name = "rb_ausente";
            this.rb_ausente.Size = new System.Drawing.Size(64, 17);
            this.rb_ausente.TabIndex = 6;
            this.rb_ausente.Text = "Ausente";
            this.rb_ausente.UseVisualStyleBackColor = false;
            this.rb_ausente.CheckedChanged += new System.EventHandler(this.rb_ausente_CheckedChanged);
            // 
            // rb_desconectado
            // 
            this.rb_desconectado.AutoSize = true;
            this.rb_desconectado.BackColor = System.Drawing.Color.Transparent;
            this.rb_desconectado.ForeColor = System.Drawing.Color.White;
            this.rb_desconectado.Location = new System.Drawing.Point(1088, 30);
            this.rb_desconectado.Name = "rb_desconectado";
            this.rb_desconectado.Size = new System.Drawing.Size(95, 17);
            this.rb_desconectado.TabIndex = 7;
            this.rb_desconectado.Text = "Desconectado";
            this.rb_desconectado.UseVisualStyleBackColor = false;
            this.rb_desconectado.CheckedChanged += new System.EventHandler(this.rb_desconectado_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(186, 338);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1, 358);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(170, 338);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(193, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnCorreo
            // 
            this.btnCorreo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorreo.ForeColor = System.Drawing.Color.White;
            this.btnCorreo.Location = new System.Drawing.Point(988, 58);
            this.btnCorreo.Name = "btnCorreo";
            this.btnCorreo.Size = new System.Drawing.Size(94, 23);
            this.btnCorreo.TabIndex = 11;
            this.btnCorreo.Text = "Enviar Correo";
            this.btnCorreo.UseVisualStyleBackColor = false;
            this.btnCorreo.Click += new System.EventHandler(this.btnCorreo_Click);
            // 
            // FG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1220, 700);
            this.Controls.Add(this.btnCorreo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.test);
            this.Controls.Add(this.flp_conectados);
            this.Controls.Add(this.rb_desconectado);
            this.Controls.Add(this.rb_ausente);
            this.Controls.Add(this.rb_conectado);
            this.Controls.Add(this.flp_chats);
            this.Controls.Add(this.flp_publicacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FG";
            this.Text = "FG";
            this.TransparencyKey = System.Drawing.SystemColors.WindowText;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FG_FormClosed);
            this.Load += new System.EventHandler(this.FG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_conectados;
        private System.Windows.Forms.FlowLayoutPanel flp_chats;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.FlowLayoutPanel flp_publicacion;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.RadioButton rb_conectado;
        private System.Windows.Forms.RadioButton rb_ausente;
        private System.Windows.Forms.RadioButton rb_desconectado;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCorreo;
    }
}