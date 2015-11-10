namespace FG_v2
{
    partial class inicio
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
            this.tb_correo = new System.Windows.Forms.TextBox();
            this.tb_contra = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.Label();
            this.txt_contra = new System.Windows.Forms.Label();
            this.bt_In = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_info = new System.Windows.Forms.PictureBox();
            this.btn_Registrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Registrar)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_correo
            // 
            this.tb_correo.Location = new System.Drawing.Point(87, 188);
            this.tb_correo.Name = "tb_correo";
            this.tb_correo.Size = new System.Drawing.Size(134, 20);
            this.tb_correo.TabIndex = 0;
            // 
            // tb_contra
            // 
            this.tb_contra.Location = new System.Drawing.Point(87, 214);
            this.tb_contra.Name = "tb_contra";
            this.tb_contra.Size = new System.Drawing.Size(134, 20);
            this.tb_contra.TabIndex = 1;
            // 
            // txt_correo
            // 
            this.txt_correo.AutoSize = true;
            this.txt_correo.Location = new System.Drawing.Point(46, 191);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(38, 13);
            this.txt_correo.TabIndex = 2;
            this.txt_correo.Text = "Correo";
            // 
            // txt_contra
            // 
            this.txt_contra.AutoSize = true;
            this.txt_contra.Location = new System.Drawing.Point(21, 217);
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.Size = new System.Drawing.Size(63, 13);
            this.txt_contra.TabIndex = 3;
            this.txt_contra.Text = "Contrasenia";
            // 
            // bt_In
            // 
            this.bt_In.Location = new System.Drawing.Point(146, 240);
            this.bt_In.Name = "bt_In";
            this.bt_In.Size = new System.Drawing.Size(75, 23);
            this.bt_In.TabIndex = 4;
            this.bt_In.Text = "Entrar";
            this.bt_In.UseVisualStyleBackColor = true;
            this.bt_In.Click += new System.EventHandler(this.bt_In_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FG_v2.Properties.Resources.FCFM;
            this.pictureBox1.Location = new System.Drawing.Point(72, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_info
            // 
            this.btn_info.Location = new System.Drawing.Point(12, 327);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(30, 30);
            this.btn_info.TabIndex = 6;
            this.btn_info.TabStop = false;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Location = new System.Drawing.Point(215, 327);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(57, 30);
            this.btn_Registrar.TabIndex = 7;
            this.btn_Registrar.TabStop = false;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 369);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_In);
            this.Controls.Add(this.txt_contra);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.tb_contra);
            this.Controls.Add(this.tb_correo);
            this.Name = "inicio";
            this.Text = "inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Registrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_correo;
        private System.Windows.Forms.TextBox tb_contra;
        private System.Windows.Forms.Label txt_correo;
        private System.Windows.Forms.Label txt_contra;
        private System.Windows.Forms.Button bt_In;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btn_info;
        private System.Windows.Forms.PictureBox btn_Registrar;
    }
}