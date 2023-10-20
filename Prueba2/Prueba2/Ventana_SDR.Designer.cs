namespace Prueba2
{
    partial class Ventana_SDR
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
            this.NaveA = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.textBoxHRC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHrGrava3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAditivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textHRArena1 = new System.Windows.Forms.TextBox();
            this.textAgua1 = new System.Windows.Forms.TextBox();
            this.textCemento1 = new System.Windows.Forms.TextBox();
            this.textGrava_3 = new System.Windows.Forms.TextBox();
            this.textGrava_2 = new System.Windows.Forms.TextBox();
            this.textGrava = new System.Windows.Forms.TextBox();
            this.textArena1 = new System.Windows.Forms.TextBox();
            this.textFecha1 = new System.Windows.Forms.TextBox();
            this.textHora1 = new System.Windows.Forms.TextBox();
            this.textLote = new System.Windows.Forms.TextBox();
            this.lbHrArena = new System.Windows.Forms.Label();
            this.lbAgua = new System.Windows.Forms.Label();
            this.lbCemento = new System.Windows.Forms.Label();
            this.lbGrava3 = new System.Windows.Forms.Label();
            this.lbGrava2 = new System.Windows.Forms.Label();
            this.lbGrava1 = new System.Windows.Forms.Label();
            this.lbArena = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.lbLote = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExportar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnFecha = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLote = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxLote = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.NaveA.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // NaveA
            // 
            this.NaveA.Controls.Add(this.tabPage1);
            this.NaveA.Controls.Add(this.tabPage2);
            this.NaveA.Location = new System.Drawing.Point(12, 12);
            this.NaveA.Name = "NaveA";
            this.NaveA.SelectedIndex = 0;
            this.NaveA.Size = new System.Drawing.Size(764, 592);
            this.NaveA.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEnviar);
            this.tabPage1.Controls.Add(this.textBoxHRC);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxHrGrava3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxAditivo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textHRArena1);
            this.tabPage1.Controls.Add(this.textAgua1);
            this.tabPage1.Controls.Add(this.textCemento1);
            this.tabPage1.Controls.Add(this.textGrava_3);
            this.tabPage1.Controls.Add(this.textGrava_2);
            this.tabPage1.Controls.Add(this.textGrava);
            this.tabPage1.Controls.Add(this.textArena1);
            this.tabPage1.Controls.Add(this.textFecha1);
            this.tabPage1.Controls.Add(this.textHora1);
            this.tabPage1.Controls.Add(this.textLote);
            this.tabPage1.Controls.Add(this.lbHrArena);
            this.tabPage1.Controls.Add(this.lbAgua);
            this.tabPage1.Controls.Add(this.lbCemento);
            this.tabPage1.Controls.Add(this.lbGrava3);
            this.tabPage1.Controls.Add(this.lbGrava2);
            this.tabPage1.Controls.Add(this.lbGrava1);
            this.tabPage1.Controls.Add(this.lbArena);
            this.tabPage1.Controls.Add(this.lbFecha);
            this.tabPage1.Controls.Add(this.lbHora);
            this.tabPage1.Controls.Add(this.lbLote);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(756, 566);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ver Datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(278, 527);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(194, 23);
            this.btnEnviar.TabIndex = 27;
            this.btnEnviar.Text = "Enviar Datos a la Base de Datos";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // textBoxHRC
            // 
            this.textBoxHRC.Location = new System.Drawing.Point(392, 492);
            this.textBoxHRC.Name = "textBoxHRC";
            this.textBoxHRC.ReadOnly = true;
            this.textBoxHRC.Size = new System.Drawing.Size(100, 20);
            this.textBoxHRC.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "HRC MEZCLA";
            // 
            // textBoxHrGrava3
            // 
            this.textBoxHrGrava3.Location = new System.Drawing.Point(392, 456);
            this.textBoxHrGrava3.Name = "textBoxHrGrava3";
            this.textBoxHrGrava3.ReadOnly = true;
            this.textBoxHrGrava3.Size = new System.Drawing.Size(100, 20);
            this.textBoxHrGrava3.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "HR GRAVA 3";
            // 
            // textBoxAditivo
            // 
            this.textBoxAditivo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAditivo.Location = new System.Drawing.Point(392, 384);
            this.textBoxAditivo.Name = "textBoxAditivo";
            this.textBoxAditivo.ReadOnly = true;
            this.textBoxAditivo.Size = new System.Drawing.Size(100, 20);
            this.textBoxAditivo.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "ADITIVO";
            // 
            // textHRArena1
            // 
            this.textHRArena1.Location = new System.Drawing.Point(392, 420);
            this.textHRArena1.Name = "textHRArena1";
            this.textHRArena1.ReadOnly = true;
            this.textHRArena1.Size = new System.Drawing.Size(100, 20);
            this.textHRArena1.TabIndex = 20;
            // 
            // textAgua1
            // 
            this.textAgua1.Location = new System.Drawing.Point(392, 348);
            this.textAgua1.Name = "textAgua1";
            this.textAgua1.ReadOnly = true;
            this.textAgua1.Size = new System.Drawing.Size(100, 20);
            this.textAgua1.TabIndex = 19;
            // 
            // textCemento1
            // 
            this.textCemento1.Location = new System.Drawing.Point(392, 312);
            this.textCemento1.Name = "textCemento1";
            this.textCemento1.ReadOnly = true;
            this.textCemento1.Size = new System.Drawing.Size(100, 20);
            this.textCemento1.TabIndex = 18;
            // 
            // textGrava_3
            // 
            this.textGrava_3.Location = new System.Drawing.Point(392, 276);
            this.textGrava_3.Name = "textGrava_3";
            this.textGrava_3.ReadOnly = true;
            this.textGrava_3.Size = new System.Drawing.Size(100, 20);
            this.textGrava_3.TabIndex = 17;
            // 
            // textGrava_2
            // 
            this.textGrava_2.Location = new System.Drawing.Point(392, 240);
            this.textGrava_2.Name = "textGrava_2";
            this.textGrava_2.ReadOnly = true;
            this.textGrava_2.Size = new System.Drawing.Size(100, 20);
            this.textGrava_2.TabIndex = 16;
            // 
            // textGrava
            // 
            this.textGrava.Location = new System.Drawing.Point(392, 204);
            this.textGrava.Name = "textGrava";
            this.textGrava.ReadOnly = true;
            this.textGrava.Size = new System.Drawing.Size(100, 20);
            this.textGrava.TabIndex = 15;
            // 
            // textArena1
            // 
            this.textArena1.Location = new System.Drawing.Point(392, 168);
            this.textArena1.Name = "textArena1";
            this.textArena1.ReadOnly = true;
            this.textArena1.Size = new System.Drawing.Size(100, 20);
            this.textArena1.TabIndex = 14;
            // 
            // textFecha1
            // 
            this.textFecha1.Location = new System.Drawing.Point(392, 132);
            this.textFecha1.Name = "textFecha1";
            this.textFecha1.ReadOnly = true;
            this.textFecha1.Size = new System.Drawing.Size(100, 20);
            this.textFecha1.TabIndex = 13;
            // 
            // textHora1
            // 
            this.textHora1.Location = new System.Drawing.Point(392, 96);
            this.textHora1.Name = "textHora1";
            this.textHora1.ReadOnly = true;
            this.textHora1.Size = new System.Drawing.Size(100, 20);
            this.textHora1.TabIndex = 12;
            // 
            // textLote
            // 
            this.textLote.Location = new System.Drawing.Point(392, 60);
            this.textLote.Name = "textLote";
            this.textLote.ReadOnly = true;
            this.textLote.Size = new System.Drawing.Size(100, 20);
            this.textLote.TabIndex = 11;
            // 
            // lbHrArena
            // 
            this.lbHrArena.AutoSize = true;
            this.lbHrArena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHrArena.Location = new System.Drawing.Point(246, 420);
            this.lbHrArena.Name = "lbHrArena";
            this.lbHrArena.Size = new System.Drawing.Size(93, 20);
            this.lbHrArena.TabIndex = 10;
            this.lbHrArena.Text = "HR ARENA";
            // 
            // lbAgua
            // 
            this.lbAgua.AutoSize = true;
            this.lbAgua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgua.Location = new System.Drawing.Point(283, 348);
            this.lbAgua.Name = "lbAgua";
            this.lbAgua.Size = new System.Drawing.Size(56, 20);
            this.lbAgua.TabIndex = 9;
            this.lbAgua.Text = "AGUA";
            // 
            // lbCemento
            // 
            this.lbCemento.AutoSize = true;
            this.lbCemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCemento.Location = new System.Drawing.Point(252, 312);
            this.lbCemento.Name = "lbCemento";
            this.lbCemento.Size = new System.Drawing.Size(87, 20);
            this.lbCemento.TabIndex = 8;
            this.lbCemento.Text = "CEMENTO";
            // 
            // lbGrava3
            // 
            this.lbGrava3.AutoSize = true;
            this.lbGrava3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrava3.Location = new System.Drawing.Point(263, 276);
            this.lbGrava3.Name = "lbGrava3";
            this.lbGrava3.Size = new System.Drawing.Size(76, 20);
            this.lbGrava3.TabIndex = 7;
            this.lbGrava3.Text = "GRAVA3";
            // 
            // lbGrava2
            // 
            this.lbGrava2.AutoSize = true;
            this.lbGrava2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrava2.Location = new System.Drawing.Point(259, 240);
            this.lbGrava2.Name = "lbGrava2";
            this.lbGrava2.Size = new System.Drawing.Size(80, 20);
            this.lbGrava2.TabIndex = 6;
            this.lbGrava2.Text = "GRAVA 2";
            // 
            // lbGrava1
            // 
            this.lbGrava1.AutoSize = true;
            this.lbGrava1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrava1.Location = new System.Drawing.Point(259, 204);
            this.lbGrava1.Name = "lbGrava1";
            this.lbGrava1.Size = new System.Drawing.Size(80, 20);
            this.lbGrava1.TabIndex = 5;
            this.lbGrava1.Text = "GRAVA 1";
            // 
            // lbArena
            // 
            this.lbArena.AutoSize = true;
            this.lbArena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArena.Location = new System.Drawing.Point(274, 168);
            this.lbArena.Name = "lbArena";
            this.lbArena.Size = new System.Drawing.Size(65, 20);
            this.lbArena.TabIndex = 4;
            this.lbArena.Text = "ARENA";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(275, 132);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(64, 20);
            this.lbFecha.TabIndex = 3;
            this.lbFecha.Text = "FECHA";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(283, 96);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(56, 20);
            this.lbHora.TabIndex = 2;
            this.lbHora.Text = "HORA";
            // 
            // lbLote
            // 
            this.lbLote.AutoSize = true;
            this.lbLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLote.Location = new System.Drawing.Point(289, 60);
            this.lbLote.Name = "lbLote";
            this.lbLote.Size = new System.Drawing.Size(50, 20);
            this.lbLote.TabIndex = 1;
            this.lbLote.Text = "LOTE";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(299, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 31);
            this.label13.TabIndex = 0;
            this.label13.Text = "NAVE SDR";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExportar);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 566);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Base de Datos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(553, 500);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(138, 51);
            this.btnExportar.TabIndex = 26;
            this.btnExportar.Text = "Exportar Tabla a Excel";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(553, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 53);
            this.button1.TabIndex = 25;
            this.button1.Text = "Ver Todos los Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(741, 413);
            this.dataGridView1.TabIndex = 24;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Controls.Add(this.btnFecha);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.textBoxFecha);
            this.groupBox4.Location = new System.Drawing.Point(280, 433);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 118);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(62, 79);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(75, 23);
            this.btnFecha.TabIndex = 7;
            this.btnFecha.Text = "Buscar";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.LightBlue;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(29, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 16);
            this.label15.TabIndex = 6;
            this.label15.Text = "BUSCAR POR FECHA";
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Location = new System.Drawing.Point(32, 53);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.Size = new System.Drawing.Size(140, 20);
            this.textBoxFecha.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.btnLote);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.textBoxLote);
            this.groupBox3.Location = new System.Drawing.Point(32, 433);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 118);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // btnLote
            // 
            this.btnLote.Location = new System.Drawing.Point(60, 79);
            this.btnLote.Name = "btnLote";
            this.btnLote.Size = new System.Drawing.Size(75, 23);
            this.btnLote.TabIndex = 6;
            this.btnLote.Text = "Buscar";
            this.btnLote.UseVisualStyleBackColor = true;
            this.btnLote.Click += new System.EventHandler(this.btnLote_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.LightBlue;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(34, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 16);
            this.label14.TabIndex = 5;
            this.label14.Text = "BUSCAR POR LOTE";
            // 
            // textBoxLote
            // 
            this.textBoxLote.Location = new System.Drawing.Point(31, 53);
            this.textBoxLote.Name = "textBoxLote";
            this.textBoxLote.Size = new System.Drawing.Size(138, 20);
            this.textBoxLote.TabIndex = 4;
            // 
            // Ventana_SDR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 616);
            this.Controls.Add(this.NaveA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Ventana_SDR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana_SDR";
            this.Load += new System.EventHandler(this.Ventana_SDR_Load);
            this.NaveA.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl NaveA;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textHRArena1;
        private System.Windows.Forms.TextBox textAgua1;
        private System.Windows.Forms.TextBox textCemento1;
        private System.Windows.Forms.TextBox textGrava_3;
        private System.Windows.Forms.TextBox textGrava_2;
        private System.Windows.Forms.TextBox textGrava;
        private System.Windows.Forms.TextBox textArena1;
        private System.Windows.Forms.TextBox textFecha1;
        private System.Windows.Forms.TextBox textHora1;
        private System.Windows.Forms.TextBox textLote;
        private System.Windows.Forms.Label lbHrArena;
        private System.Windows.Forms.Label lbAgua;
        private System.Windows.Forms.Label lbCemento;
        private System.Windows.Forms.Label lbGrava3;
        private System.Windows.Forms.Label lbGrava2;
        private System.Windows.Forms.Label lbGrava1;
        private System.Windows.Forms.Label lbArena;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label lbLote;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAditivo;
        private System.Windows.Forms.TextBox textBoxHRC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHrGrava3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLote;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxLote;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}