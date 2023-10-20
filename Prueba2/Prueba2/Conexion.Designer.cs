namespace Prueba2
{
    partial class Conexion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textUsuarioBD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtConexion = new System.Windows.Forms.Button();
            this.textContraseñaBD = new System.Windows.Forms.TextBox();
            this.textNombreBD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textUsuarioBD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BtConexion);
            this.groupBox1.Controls.Add(this.textContraseñaBD);
            this.groupBox1.Controls.Add(this.textNombreBD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 270);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // textUsuarioBD
            // 
            this.textUsuarioBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsuarioBD.Location = new System.Drawing.Point(276, 128);
            this.textUsuarioBD.Name = "textUsuarioBD";
            this.textUsuarioBD.Size = new System.Drawing.Size(179, 26);
            this.textUsuarioBD.TabIndex = 16;
            this.textUsuarioBD.TextChanged += new System.EventHandler(this.textUsuarioBD_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(38, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Usuario de la Base de Datos:";
            // 
            // BtConexion
            // 
            this.BtConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtConexion.Location = new System.Drawing.Point(380, 225);
            this.BtConexion.Name = "BtConexion";
            this.BtConexion.Size = new System.Drawing.Size(75, 23);
            this.BtConexion.TabIndex = 14;
            this.BtConexion.Text = "Aceptar";
            this.BtConexion.UseVisualStyleBackColor = true;
            this.BtConexion.Click += new System.EventHandler(this.BtConexion_Click);
            // 
            // textContraseñaBD
            // 
            this.textContraseñaBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContraseñaBD.Location = new System.Drawing.Point(276, 176);
            this.textContraseñaBD.Name = "textContraseñaBD";
            this.textContraseñaBD.Size = new System.Drawing.Size(179, 26);
            this.textContraseñaBD.TabIndex = 13;
            this.textContraseñaBD.UseSystemPasswordChar = true;
            this.textContraseñaBD.TextChanged += new System.EventHandler(this.textContraseñaBD_TextChanged);
            // 
            // textNombreBD
            // 
            this.textNombreBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreBD.Location = new System.Drawing.Point(276, 79);
            this.textNombreBD.Name = "textNombreBD";
            this.textNombreBD.Size = new System.Drawing.Size(179, 26);
            this.textNombreBD.TabIndex = 12;
            this.textNombreBD.TextChanged += new System.EventHandler(this.textNombreBD_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(15, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Contraseña de la Base de Datos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(30, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre de la Base de Datos: ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(107, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Conexión a la Base de Datos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // Conexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 295);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Conexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexion a la Base de Datos";
            this.Load += new System.EventHandler(this.Conexion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textUsuarioBD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtConexion;
        private System.Windows.Forms.TextBox textContraseñaBD;
        private System.Windows.Forms.TextBox textNombreBD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}