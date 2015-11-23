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
            this.bt_In = new System.Windows.Forms.Button();
            this.txt_contra = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.Label();
            this.tb_contra = new System.Windows.Forms.TextBox();
            this.tb_correo = new System.Windows.Forms.TextBox();
            this.cb_carrera = new System.Windows.Forms.ComboBox();
            this.tx_carrera = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_In
            // 
            this.bt_In.Location = new System.Drawing.Point(197, 226);
            this.bt_In.Name = "bt_In";
            this.bt_In.Size = new System.Drawing.Size(75, 23);
            this.bt_In.TabIndex = 9;
            this.bt_In.Text = "Entrar";
            this.bt_In.UseVisualStyleBackColor = true;
            this.bt_In.Click += new System.EventHandler(this.bt_In_Click);
            // 
            // txt_contra
            // 
            this.txt_contra.AutoSize = true;
            this.txt_contra.Location = new System.Drawing.Point(9, 135);
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.Size = new System.Drawing.Size(63, 13);
            this.txt_contra.TabIndex = 8;
            this.txt_contra.Text = "Contrasenia";
            // 
            // txt_correo
            // 
            this.txt_correo.AutoSize = true;
            this.txt_correo.Location = new System.Drawing.Point(34, 109);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(38, 13);
            this.txt_correo.TabIndex = 7;
            this.txt_correo.Text = "Correo";
            // 
            // tb_contra
            // 
            this.tb_contra.Location = new System.Drawing.Point(75, 132);
            this.tb_contra.Name = "tb_contra";
            this.tb_contra.Size = new System.Drawing.Size(134, 20);
            this.tb_contra.TabIndex = 6;
            // 
            // tb_correo
            // 
            this.tb_correo.Location = new System.Drawing.Point(75, 106);
            this.tb_correo.Name = "tb_correo";
            this.tb_correo.Size = new System.Drawing.Size(134, 20);
            this.tb_correo.TabIndex = 5;
            // 
            // cb_carrera
            // 
            this.cb_carrera.FormattingEnabled = true;
            this.cb_carrera.Location = new System.Drawing.Point(75, 159);
            this.cb_carrera.Name = "cb_carrera";
            this.cb_carrera.Size = new System.Drawing.Size(134, 21);
            this.cb_carrera.TabIndex = 10;
            // 
            // tx_carrera
            // 
            this.tx_carrera.AutoSize = true;
            this.tx_carrera.Location = new System.Drawing.Point(9, 162);
            this.tx_carrera.Name = "tx_carrera";
            this.tx_carrera.Size = new System.Drawing.Size(41, 13);
            this.tx_carrera.TabIndex = 11;
            this.tx_carrera.Text = "Carrera";
            // 
            // registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tx_carrera);
            this.Controls.Add(this.cb_carrera);
            this.Controls.Add(this.bt_In);
            this.Controls.Add(this.txt_contra);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.tb_contra);
            this.Controls.Add(this.tb_correo);
            this.Name = "registrar";
            this.Text = "registrar";
            this.Load += new System.EventHandler(this.registrar_Load);
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
    }
}