using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseListaColaDesordenada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
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

                unaLista.Encolar(unaMoto);

            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);

            }

            RefrescarDGV();
            VisionGrafica();
            LimpiarControles();
        }

        //Forma grafica de mostrar datos
        private void bikeClicking(object sender, EventArgs e) 
        {
            Motocicleta unaMoto = new Motocicleta();
            unaMoto.CodigoDeSerie = ((PictureBox)sender).Name;
         

            unaMoto = unaLista.Buscar(unaMoto);

            txtCodigoSerie.Text = unaMoto.CodigoDeSerie;
            txtNFab.Text = unaMoto.NumeroFabricacion.ToString();
            txtVelMax.Text = unaMoto.VelocidadMax.ToString();
            txtPrecio.Text = unaMoto.Precio.ToString();
            cbMarca.Text = unaMoto.Marca;
            dtmFechaDeLanzamiento.Value = unaMoto.FechaDeLanzamiento;
            chkCobertura.Checked = unaMoto.CoberturaDeDatos;
            pictureBox1.LoadAsync(unaMoto.RutaFoto);



        }

        PictureBox bike;
        public void VisionGrafica()
        {
            int posX = 5, posY = 5;
            int variedad = 1;


           
                foreach (PictureBox p in tabPage2.Controls)
                {

                    p.Click -= new System.EventHandler(this.bikeClicking);
                    tabPage2.Controls.Remove(p);


                }
            tabPage2.Controls.Clear();



            foreach (Motocicleta unaMoto in unaLista)
            {
                bike = new PictureBox();


                bike.Name = unaMoto.CodigoDeSerie;
                bike.Size = new Size(75, 75);
                if (variedad == 1)
                {
                    bike.Image = Properties.Resources.bike;

                }
                if (variedad == 2)
                {
                    bike.Image = Properties.Resources.bike2;

                }
                if (variedad == 3)
                {
                    bike.Image = Properties.Resources.bike3;
                    variedad = 0;
                }


                bike.SizeMode = PictureBoxSizeMode.StretchImage;
                bike.Location = new Point(posX, posY);

                bike.Click += new System.EventHandler(this.bikeClicking);


                tabPage2.Controls.Add(bike);
                if (posX > 930)
                {
                    posX = 5;
                    posY += 85;
                }
                else
                {
                    posX += 85;
                }
                variedad++;
            }






        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cbMarca.SelectedIndex = 0;

            pictureBox1.Load("https://cdn-icons-png.flaticon.com/512/3721/3721619.png");
            MessageBox.Show("En caso de DataGridView:\nSe mostrara con un datagridiew\n\nEn caso de FormaGrafica:\nSe usaran PictureBox dinamicos a los cual" +
                "es debe dar click para que funcione como si fuera el click a una celda de un datagridview","FUNCIONES!!!");
        
        }

        string RutaFoto = "";
        ClaseColaListaDesordenada<Motocicleta> unaLista = new ClaseColaListaDesordenada<Motocicleta>();

      
        public void RefrescarDGV()
        {

            dgvMotos.Rows.Clear();


            if (unaLista.Vacia)
            {
                return;
            }
            foreach (Motocicleta motocicleta in unaLista)
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
            pictureBox1.CancelAsync();
            pictureBox1.LoadAsync("https://cdn.pixabay.com/photo/2017/11/10/05/24/select-2935439_960_720.png");
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNFab.Text == "")
            {
                MessageBox.Show("No se ha seleccionado ninguna motocicleta a buscar");
                return;
            }

            Motocicleta unaMoto = new Motocicleta();
            unaMoto.CodigoDeSerie = txtCodigoSerie.Text;

            MessageBox.Show(unaLista.Buscar(unaMoto).ToString(), "Datos de la motocicleta");
            return;
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
           
            LimpiarControles();
            VisionGrafica();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dezicion = MessageBox.Show("¿Esta seguro de borrar el Frente?", "ADVERTENCIA!!!", MessageBoxButtons.YesNo);
            if (dezicion == DialogResult.No)
            {

                return;
            }
            try
            {
                MessageBox.Show("Se ha borrado con exito:\n" + unaLista.Desencolar());
                RefrescarDGV();
                LimpiarControles();
                VisionGrafica();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
         
        }

        private void btnEliminarEspecifico_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("¿Esta seguro de borrar este articulo?", "ADVERTENCIA!!!", MessageBoxButtons.YesNo);
            if (decision == DialogResult.No)
            {
                return;
            }
            try
            {

            
         
            Motocicleta unaMoto = new Motocicleta();
            unaMoto.CodigoDeSerie = txtCodigoSerie.Text;
            MessageBox.Show("Se ha borrado con exito:\n" + unaLista.Desencolar(unaMoto));
                RefrescarDGV();
                LimpiarControles();
                VisionGrafica();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
}

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Motocicleta unaMoto;
            Random random = new Random();

            string[] listaFotos = new string[15]
                {"https://i.pinimg.com/550x/b8/54/ea/b854eacdbc35e1368b02be25e7c9639f.jpg",
                "https://cloudfront-us-east-1.images.arcpublishing.com/infobae/JLM7MD7QBNFWJBXDW2X4VFT3EM.jpg",
                "https://exclusivomotos.com/wp-content/uploads/2020/09/KTM-1290-Super-Duke-R-12-scaled.jpg",
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


                    unaMoto.CodigoDeSerie = unaMoto.Version + "-" + unaMoto.NumeroFabricacion + "-" + unaMoto.Marca + "-" + (unaMoto.CoberturaDeDatos ? "GV" : "GC");
                    unaMoto.RutaFoto = listaFotos[random.Next(0, 14)];


                    unaLista.Encolar(unaMoto);
                }


                catch (Exception x)
                {

                    MessageBox.Show(x.Message);

                }

            }

            RefrescarDGV();
            VisionGrafica();
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodigoSerie.Text = (rdVerA.Checked ? "A-" : "B-") + txtNFab.Text + "-" + cbMarca.Text + "-" + (chkCobertura.Checked ? "GV" : "GC");
        }

        private void rdVerA_CheckedChanged(object sender, EventArgs e)
        {
            txtCodigoSerie.Text = (rdVerA.Checked ? "A-" : "B-") + txtNFab.Text + "-" + cbMarca.Text + "-" + (chkCobertura.Checked ? "GV" : "GC");
        }

        private void chkCobertura_CheckedChanged(object sender, EventArgs e)
        {
            txtCodigoSerie.Text = (rdVerA.Checked ? "A-" : "B-") + txtNFab.Text + "-" + cbMarca.Text + "-" + (chkCobertura.Checked ? "GV" : "GC");
        }

        private void pictureBox1_LoadProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Value = e.ProgressPercentage;
        }

        private void txtNFab_TextChanged(object sender, EventArgs e)
        {
            txtCodigoSerie.Text = (rdVerA.Checked ? "A-" : "B-") + txtNFab.Text + "-" + cbMarca.Text + "-" + (chkCobertura.Checked ? "GV" : "GC");
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            progressBar1.Visible = false;
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.CancelAsync();
                RutaFoto = Microsoft.VisualBasic.Interaction.InputBox("Introduzca la URL de su imagen");
                pictureBox1.LoadAsync(RutaFoto);
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
        }

        private void dgvMotos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMotos.CurrentCell.Value == null)
            {
                return;
            }

            pictureBox1.CancelAsync();
            Motocicleta unaMoto = new Motocicleta();
            unaMoto.CodigoDeSerie = dgvMotos.CurrentRow.Cells[4].Value.ToString();

            try
            {
                unaMoto = unaLista.Buscar(unaMoto);

                txtCodigoSerie.Text = unaMoto.CodigoDeSerie;
                txtNFab.Text = unaMoto.NumeroFabricacion.ToString();
                txtVelMax.Text = unaMoto.VelocidadMax.ToString();
                txtPrecio.Text = unaMoto.Precio.ToString();
                cbMarca.Text = unaMoto.Marca;
                dtmFechaDeLanzamiento.Value = unaMoto.FechaDeLanzamiento;
                chkCobertura.Checked = unaMoto.CoberturaDeDatos;
                pictureBox1.LoadAsync(unaMoto.RutaFoto);
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }

