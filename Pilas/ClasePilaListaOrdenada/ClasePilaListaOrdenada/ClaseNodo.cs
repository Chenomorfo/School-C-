using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePilaListaOrdenada
{
    class ClaseNodo<Tipo>
    {
        private Tipo _objetoConDatos;

        public Tipo ObjetoConDatos
        {
            get { return _objetoConDatos; }
            set { _objetoConDatos = value; }
        }

        private ClaseNodo<Tipo> _Siguiente;

        public ClaseNodo<Tipo> Siguiente
        {
            get { return _Siguiente; }
            set { _Siguiente = value; }
        }

        ~ClaseNodo() 
        {
            ObjetoConDatos = default(Tipo);
        }


    }
}
