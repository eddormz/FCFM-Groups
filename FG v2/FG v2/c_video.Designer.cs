namespace FG_v2
{
    partial class c_video
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
            this.vSP = new AForge.Controls.VideoSourcePlayer();
            this.v_cliente = new AForge.Controls.PictureBox();
            this.btn_cerrar = new AForge.Controls.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.v_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // vSP
            // 
            this.vSP.Location = new System.Drawing.Point(631, 359);
            this.vSP.Name = "vSP";
            this.vSP.Size = new System.Drawing.Size(133, 97);
            this.vSP.TabIndex = 0;
            this.vSP.Text = "videoSourcePlayer1";
            this.vSP.VideoSource = null;
            // 
            // v_cliente
            // 
            this.v_cliente.Image = null;
            this.v_cliente.Location = new System.Drawing.Point(36, 26);
            this.v_cliente.Name = "v_cliente";
            this.v_cliente.Size = new System.Drawing.Size(491, 334);
            this.v_cliente.TabIndex = 1;
            this.v_cliente.TabStop = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Image = null;
            this.btn_cerrar.Location = new System.Drawing.Point(739, 3);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(25, 25);
            this.btn_cerrar.TabIndex = 2;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 435);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // c_video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.v_cliente);
            this.Controls.Add(this.vSP);
            this.Name = "c_video";
            this.Size = new System.Drawing.Size(767, 459);
            ((System.ComponentModel.ISupportInitialize)(this.v_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer vSP;
        private AForge.Controls.PictureBox v_cliente;
        private AForge.Controls.PictureBox btn_cerrar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
