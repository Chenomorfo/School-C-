namespace ClaseListaDobleOrdenada
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNFab = new System.Windows.Forms.TextBox();
            this.txtVelMax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoSerie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtmFechaDeLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.chkCobertura = new System.Windows.Forms.CheckBox();
            this.rdVerB = new System.Windows.Forms.RadioButton();
            this.rdVerA = new System.Windows.Forms.RadioButton();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvMotos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.rdHaciaAtras = new System.Windows.Forms.RadioButton();
            this.rdHaciaAdelante = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Fabricacion";
            // 
            // txtNFab
            // 
            this.txtNFab.Location = new System.Drawing.Point(124, 24);
            this.txtNFab.Name = "txtNFab";
            this.txtNFab.Size = new System.Drawing.Size(121, 23);
            this.txtNFab.TabIndex = 1;
            // 
            // txtVelMax
            // 
            this.txtVelMax.Location = new System.Drawing.Point(124, 53);
            this.txtVelMax.Name = "txtVelMax";
            this.txtVelMax.Size = new System.Drawing.Size(121, 23);
            this.txtVelMax.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Velocidad Max.";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(124, 82);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 23);
            this.txtPrecio.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio";
            // 
            // txtCodigoSerie
            // 
            this.txtCodigoSerie.Location = new System.Drawing.Point(124, 154);
            this.txtCodigoSerie.Name = "txtCodigoSerie";
            this.txtCodigoSerie.Size = new System.Drawing.Size(121, 23);
            this.txtCodigoSerie.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Codigo de serie";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFoto);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.dtmFechaDeLanzamiento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chkCobertura);
            this.groupBox1.Controls.Add(this.rdVerB);
            this.groupBox1.Controls.Add(this.rdVerA);
            this.groupBox1.Controls.Add(this.cbMarca);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodigoSerie);
            this.groupBox1.Controls.Add(this.txtNFab);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtVelMax);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 350);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la motocicleta";
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(394, 278);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(250, 38);
            this.btnFoto.TabIndex = 15;
            this.btnFoto.Text = "Cargar foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(394, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // dtmFechaDeLanzamiento
            // 
            this.dtmFechaDeLanzamiento.Location = new System.Drawing.Point(6, 304);
            this.dtmFechaDeLanzamiento.Name = "dtmFechaDeLanzamiento";
            this.dtmFechaDeLanzamiento.Size = new System.Drawing.Size(200, 23);
            this.dtmFechaDeLanzamiento.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha de lanzamiento";
            // 
            // chkCobertura
            // 
            this.chkCobertura.AutoSize = true;
            this.chkCobertura.Location = new System.Drawing.Point(6, 253);
            this.chkCobertura.Name = "chkCobertura";
            this.chkCobertura.Size = new System.Drawing.Size(202, 19);
            this.chkCobertura.TabIndex = 12;
            this.chkCobertura.Text = "¿Cuenta con cobertura de daños?";
            this.chkCobertura.UseVisualStyleBackColor = true;
            // 
            // rdVerB
            // 
            this.rdVerB.AutoSize = true;
            this.rdVerB.Location = new System.Drawing.Point(119, 217);
            this.rdVerB.Name = "rdVerB";
            this.rdVerB.Size = new System.Drawing.Size(73, 19);
            this.rdVerB.TabIndex = 11;
            this.rdVerB.Text = "Version B";
            this.rdVerB.UseVisualStyleBackColor = true;
            // 
            // rdVerA
            // 
            this.rdVerA.AutoSize = true;
            this.rdVerA.Checked = true;
            this.rdVerA.Location = new System.Drawing.Point(6, 217);
            this.rdVerA.Name = "rdVerA";
            this.rdVerA.Size = new System.Drawing.Size(74, 19);
            this.rdVerA.TabIndex = 10;
            this.rdVerA.TabStop = true;
            this.rdVerA.Text = "Version A";
            this.rdVerA.UseVisualStyleBackColor = true;
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Items.AddRange(new object[] {
            "Harley Davidson",
            "Ducati",
            "BMW",
            "Honda",
            "Aprilia",
            "Yamaha",
            "Kawasaki",
            "Suzuki",
            "Motocicletas Indian",
            "Keeway",
            "KTM",
            "Triumph",
            "Izuka",
            "MV Agusta",
            "Italika",
            "Bajaj",
            "Vento",
            "Vespa",
            "Victoria",
            "AKT",
            "Bajaj",
            "Vento",
            "Vespa",
            "Victoria",
            "AKT"});
            this.cbMarca.Location = new System.Drawing.Point(124, 116);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(121, 23);
            this.cbMarca.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Marca de fabricante";
            // 
            // dgvMotos
            // 
            this.dgvMotos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMotos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvMotos.Location = new System.Drawing.Point(12, 368);
            this.dgvMotos.Name = "dgvMotos";
            this.dgvMotos.ReadOnly = true;
            this.dgvMotos.RowTemplate.Height = 25;
            this.dgvMotos.Size = new System.Drawing.Size(1043, 269);
            this.dgvMotos.TabIndex = 9;
            this.dgvMotos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMotos_CellClick);
            this.dgvMotos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMotos_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N°Fabricacion";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Velocidad Max.";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Marca";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Codigo de serie";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Modelo";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Cuenta con cobertura";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Fecha de lanzamiento";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(668, 18);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 70);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(668, 94);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(125, 70);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(799, 94);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 70);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(799, 18);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(125, 70);
            this.btnVaciar.TabIndex = 12;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(930, 18);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(125, 70);
            this.btnRandom.TabIndex = 14;
            this.btnRandom.Text = "Generar datos aleatorios";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // rdHaciaAtras
            // 
            this.rdHaciaAtras.AutoSize = true;
            this.rdHaciaAtras.Location = new System.Drawing.Point(6, 22);
            this.rdHaciaAtras.Name = "rdHaciaAtras";
            this.rdHaciaAtras.Size = new System.Drawing.Size(137, 19);
            this.rdHaciaAtras.TabIndex = 15;
            this.rdHaciaAtras.Text = "Del ultimo al primero";
            this.rdHaciaAtras.UseVisualStyleBackColor = true;
            this.rdHaciaAtras.CheckedChanged += new System.EventHandler(this.rdHaciaAtras_CheckedChanged);
            // 
            // rdHaciaAdelante
            // 
            this.rdHaciaAdelante.AutoSize = true;
            this.rdHaciaAdelante.Checked = true;
            this.rdHaciaAdelante.Location = new System.Drawing.Point(6, 60);
            this.rdHaciaAdelante.Name = "rdHaciaAdelante";
            this.rdHaciaAdelante.Size = new System.Drawing.Size(137, 19);
            this.rdHaciaAdelante.TabIndex = 16;
            this.rdHaciaAdelante.TabStop = true;
            this.rdHaciaAdelante.Text = "Del primero al ultimo";
            this.rdHaciaAdelante.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdHaciaAtras);
            this.groupBox2.Controls.Add(this.rdHaciaAdelante);
            this.groupBox2.Location = new System.Drawing.Point(668, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 106);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordenar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(907, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Marca de fabricante";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(930, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Precio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 649);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvMotos);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "v";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNFab;
        private TextBox txtVelMax;
        private Label label2;
        private TextBox txtPrecio;
        private Label label3;
        private TextBox txtCodigoSerie;
        private Label label4;
        private GroupBox groupBox1;
        private Button btnFoto;
        private PictureBox pictureBox1;
        private DateTimePicker dtmFechaDeLanzamiento;
        private Label label6;
        private CheckBox chkCobertura;
        private RadioButton rdVerB;
        private RadioButton rdVerA;
        private ComboBox cbMarca;
        private Label label5;
        private DataGridView dgvMotos;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Button btnAgregar;
        private Button btnBuscar;
        private Button btnEliminar;
        private Button btnVaciar;
        private Button btnRandom;
        private RadioButton rdHaciaAtras;
        private RadioButton rdHaciaAdelante;
        private GroupBox groupBox2;
        private Label label7;
        private Label label8;
    }
}