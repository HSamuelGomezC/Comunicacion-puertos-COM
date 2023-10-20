namespace Prueba2
{
    partial class Ventana_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana_Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuracion = new System.Windows.Forms.ToolStripMenuItem();
            this.conexionALaBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNaveSDR = new System.Windows.Forms.Button();
            this.btnNaveA = new System.Windows.Forms.Button();
            this.btnNaveC = new System.Windows.Forms.Button();
            this.btnNaveB = new System.Windows.Forms.Button();
            this.labelHora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracion,
            this.conexionALaBaseDeDatosToolStripMenuItem,
            this.creditosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(353, 24);
            this.menuStrip1.TabIndex = 4;
            // 
            // configuracion
            // 
            this.configuracion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.configuracion.Name = "configuracion";
            this.configuracion.Size = new System.Drawing.Size(95, 20);
            this.configuracion.Text = "Configuración";
            this.configuracion.Click += new System.EventHandler(this.configuracion_Click);
            // 
            // conexionALaBaseDeDatosToolStripMenuItem
            // 
            this.conexionALaBaseDeDatosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.conexionALaBaseDeDatosToolStripMenuItem.Name = "conexionALaBaseDeDatosToolStripMenuItem";
            this.conexionALaBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(167, 20);
            this.conexionALaBaseDeDatosToolStripMenuItem.Text = "Conexión a la Base de Datos";
            this.conexionALaBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.conexionALaBaseDeDatosToolStripMenuItem_Click);
            // 
            // creditosToolStripMenuItem
            // 
            this.creditosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.creditosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.creditosToolStripMenuItem.Name = "creditosToolStripMenuItem";
            this.creditosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.creditosToolStripMenuItem.Text = "Creditos";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.infoToolStripMenuItem.Text = "Información";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // BtnConfiguracion
            // 
            this.BtnConfiguracion.Name = "BtnConfiguracion";
            this.BtnConfiguracion.Size = new System.Drawing.Size(32, 19);
            // 
            // btnNaveSDR
            // 
            this.btnNaveSDR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNaveSDR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNaveSDR.Location = new System.Drawing.Point(189, 363);
            this.btnNaveSDR.Name = "btnNaveSDR";
            this.btnNaveSDR.Size = new System.Drawing.Size(142, 41);
            this.btnNaveSDR.TabIndex = 8;
            this.btnNaveSDR.Text = "SDR";
            this.btnNaveSDR.UseVisualStyleBackColor = false;
            this.btnNaveSDR.Click += new System.EventHandler(this.btnNaveSDR_Click);
            // 
            // btnNaveA
            // 
            this.btnNaveA.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNaveA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNaveA.ForeColor = System.Drawing.Color.Black;
            this.btnNaveA.Location = new System.Drawing.Point(24, 316);
            this.btnNaveA.Name = "btnNaveA";
            this.btnNaveA.Size = new System.Drawing.Size(142, 41);
            this.btnNaveA.TabIndex = 7;
            this.btnNaveA.Text = "Nave A";
            this.btnNaveA.UseVisualStyleBackColor = false;
            this.btnNaveA.Click += new System.EventHandler(this.btnNaveA_Click);
            // 
            // btnNaveC
            // 
            this.btnNaveC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNaveC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNaveC.Location = new System.Drawing.Point(24, 363);
            this.btnNaveC.Name = "btnNaveC";
            this.btnNaveC.Size = new System.Drawing.Size(142, 41);
            this.btnNaveC.TabIndex = 6;
            this.btnNaveC.Text = "Nave C";
            this.btnNaveC.UseVisualStyleBackColor = false;
            this.btnNaveC.Click += new System.EventHandler(this.btnNaveC_Click);
            // 
            // btnNaveB
            // 
            this.btnNaveB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNaveB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNaveB.Location = new System.Drawing.Point(189, 316);
            this.btnNaveB.Name = "btnNaveB";
            this.btnNaveB.Size = new System.Drawing.Size(142, 41);
            this.btnNaveB.TabIndex = 5;
            this.btnNaveB.Text = "Nave B";
            this.btnNaveB.UseVisualStyleBackColor = false;
            this.btnNaveB.Click += new System.EventHandler(this.btnNaveB_Click);
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelHora.Location = new System.Drawing.Point(12, 430);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(0, 13);
            this.labelHora.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "                                                                                 " +
    "       ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-6, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "                                                                                 " +
    "       ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 108);
            this.label3.TabIndex = 13;
            this.label3.Tag = "";
            this.label3.Text = "           ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(-3, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(358, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "                                                                                 " +
    "                                    ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Ventana_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(353, 452);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.btnNaveSDR);
            this.Controls.Add(this.btnNaveA);
            this.Controls.Add(this.btnNaveC);
            this.Controls.Add(this.btnNaveB);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Ventana_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lectura de Puertos COM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BtnConfiguracion;
        private System.Windows.Forms.Button btnNaveSDR;
        private System.Windows.Forms.Button btnNaveA;
        private System.Windows.Forms.Button btnNaveC;
        private System.Windows.Forms.Button btnNaveB;
        private System.Windows.Forms.ToolStripMenuItem configuracion;
        private System.Windows.Forms.ToolStripMenuItem conexionALaBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem creditosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}

