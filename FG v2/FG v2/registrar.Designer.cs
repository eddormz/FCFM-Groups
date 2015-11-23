namespace FG_v2
{
    partial class registrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registrar));
            this.bt_In = new System.Windows.Forms.Button();
            this.txt_contra = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.Label();
            this.tb_contra = new System.Windows.Forms.TextBox();
            this.tb_correo = new System.Windows.Forms.TextBox();
            this.cb_carrera = new System.Windows.Forms.ComboBox();
            this.tx_carrera = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_In
            // 
            this.bt_In.BackColor = System.Drawing.SystemColors.Control;
            this.bt_In.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_In.Location = new System.Drawing.Point(230, 261);
            this.bt_In.Name = "bt_In";
            this.bt_In.Size = new System.Drawing.Size(87, 27);
            this.bt_In.TabIndex = 9;
            this.bt_In.Text = "Entrar";
            this.bt_In.UseVisualStyleBackColor = false;
            this.bt_In.Click += new System.EventHandler(this.bt_In_Click);
            // 
            // txt_contra
            // 
            this.txt_contra.AutoSize = true;
            this.txt_contra.BackColor = System.Drawing.Color.Transparent;
            this.txt_contra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contra.Location = new System.Drawing.Point(32, 167);
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.Size = new System.Drawing.Size(85, 18);
            this.txt_contra.TabIndex = 8;
            this.txt_contra.Text = "Contraseña";
            // 
            // txt_correo
            // 
            this.txt_correo.AutoSize = true;
            this.txt_correo.BackColor = System.Drawing.Color.Transparent;
            this.txt_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.Location = new System.Drawing.Point(32, 137);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(55, 18);
            this.txt_correo.TabIndex = 7;
            this.txt_correo.Text = "Correo";
            // 
            // tb_contra
            // 
            this.tb_contra.Location = new System.Drawing.Point(123, 164);
            this.tb_contra.Name = "tb_contra";
            this.tb_contra.Size = new System.Drawing.Size(156, 21);
            this.tb_contra.TabIndex = 6;
            // 
            // tb_correo
            // 
            this.tb_correo.Location = new System.Drawing.Point(123, 134);
            this.tb_correo.Name = "tb_correo";
            this.tb_correo.Size = new System.Drawing.Size(156, 21);
            this.tb_correo.TabIndex = 5;
            // 
            // cb_carrera
            // 
            this.cb_carrera.FormattingEnabled = true;
            this.cb_carrera.Location = new System.Drawing.Point(123, 195);
            this.cb_carrera.Name = "cb_carrera";
            this.cb_carrera.Size = new System.Drawing.Size(156, 23);
            this.cb_carrera.TabIndex = 10;
            // 
            // tx_carrera
            // 
            this.tx_carrera.AutoSize = true;
            this.tx_carrera.BackColor = System.Drawing.Color.Transparent;
            this.tx_carrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_carrera.Location = new System.Drawing.Point(32, 200);
            this.tx_carrera.Name = "tx_carrera";
            this.tx_carrera.Size = new System.Drawing.Size(58, 18);
            this.tx_carrera.TabIndex = 11;
            this.tx_carrera.Text = "Carrera";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(331, 301);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tx_carrera);
            this.Controls.Add(this.cb_carrera);
            this.Controls.Add(this.bt_In);
            this.Controls.Add(this.txt_contra);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.tb_contra);
            this.Controls.Add(this.tb_correo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "registrar";
            this.Text = "registrar";
            this.Load += new System.EventHandler(this.registrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_In;
        private System.Windows.Forms.Label txt_contra;
        private System.Windows.Forms.Label txt_correo;
        private System.Windows.Forms.TextBox tb_contra;
        private System.Windows.Forms.TextBox tb_correo;
        private System.Windows.Forms.ComboBox cb_carrera;
        private System.Windows.Forms.Label tx_carrera;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}