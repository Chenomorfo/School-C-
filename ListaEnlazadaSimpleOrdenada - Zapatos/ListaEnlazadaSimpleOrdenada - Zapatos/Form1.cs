using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaEnlazadaSimpleOrdenada___Zapatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        ClaseListaSimpleOrdenada<Zapato> unaLista = new ClaseListaSimpleOrdenada<Zapato>();
        public bool fifty()
        {
            Random fifty = new Random();
            if (fifty.NextDouble() > 0.5)
            {
                return true;
            }
            return false;
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
         
        }
        public void RefrescarDGV()
        {

            dgvZapatos.Rows.Clear();


            if (unaLista.Vacia)
            {
                return;
            }

            foreach (Zapato unZapato in unaLista)
            {


                dgvZapatos.Rows.Add(
                    unZapato.Talla.ToString(),
                    unZapato.NumeroSerial,
                    unZapato.Precio.ToString("C"),
                    unZapato.Fabricante,
                    unZapato.Color.ToString(),       
                     unZapato.TaconAlto ? "Tacon alto" : "Tacon Estandar",
                    unZapato.FechaDeFabricacion.ToLongDateString()
                    );
            }


        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chkCobertura_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTipoTacon.Checked)
            {
            
                chkTipoTacon.Text = "Tacon alto";
            }
            else
            {
              
                chkTipoTacon.Text = "Tacon estandar";
            }
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
            Zapato unZapato = new Zapato();
            try
            {

                unZapato.NumeroSerial = txtNSerial.Text;
                unZapato.Talla = int.Parse(txtTalla.Text);
                unZapato.Color = char.Parse(cbColor.Text);
                unZapato.Precio = double.Parse(txtPrecio.Text);
                unZapato.Fabricante = cbMarca.Text;
                unZapato.FechaDeFabricacion = dtmFechaFabricacion.Value;
                unZapato.TaconAlto = chkTipoTacon.Checked;
           

                unaLista.AgregarNodo(unZapato);

            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
                return;
            }
            //Captura de datos




            RefrescarDGV();
            LimpiarControles();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbMarca.SelectedIndex = 0;
            MessageBox.Show("En el uso del numero de serie, se generara segun los datos que introduzca, antes de agregar, pase el mouse por encima del textbox" +
                " del numero de serie para verificar los datos y guardarlo posteriormente.\n \nUna modificacion a los valores anteriores borrara este numero de serie, y debera" +
                " pasar nuevamente el raton por encima de su textbox para generar un nuevo numero de serie","ATENCION!!!");
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNSerial.Text == "")
            {
                MessageBox.Show("No se ha seleccionado ningun zapato a buscar");
                return;
            }




            Zapato unZapato = new Zapato();
            unZapato.NumeroSerial = txtNSerial.Text;


            MessageBox.Show(unaLista.BuscarNodo(unZapato).ToString(), "Datos del Zapato");
            return;
        }

        private void txtTalla_TextChanged(object sender, EventArgs e)
        {
            txtNSerial.Text = "";
        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNSerial.Text = "";
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNSerial.Text = "";
        }

        private void txtNSerial_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNSerial_MouseUp(object sender, MouseEventArgs e)
        {
            if (chkTipoTacon.Checked)
            {
                txtNSerial.Text = "TA-" + cbMarca.Text + cbColor.Text + txtTalla.Text;
            }
            else
            {
                txtNSerial.Text = "TS-" + cbMarca.Text + cbColor.Text + txtTalla.Text;
            }
          
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("¿Esta seguro de vaciar esta lista?", "ADVERTENCIA!!!", MessageBoxButtons.YesNo);
            if (decision == DialogResult.No)
            {
                return;
            }
            try
            {
                unaLista.Vaciar();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
            unaLista.Vaciar();
            RefrescarDGV();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNSerial.Text == "")
            {
                MessageBox.Show("No se ha seleccionado ningun Zapato a eliminar");
                return;
            }




            Zapato unZapato = new Zapato();
            unZapato.NumeroSerial = txtNSerial.Text;

            DialogResult decision = MessageBox.Show("¿Esta seguro de borrar este articulo?", "ADVERTENCIA!!!", MessageBoxButtons.YesNo);
            if (decision == DialogResult.No)
            {
                return;
            }
            try
            {
                
                MessageBox.Show("Se ha borrado con exito el siguiente articulo:\n"+ unaLista.EliminarNodo(unZapato));
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
         
            RefrescarDGV();
            LimpiarControles();
        }

        private void btnDatosAleatorios_Click(object sender, EventArgs e)
        {

        }






        public int ContarZapatos() 
        {
            int CantZapatos = 0;

            foreach (Zapato unZapato in unaLista)
            {
                if (unZapato.NumeroSerial.Length <15)
                {
                    CantZapatos++;
                }
            }

            return CantZapatos;

        }

        private void btnMetodoSol_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La cantidad de zapatos que en su Numero de serie es menor a 15 letras, es de: " +ContarZapatos(),"Metodo Solicitado");
        }

        private void dgvZapatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvZapatos.CurrentCell.Value == null)
            {
                return;
            }


            Zapato unZapato = new Zapato();
            unZapato.NumeroSerial = dgvZapatos.CurrentRow.Cells[1].Value.ToString();

            unZapato = unaLista.BuscarNodo(unZapato);

            txtNSerial.Text = unZapato.NumeroSerial;
            txtPrecio.Text = unZapato.Precio.ToString();
            txtTalla.Text = unZapato.Talla.ToString();
            chkTipoTacon.Checked = unZapato.TaconAlto;
            cbMarca.Text = unZapato.Fabricante;
            dtmFechaFabricacion.Value = unZapato.FechaDeFabricacion;
            cbColor.Text = unZapato.Color.ToString();
        
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
