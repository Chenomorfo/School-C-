using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEnlazadaSimpleOrdenada___Zapatos
{
    class Zapato : IComparable<Zapato>,IEquatable<Zapato>
    {
        private int _intTalla;

        public int Talla
        {
            get { return _intTalla; }
            set { _intTalla = value; }
        }

        private string _strNSerial;

        public string NumeroSerial
        {
            get { return _strNSerial; }
            set { _strNSerial = value; }
        }

        private char _chrColor;

        public char Color
        {
            get { return _chrColor; }
            set { _chrColor = value; }
        }

        private double _dblPrecio;

        public double Precio
        {
            get { return _dblPrecio; }
            set { _dblPrecio = value; }
        }

        private DateTime _dtmFechaDeFabricacion;

        public DateTime FechaDeFabricacion
        {
            get { return _dtmFechaDeFabricacion; }
            set { _dtmFechaDeFabricacion = value; }
        }

        private bool _blnTaconAlto;

        public bool TaconAlto
        {
            get { return _blnTaconAlto; }
            set { _blnTaconAlto = value; }
        }

        private string _strFabricante;

        public string Fabricante
        {
            get { return _strFabricante; }
            set { _strFabricante = value; }
        }

      

        public bool Equals(Zapato otroZapato)
        {

            return this.NumeroSerial == otroZapato.NumeroSerial;

        }

        public int CompareTo(Zapato otroZapato)
        {
            if (this.Talla > otroZapato.Talla)
            {
                return 1;
            }
            if (this.Talla < otroZapato.Talla)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }

        public override string ToString()
        {
            return "Numero serial: "+NumeroSerial +
                "\nTalla: "+Talla +
                "\nPrecio: "+Precio.ToString("C") +
                "\nTipo de Tacon: " + (this.TaconAlto ? "Tacon alto" : "Tacon Estandar") +
                "\nColor: "+Color.ToString() +
                "\nFabricante: "+Fabricante +
                "\nFecha de fabricacion: "+FechaDeFabricacion.ToLongDateString();
        }

    }
}
