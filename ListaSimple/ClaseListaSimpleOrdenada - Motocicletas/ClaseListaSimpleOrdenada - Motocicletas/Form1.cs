using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseListaSimpleOrdenada___Motocicletas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ClaseListaSimpleOrdenada<Motocicleta> unaLista = new ClaseListaSimpleOrdenada<Motocicleta>();

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


        private void Form1_Load(object sender, EventArgs e)
        {
            cbMarca.SelectedIndex = 0;
            pictureBox1.Load("https://cdn.pixabay.com/photo/2017/11/10/05/24/select-2935439_960_720.png");
            MessageBox.Show("Debera copiar la direccion URL de la imagen que desee darle al articulo, si este es valido" +
                ", se reemplazara la actual por la nueva", "INSTRUCCIONES EN CASO DE FOTO");
        }
        string RutaFoto ="";
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
                unaMoto.FechaDeLanzamiento = dtmFechaLanzamiento.Value;
                unaMoto.CoberturaDeDatos = chkCobertura.Checked;
                if (rdVerA.Checked)
                {
                    unaMoto.Version = 'A';
                }
                else
                {
                    unaMoto.Version = 'B';
                }
                unaMoto.RutaFoto = RutaFoto;

                unaLista.AgregarNodo(unaMoto);

            }
            catch (Exception x)
            {

                MessageBox.Show("Hay datos erroneos en su articulo");
                return;
            }
            //Captura de datos
        
            


             RefrescarDGV();
             LimpiarControles();
        }

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
                    txtVelMax.Text= unaMoto.VelocidadMax.ToString();
                    txtPrecio.Text = unaMoto.Precio.ToString();
                      cbMarca.Text = unaMoto.Marca;
                    dtmFechaLanzamiento.Value = unaMoto.FechaDeLanzamiento;
                    chkCobertura.Checked = unaMoto.CoberturaDeDatos;
            if (unaMoto.RutaFoto != "") { pictureBox1.Load(unaMoto.RutaFoto); }
                    

                  
                  
                
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("¿Esta seguro de vaciar esta lista?", "ADVERTENCIA!!!", MessageBoxButtons.YesNo);
            if (decision == DialogResult.No)
            {
                return;
            }
            unaLista.Vaciar();
            RefrescarDGV();
        }

        private void dgvMotos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDatosAleatorios_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var Charsarr = new char[8];
            string[] listaFotos = new string[15]
                {"https://i.pinimg.com/550x/b8/54/ea/b854eacdbc35e1368b02be25e7c9639f.jpg",
                "https://www.formulamoto.es/wp-content/uploads/2021/09/Honda_CBR500R_2022-1024x576.jpg",
                "https://lamoto.com.ar/wp-content/uploads/2021/03/LIFAN-KPF-150-1024x804-2.jpg",
                "https://auteco.vteximg.com.br/arquivos/ids/206754-600-600/moto_victory_mrx150_camo_2020_foto1.png?v=637601631008370000",
                "https://resources.sears.com.mx/medios-plazavip/fotos/productos_sears1/original/3314776.jpg",
                "https://img.remediosdigitales.com/98cdc8/voge-500r-1/450_1000.jpg",
                "https://www.wilock.com/wp-content/uploads/2018/09/Dodge-Tomahawk-V10-Superbike.jpg",
                "https://media.revistagq.com/photos/61cdd0f759ab05088d9a51c7/master/w_1600%2Cc_limit/6BDB4FF4-A0E9-4CB4-9BAE-97206B7AD05E.jpeg",
                "https://www.daytonamotos.com/wp-content/uploads/2016/08/CB1-1.png",
                "https://www.bicimex.com/Items_high/0200220099.jpg",
                "https://www.rac.mx/wp-content/uploads/2021/07/moto-italika-dt150-sport.jpg",
                "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/la-subasta-de-motos-mas-cara-del-mundo-hemderson-1540228056.jpg",
                "https://media.gq.com.mx/photos/6004b889136a880326643657/master/pass/motos-electricas.jpg",
                "https://dam.motociclismoonline.com.mx/wp-content/uploads/2020/04/37.jpg",
                "https://i0.wp.com/bp2.blogger.com/_uqbifoYYiK0/Rmpira0h4pI/AAAAAAAABmA/5YUxI8_2QJg/s1600/batbike.jpg"
                };



            for (int i = 0; i < 15; i++)
            {

                for (int j = 0; j < 8; j++)
                {
                    Charsarr[j] = chars[random.Next(chars.Length)];
                }
                var NSerieAleatorio = new String(Charsarr);

                Motocicleta unaMoto = new Motocicleta();
                unaMoto.CodigoDeSerie = NSerieAleatorio;
                unaMoto.NumeroFabricacion = random.Next(1,1000);
                unaMoto.VelocidadMax = random.Next(100,300);
                unaMoto.Precio = random.Next(3000,30000);

                cbMarca.SelectedIndex = random.Next(0,10);

                unaMoto.Marca = cbMarca.Text;
                unaMoto.FechaDeLanzamiento = new DateTime(random.Next(1960,2022), random.Next(1, 12), random.Next(1,28));
                unaMoto.CoberturaDeDatos = fifty();
                if (fifty())
                {
                    unaMoto.Version = 'A';
                }
                else
                {
                    unaMoto.Version = 'B';
                }
              
                unaMoto.RutaFoto = listaFotos[random.Next(0,14)];
                unaLista.AgregarNodo(unaMoto);



            }
            RefrescarDGV();
          


         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
       
            if (txtNFab.Text == "")
            {
                MessageBox.Show("No se ha seleccionado ninguna motocicleta a eliminar");
                return;
            }


            

            Motocicleta unaMoto = new Motocicleta();
            unaMoto.NumeroFabricacion = int.Parse(txtNFab.Text);

            DialogResult decision = MessageBox.Show("¿Esta seguro de borrar este articulo?" ,"ADVERTENCIA!!!",MessageBoxButtons.YesNo);
            if (decision == DialogResult.No)
            {
                return;
            }
            unaLista.EliminarNodo(unaMoto);
            MessageBox.Show("Se ha borrado con exito");
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
    }
}
