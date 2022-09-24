
namespace ListaEnlazadaSimpleOrdenada___Zapatos
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNSerial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.dtmFechaFabricacion = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.chkTipoTacon = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.dgvZapatos = new System.Windows.Forms.DataGridView();
            this.btnMetodoSol = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZapatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(438, 81);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(127, 63);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(571, 81);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(127, 63);
            this.btnEliminar.TabIndex = 30;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(571, 12);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(127, 63);
            this.btnVaciar.TabIndex = 29;
            this.btnVaciar.Text = "Vaciar lista";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(438, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(127, 63);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNSerial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbColor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTalla);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.dtmFechaFabricacion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chkTipoTacon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbMarca);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 352);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Zapato";
            // 
            // txtNSerial
            // 
            this.txtNSerial.Location = new System.Drawing.Point(140, 294);
            this.txtNSerial.Name = "txtNSerial";
            this.txtNSerial.ReadOnly = true;
            this.txtNSerial.Size = new System.Drawing.Size(206, 20);
            this.txtNSerial.TabIndex = 20;
            this.txtNSerial.TextChanged += new System.EventHandler(this.txtNSerial_TextChanged);
            this.txtNSerial.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtNSerial_MouseUp);
            this.txtNSerial.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtNSerial_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Numero de serie";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Color";
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "B",
            "N",
            "C",
            "A",
            "M",
            ""});
            this.cbColor.Location = new System.Drawing.Point(140, 111);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(54, 21);
            this.cbColor.TabIndex = 19;
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.cbColor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Talla";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(140, 40);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(100, 20);
            this.txtTalla.TabIndex = 0;
            this.txtTalla.TextChanged += new System.EventHandler(this.txtTalla_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fecha de Fabricacion";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(140, 69);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // dtmFechaFabricacion
            // 
            this.dtmFechaFabricacion.Location = new System.Drawing.Point(146, 238);
            this.dtmFechaFabricacion.Name = "dtmFechaFabricacion";
            this.dtmFechaFabricacion.Size = new System.Drawing.Size(200, 20);
            this.dtmFechaFabricacion.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio";
            // 
            // chkTipoTacon
            // 
            this.chkTipoTacon.AutoSize = true;
            this.chkTipoTacon.Location = new System.Drawing.Point(25, 194);
            this.chkTipoTacon.Name = "chkTipoTacon";
            this.chkTipoTacon.Size = new System.Drawing.Size(101, 17);
            this.chkTipoTacon.TabIndex = 13;
            this.chkTipoTacon.Text = "Tacon estandar";
            this.chkTipoTacon.UseVisualStyleBackColor = true;
            this.chkTipoTacon.CheckedChanged += new System.EventHandler(this.chkCobertura_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Marca del Fabricante";
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Items.AddRange(new object[] {
            "Chanel",
            "Gucci",
            "Luis Vuiton",
            "Dior",
            "Jimmy Choo",
            "Alexaner MQueen",
            "Prada",
            "Marc Jacobs",
            "Givenchy",
            "Balenciaga"});
            this.cbMarca.Location = new System.Drawing.Point(137, 150);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(100, 21);
            this.cbMarca.TabIndex = 8;
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            // 
            // dgvZapatos
            // 
            this.dgvZapatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZapatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column8});
            this.dgvZapatos.Location = new System.Drawing.Point(12, 374);
            this.dgvZapatos.Name = "dgvZapatos";
            this.dgvZapatos.ReadOnly = true;
            this.dgvZapatos.Size = new System.Drawing.Size(686, 185);
            this.dgvZapatos.TabIndex = 25;
            this.dgvZapatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZapatos_CellClick);
            // 
            // btnMetodoSol
            // 
            this.btnMetodoSol.Location = new System.Drawing.Point(444, 153);
            this.btnMetodoSol.Name = "btnMetodoSol";
            this.btnMetodoSol.Size = new System.Drawing.Size(254, 63);
            this.btnMetodoSol.TabIndex = 32;
            this.btnMetodoSol.Text = "Contar Zapatos (Metodo Solicitado)";
            this.btnMetodoSol.UseVisualStyleBackColor = true;
            this.btnMetodoSol.Click += new System.EventHandler(this.btnMetodoSol_Click);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 204.0816F;
            this.Column1.HeaderText = "Talla";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 79.18367F;
            this.Column2.HeaderText = "Numero de Serie";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 79.18367F;
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.FillWeight = 79.18367F;
            this.Column4.HeaderText = "Fabricante";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Color";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.FillWeight = 79.18367F;
            this.Column6.HeaderText = "Tipo de tacon";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.FillWeight = 79.18367F;
            this.Column8.HeaderText = "Fecha de lanzamiento";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 574);
            this.Controls.Add(this.btnMetodoSol);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvZapatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZapatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.DateTimePicker dtmFechaFabricacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkTipoTacon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.DataGridView dgvZapatos;
        private System.Windows.Forms.Button btnMetodoSol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.TextBox txtNSerial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}

