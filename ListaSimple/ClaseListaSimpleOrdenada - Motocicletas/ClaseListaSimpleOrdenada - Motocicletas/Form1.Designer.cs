
namespace ClaseListaSimpleOrdenada___Motocicletas
{
    partial class Form1
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
            this.txtNFab = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVelMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoSerie = new System.Windows.Forms.TextBox();
            this.rdVerA = new System.Windows.Forms.RadioButton();
            this.rdVerB = new System.Windows.Forms.RadioButton();
            this.chkCobertura = new System.Windows.Forms.CheckBox();
            this.dtmFechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.dgvMotos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDatosAleatorios = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNFab
            // 
            this.txtNFab.Location = new System.Drawing.Point(140, 40);
            this.txtNFab.Name = "txtNFab";
            this.txtNFab.Size = new System.Drawing.Size(100, 20);
            this.txtNFab.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "N°Fabricación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Velocidad Max.";
            // 
            // txtVelMax
            // 
            this.txtVelMax.Location = new System.Drawing.Point(140, 76);
            this.txtVelMax.Name = "txtVelMax";
            this.txtVelMax.Size = new System.Drawing.Size(100, 20);
            this.txtVelMax.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(140, 114);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Marca del Fabricante";
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
            this.cbMarca.Location = new System.Drawing.Point(140, 161);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(100, 21);
            this.cbMarca.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Codigo de serie";
            // 
            // txtCodigoSerie
            // 
            this.txtCodigoSerie.Location = new System.Drawing.Point(140, 201);
            this.txtCodigoSerie.Name = "txtCodigoSerie";
            this.txtCodigoSerie.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoSerie.TabIndex = 9;
            // 
            // rdVerA
            // 
            this.rdVerA.AutoSize = true;
            this.rdVerA.Location = new System.Drawing.Point(28, 243);
            this.rdVerA.Name = "rdVerA";
            this.rdVerA.Size = new System.Drawing.Size(70, 17);
            this.rdVerA.TabIndex = 11;
            this.rdVerA.Text = "Version A";
            this.rdVerA.UseVisualStyleBackColor = true;
            // 
            // rdVerB
            // 
            this.rdVerB.AutoSize = true;
            this.rdVerB.Checked = true;
            this.rdVerB.Location = new System.Drawing.Point(155, 243);
            this.rdVerB.Name = "rdVerB";
            this.rdVerB.Size = new System.Drawing.Size(70, 17);
            this.rdVerB.TabIndex = 12;
            this.rdVerB.TabStop = true;
            this.rdVerB.Text = "Version B";
            this.rdVerB.UseVisualStyleBackColor = true;
            // 
            // chkCobertura
            // 
            this.chkCobertura.AutoSize = true;
            this.chkCobertura.Location = new System.Drawing.Point(28, 278);
            this.chkCobertura.Name = "chkCobertura";
            this.chkCobertura.Size = new System.Drawing.Size(188, 17);
            this.chkCobertura.TabIndex = 13;
            this.chkCobertura.Text = "¿Cuenta con cobertura de daños?";
            this.chkCobertura.UseVisualStyleBackColor = true;
            // 
            // dtmFechaLanzamiento
            // 
            this.dtmFechaLanzamiento.Location = new System.Drawing.Point(149, 308);
            this.dtmFechaLanzamiento.Name = "dtmFechaLanzamiento";
            this.dtmFechaLanzamiento.Size = new System.Drawing.Size(200, 20);
            this.dtmFechaLanzamiento.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fecha de Lanzamiento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(377, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(377, 272);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(250, 30);
            this.btnFoto.TabIndex = 17;
            this.btnFoto.Text = "Cargar foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
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
            this.dgvMotos.Location = new System.Drawing.Point(35, 374);
            this.dgvMotos.Name = "dgvMotos";
            this.dgvMotos.ReadOnly = true;
            this.dgvMotos.Size = new System.Drawing.Size(917, 185);
            this.dgvMotos.TabIndex = 18;
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
            this.Column7.HeaderText = "Tipo de transmisión";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNFab);
            this.groupBox1.Controls.Add(this.btnFoto);
            this.groupBox1.Controls.Add(this.txtVelMax);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.dtmFechaLanzamiento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chkCobertura);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rdVerB);
            this.groupBox1.Controls.Add(this.cbMarca);
            this.groupBox1.Controls.Add(this.rdVerA);
            this.groupBox1.Controls.Add(this.txtCodigoSerie);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(35, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 352);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la motocicleta";
            // 
            // btnDatosAleatorios
            // 
            this.btnDatosAleatorios.Location = new System.Drawing.Point(668, 160);
            this.btnDatosAleatorios.Name = "btnDatosAleatorios";
            this.btnDatosAleatorios.Size = new System.Drawing.Size(127, 63);
            this.btnDatosAleatorios.TabIndex = 20;
            this.btnDatosAleatorios.Text = "Generar datos aleatorios";
            this.btnDatosAleatorios.UseVisualStyleBackColor = true;
            this.btnDatosAleatorios.Click += new System.EventHandler(this.btnDatosAleatorios_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(668, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(127, 63);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(801, 19);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(127, 63);
            this.btnVaciar.TabIndex = 22;
            this.btnVaciar.Text = "Vaciar lista";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(801, 88);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(127, 63);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(668, 88);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(127, 63);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 582);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnDatosAleatorios);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMotos);
            this.Name = "Form1";
            this.Text = "Motocicletas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNFab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVelMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigoSerie;
        private System.Windows.Forms.RadioButton rdVerA;
        private System.Windows.Forms.RadioButton rdVerB;
        private System.Windows.Forms.CheckBox chkCobertura;
        private System.Windows.Forms.DateTimePicker dtmFechaLanzamiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.DataGridView dgvMotos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDatosAleatorios;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
    }
}

