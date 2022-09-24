
namespace ClaseListaColaDesordenada
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
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEncolar = new System.Windows.Forms.Button();
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnFoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtmFechaDeLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.chkCobertura = new System.Windows.Forms.CheckBox();
            this.rdVerB = new System.Windows.Forms.RadioButton();
            this.rdVerA = new System.Windows.Forms.RadioButton();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoSerie = new System.Windows.Forms.TextBox();
            this.txtNFab = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtVelMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminarEspecifico = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(799, 18);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(107, 61);
            this.btnRandom.TabIndex = 41;
            this.btnRandom.Text = "Generar datos aleatorios";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(688, 85);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 61);
            this.btnEliminar.TabIndex = 40;
            this.btnEliminar.Text = "Desencolar Frente";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(687, 18);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(107, 61);
            this.btnVaciar.TabIndex = 39;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(575, 84);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 61);
            this.btnBuscar.TabIndex = 38;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEncolar
            // 
            this.btnEncolar.Location = new System.Drawing.Point(575, 16);
            this.btnEncolar.Name = "btnEncolar";
            this.btnEncolar.Size = new System.Drawing.Size(107, 61);
            this.btnEncolar.TabIndex = 37;
            this.btnEncolar.Text = "Encolar";
            this.btnEncolar.UseVisualStyleBackColor = true;
            this.btnEncolar.Click += new System.EventHandler(this.btnPush_Click);
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
            this.dgvMotos.Location = new System.Drawing.Point(6, 15);
            this.dgvMotos.Name = "dgvMotos";
            this.dgvMotos.ReadOnly = true;
            this.dgvMotos.RowTemplate.Height = 25;
            this.dgvMotos.Size = new System.Drawing.Size(894, 233);
            this.dgvMotos.TabIndex = 36;
            this.dgvMotos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMotos_CellClick);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
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
            this.groupBox1.Size = new System.Drawing.Size(557, 303);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la motocicleta";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(338, 130);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(213, 23);
            this.progressBar1.TabIndex = 16;
            this.progressBar1.Visible = false;
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(338, 241);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(214, 33);
            this.btnFoto.TabIndex = 15;
            this.btnFoto.Text = "Cargar foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(338, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBox1_LoadCompleted);
            this.pictureBox1.LoadProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.pictureBox1_LoadProgressChanged);
            // 
            // dtmFechaDeLanzamiento
            // 
            this.dtmFechaDeLanzamiento.Location = new System.Drawing.Point(5, 263);
            this.dtmFechaDeLanzamiento.Name = "dtmFechaDeLanzamiento";
            this.dtmFechaDeLanzamiento.Size = new System.Drawing.Size(172, 20);
            this.dtmFechaDeLanzamiento.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha de lanzamiento";
            // 
            // chkCobertura
            // 
            this.chkCobertura.AutoSize = true;
            this.chkCobertura.Location = new System.Drawing.Point(5, 219);
            this.chkCobertura.Name = "chkCobertura";
            this.chkCobertura.Size = new System.Drawing.Size(188, 17);
            this.chkCobertura.TabIndex = 12;
            this.chkCobertura.Text = "¿Cuenta con cobertura de daños?";
            this.chkCobertura.UseVisualStyleBackColor = true;
            this.chkCobertura.CheckedChanged += new System.EventHandler(this.chkCobertura_CheckedChanged);
            // 
            // rdVerB
            // 
            this.rdVerB.AutoSize = true;
            this.rdVerB.Location = new System.Drawing.Point(102, 188);
            this.rdVerB.Name = "rdVerB";
            this.rdVerB.Size = new System.Drawing.Size(70, 17);
            this.rdVerB.TabIndex = 11;
            this.rdVerB.Text = "Version B";
            this.rdVerB.UseVisualStyleBackColor = true;
            // 
            // rdVerA
            // 
            this.rdVerA.AutoSize = true;
            this.rdVerA.Checked = true;
            this.rdVerA.Location = new System.Drawing.Point(5, 188);
            this.rdVerA.Name = "rdVerA";
            this.rdVerA.Size = new System.Drawing.Size(70, 17);
            this.rdVerA.TabIndex = 10;
            this.rdVerA.TabStop = true;
            this.rdVerA.Text = "Version A";
            this.rdVerA.UseVisualStyleBackColor = true;
            this.rdVerA.CheckedChanged += new System.EventHandler(this.rdVerA_CheckedChanged);
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
            this.cbMarca.Location = new System.Drawing.Point(106, 101);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(104, 21);
            this.cbMarca.TabIndex = 9;
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Marca de fabricante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Fabricacion";
            // 
            // txtCodigoSerie
            // 
            this.txtCodigoSerie.Location = new System.Drawing.Point(106, 133);
            this.txtCodigoSerie.Name = "txtCodigoSerie";
            this.txtCodigoSerie.ReadOnly = true;
            this.txtCodigoSerie.Size = new System.Drawing.Size(226, 20);
            this.txtCodigoSerie.TabIndex = 7;
            // 
            // txtNFab
            // 
            this.txtNFab.Location = new System.Drawing.Point(106, 21);
            this.txtNFab.Name = "txtNFab";
            this.txtNFab.Size = new System.Drawing.Size(104, 20);
            this.txtNFab.TabIndex = 1;
            this.txtNFab.TextChanged += new System.EventHandler(this.txtNFab_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Codigo de serie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Velocidad Max.";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(106, 71);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(104, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // txtVelMax
            // 
            this.txtVelMax.Location = new System.Drawing.Point(106, 46);
            this.txtVelMax.Name = "txtVelMax";
            this.txtVelMax.Size = new System.Drawing.Size(104, 20);
            this.txtVelMax.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio";
            // 
            // btnEliminarEspecifico
            // 
            this.btnEliminarEspecifico.Location = new System.Drawing.Point(799, 85);
            this.btnEliminarEspecifico.Name = "btnEliminarEspecifico";
            this.btnEliminarEspecifico.Size = new System.Drawing.Size(107, 61);
            this.btnEliminarEspecifico.TabIndex = 42;
            this.btnEliminarEspecifico.Text = "Desencolar";
            this.btnEliminarEspecifico.UseVisualStyleBackColor = true;
            this.btnEliminarEspecifico.Click += new System.EventHandler(this.btnEliminarEspecifico_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 321);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(939, 290);
            this.tabControl1.TabIndex = 44;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvMotos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(931, 264);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DataGridView";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(931, 264);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "FormaGrafica";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 623);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnEliminarEspecifico);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEncolar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEncolar;
        private System.Windows.Forms.DataGridView dgvMotos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtmFechaDeLanzamiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkCobertura;
        private System.Windows.Forms.RadioButton rdVerB;
        private System.Windows.Forms.RadioButton rdVerA;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoSerie;
        private System.Windows.Forms.TextBox txtNFab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtVelMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminarEspecifico;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

