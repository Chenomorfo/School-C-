namespace ClaseListaDobleOrdenada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ClaseListaDobleOrdenada<Motocicleta> unaLista = new ClaseListaDobleOrdenada<Motocicleta>();
        private void Form1_Load(object sender, EventArgs e)
        {
            cbMarca.SelectedIndex = 0;
            pictureBox1.Load("https://cdn.pixabay.com/photo/2017/11/10/05/24/select-2935439_960_720.png");
            MessageBox.Show("Debera copiar la direccion URL de la imagen que desee darle al articulo, si este es valido" +
                ", se reemplazara la actual por la nueva", "INSTRUCCIONES EN CASO DE FOTO");
        }

        public void RefrescarDGV()
        {

            dgvMotos.Rows.Clear();


            if (unaLista.Vacia)
            {
                return;
            }
            if (rdHaciaAdelante.Checked)
            {
                foreach (Motocicleta motocicleta in unaLista.HaciaAdelante)
                {
                   

                    dgvMotos.Rows.Add(
                        motocicleta.NumeroFabricacion.ToString(),
                        motocicleta.VelocidadMax.ToString(),
                        motocicleta.Precio.ToString("C"),
                        motocicleta.Marca,
                        motocicleta.CodigoDeSerie,
                        motocicleta.Version,
                         motocicleta.CoberturaDeDatos ? "Vigente" : "No",
                        motocicleta.FechaDeLanzamiento.ToLongDateString()
                        );
                    
                }
            }
            else
            {
                foreach (Motocicleta motocicleta in unaLista.HaciaAtras)
                {
                    dgvMotos.Rows.Add(
                        motocicleta.NumeroFabricacion.ToString(),
                        motocicleta.VelocidadMax.ToString(),
                        motocicleta.Precio.ToString("C"),
                        motocicleta.Marca,
                        motocicleta.CodigoDeSerie,
                        motocicleta.Version,
                         motocicleta.CoberturaDeDatos ? "Vigente" : "No",
                        motocicleta.FechaDeLanzamiento.ToLongDateString()
                        );
                }
            }

            label7.Text = "NodoFinal:\n " + unaLista.NodoFinal.ObjetoConDatos.NumeroFabricacion;
            label8.Text = "NodoInicial:\n " + unaLista.NodoInicial.ObjetoConDatos.NumeroFabricacion;



        }
        public void LimpiarControles()
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }

            }
            cbMarca.SelectedIndex = 0;
            pictureBox1.Load("https://cdn.pixabay.com/photo/2017/11/10/05/24/select-2935439_960_720.png");
            RutaFoto = "";
        }
        public bool fifty()
        {
            Random fifty = new Random();
            if (fifty.NextDouble() > 0.5)
            {
                return true;
            }
            return false;
        }

        string RutaFoto="";










        private void btnFoto_Click(object sender, EventArgs e)
        {

            try
            {
                RutaFoto = Microsoft.VisualBasic.Interaction.InputBox("Introduzca la URL de su imagen");
                pictureBox1.Load(RutaFoto);
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
        }

        private void rdHaciaAtras_CheckedChanged(object sender, EventArgs e)
        {
            RefrescarDGV();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "")
                    {
                        MessageBox.Show("Llene todos los campos para validar la captura");
                        return;
                    }
                }

            }
            Motocicleta unaMoto = new Motocicleta();
            try
            {

                unaMoto.CodigoDeSerie = txtCodigoSerie.Text;
                unaMoto.NumeroFabricacion = int.Parse(txtNFab.Text);
                unaMoto.VelocidadMax = int.Parse(txtVelMax.Text);
                unaMoto.Precio = double.Parse(txtPrecio.Text);
                unaMoto.Marca = cbMarca.Text;
                unaMoto.FechaDeLanzamiento = dtmFechaDeLanzamiento.Value;
                unaMoto.CoberturaDeDatos = chkCobertura.Checked;
                if (rdVerA.Checked)
                {
                    unaMoto.Version = 'A';
                }
                else
                {
                    unaMoto.Version = 'B';
                }
                if (RutaFoto == "")
                {
                    RutaFoto = "https://images.fineartamerica.com/images-medium-large-5/broken-bike-at-oxford-carl-purcell.jpg";
                }
                
                unaMoto.RutaFoto = RutaFoto;
                
                unaLista.AgregarNodo(unaMoto);

            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
                
            }
            //Captura de datos




            RefrescarDGV();
            LimpiarControles();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNFab.Text == "")
            {
                MessageBox.Show("No se ha seleccionado ninguna motocicleta a buscar");
                return;
            }

            Motocicleta unaMoto = new Motocicleta();
            unaMoto.NumeroFabricacion = int.Parse(txtNFab.Text);

            MessageBox.Show(unaLista.BuscarNodo(unaMoto).ToString(), "Datos de la motocicleta");
            return;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Motocicleta unaMoto;
            Random random = new Random();
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var Charsarr = new char[8];
            string[] listaFotos = new string[15]
                {"https://i.pinimg.com/550x/b8/54/ea/b854eacdbc35e1368b02be25e7c9639f.jpg",
                "https://cloudfront-us-east-1.images.arcpublishing.com/infobae/JLM7MD7QBNFWJBXDW2X4VFT3EM.jpg",
                "https://a5i4f6g5.stackpathcdn.com/images/cms/cbf125.png",
                "https://a5i4f6g5.stackpathcdn.com/images/cms/cbf125.png",
                "https://resources.sears.com.mx/medios-plazavip/fotos/productos_sears1/original/3314776.jpg",
                "https://img.remediosdigitales.com/98cdc8/voge-500r-1/450_1000.jpg",
                "https://www.wilock.com/wp-content/uploads/2018/09/Dodge-Tomahawk-V10-Superbike.jpg",
                "https://media.revistagq.com/photos/61cdd0f759ab05088d9a51c7/master/w_1600%2Cc_limit/6BDB4FF4-A0E9-4CB4-9BAE-97206B7AD05E.jpeg",
                "https://revistacentrozaragoza.com/wp-content/uploads/2019/05/motos3-1024x632.jpg",
                "https://img.remediosdigitales.com/c165a8/honda_sh125/450_1000.jpg",
                "https://blog.coppel.com/wp-content/uploads/2020/02/interior_chopper.png",
                "https://www.hibridosyelectricos.com/media/hibridos/images/2019/06/17/2019061712442294588.jpg?width=1200&enable=upscale",
                "https://as01.epimg.net/mexico/imagenes/2020/07/10/masdeporte/1594354408_537364_1594354608_noticia_normal_recorte1.jpg",
                "https://www.motocarrostvs.com/wp-content/uploads/2020/12/rr1.jpg",
                "https://media.gq.com.mx/photos/5ff4909934f0ef41de7cf420/master/pass/FOTO%20PORTADA.jpg"
                };


            for (int i = 0; i < 10; i++)
            {
                try
                {
                     unaMoto = new Motocicleta();

                for (int j = 0; j < 8; j++)
                {
                    Charsarr[j] = chars[random.Next(chars.Length)];
                }
                var NSerieAleatorio = new String(Charsarr);

                
                unaMoto.CodigoDeSerie = NSerieAleatorio;
                unaMoto.NumeroFabricacion = random.Next(1, 1000);
                unaMoto.VelocidadMax = random.Next(100, 300);
                unaMoto.Precio = random.Next(3000, 30000);

                cbMarca.SelectedIndex = random.Next(0, 10);

                unaMoto.Marca = cbMarca.Text;
                unaMoto.FechaDeLanzamiento = new DateTime(random.Next(1960, 2022), random.Next(1, 12), random.Next(1, 28));
                unaMoto.CoberturaDeDatos = fifty();
                if (fifty())
                {
                    unaMoto.Version = 'A';
                }
                else
                {
                    unaMoto.Version = 'B';
                }

                unaMoto.RutaFoto = listaFotos[random.Next(0, 14)];

               
                    unaLista.AgregarNodo(unaMoto);
                }


                catch (Exception x)
                {

                    MessageBox.Show(x.Message);
                   
                }
              
            }

            RefrescarDGV();

        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("¿Esta seguro de vaciar esta lista?", "ADVERTENCIA!!!", MessageBoxButtons.YesNo);
            if (decision == DialogResult.No)
            {
                return;
            }
            unaLista.Vaciar();
            RefrescarDGV();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNFab.Text == "")
            {
                MessageBox.Show("No se ha seleccionado ninguna motocicleta a eliminar");
                return;
            }

            Motocicleta unaMoto = new Motocicleta();
            unaMoto.NumeroFabricacion = int.Parse(txtNFab.Text);



            DialogResult decision = MessageBox.Show("¿Esta seguro de borrar este articulo?", "ADVERTENCIA!!!", MessageBoxButtons.YesNo);
            if (decision == DialogResult.No)
            {
                return;
            }
            
            MessageBox.Show("Se ha borrado con exito:\n"+ unaLista.EliminarNodo(unaMoto));
            RefrescarDGV();
            LimpiarControles();

        }

        private void dgvMotos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMotos.CurrentCell.Value == null)
            {
                return;
            }


            Motocicleta unaMoto = new Motocicleta();
            unaMoto.NumeroFabricacion = int.Parse(dgvMotos.CurrentRow.Cells[0].Value.ToString());

            unaMoto = unaLista.BuscarNodo(unaMoto);

            txtCodigoSerie.Text = unaMoto.CodigoDeSerie;
            txtNFab.Text = unaMoto.NumeroFabricacion.ToString();
            txtVelMax.Text = unaMoto.VelocidadMax.ToString();
            txtPrecio.Text = unaMoto.Precio.ToString();
            cbMarca.Text = unaMoto.Marca;
            dtmFechaDeLanzamiento.Value = unaMoto.FechaDeLanzamiento;
            chkCobertura.Checked = unaMoto.CoberturaDeDatos;
            pictureBox1.Load(unaMoto.RutaFoto);

        }

        private void dgvMotos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}