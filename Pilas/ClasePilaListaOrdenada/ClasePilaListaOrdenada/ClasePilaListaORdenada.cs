using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePilaListaOrdenada
{
    class ClasePilaListaORdenada<Tipo> where Tipo : IComparable<Tipo>
    {
        public ClasePilaListaORdenada()
        {
            Top = null;
        }

        private ClaseNodo<Tipo> _top;

        public ClaseNodo<Tipo> Top
        {
            get { return _top; }
            set { _top = value; }
        }

        public IEnumerator<Tipo> GetEnumerator()
        {
            if (Vacia)
            {
                yield break;
            }
            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            nodoActual = Top;
            do
            {
                yield return (nodoActual.ObjetoConDatos);


                nodoActual = nodoActual.Siguiente;
            } while (nodoActual != null);

        }

        public bool Vacia
        {
            get {
                if (Top == null)
                {
                    return true;
                }
                return false;
            }

        }



        public void Push(Tipo objeto)
        {
            ClaseNodo<Tipo> nodoActual,
                nodoNuevo = new ClaseNodo<Tipo>(),
                nodoPrevio;


            if (Vacia)
            {
                nodoNuevo.ObjetoConDatos = objeto;
                Top = nodoNuevo;

                return;
            }
            nodoActual = Top;
            nodoPrevio = Top;
            do
            {

                if (objeto.Equals(nodoActual.ObjetoConDatos))
                {
                    throw new Exception("Objeto duplicado");
                }

                if (objeto.CompareTo(nodoActual.ObjetoConDatos) > 0)
                {

                    if (objeto.CompareTo(Top.ObjetoConDatos) > 0)
                    {
                        nodoNuevo.ObjetoConDatos = objeto;
                        nodoNuevo.Siguiente = Top;
                        Top = nodoNuevo;
                        return;

                    }

                    nodoNuevo.ObjetoConDatos = objeto;
                    nodoNuevo.Siguiente = nodoActual;
                    nodoPrevio.Siguiente = nodoNuevo;
                    return;
                }

                nodoPrevio = nodoActual;
                nodoActual = nodoActual.Siguiente;

            } while (nodoActual != null);

            nodoNuevo.ObjetoConDatos = objeto;
            nodoActual = new ClaseNodo<Tipo>();
            nodoActual = nodoNuevo;
            nodoPrevio.Siguiente = nodoActual;
        }
        public Tipo Buscar(Tipo objeto)
        {
            if (Vacia)
            {
                throw new Exception("La lista esta vacia");
            }
            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            nodoActual = Top;
            do
            {
                if (objeto.Equals(nodoActual.ObjetoConDatos))
                {
                    return nodoActual.ObjetoConDatos;
                }

                nodoActual = nodoActual.Siguiente;



            } while (nodoActual != null);

            throw new Exception("El objeto no existe");

        }

        public Tipo Pop() 
        {
            if (Vacia)
            {
                throw new Exception("No hay datos");
            }
            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            ClaseNodo<Tipo> nodoEliminado = new ClaseNodo<Tipo>();

            nodoActual = Top;
            nodoEliminado = nodoActual;
            Top = nodoActual.Siguiente;
            nodoActual = default;

            return nodoEliminado.ObjetoConDatos;

        }

        public Tipo Pop(Tipo objeto) 
        {
            if (Vacia)
            {
                throw new Exception("No hay datos");
            }
            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
            ClaseNodo<Tipo> nodoEliminado = new ClaseNodo<Tipo>();
            nodoActual = Top;
            do
            {
                if (objeto.Equals(nodoActual.ObjetoConDatos))
                {
                    if (objeto.Equals(Top.ObjetoConDatos))
                    {
                        return Pop();
                    }


                    nodoEliminado = nodoActual;
                    nodoPrevio.Siguiente = nodoActual.Siguiente;
                    nodoActual = default;

                    return nodoEliminado.ObjetoConDatos;
                }

                nodoPrevio = nodoActual;
                nodoActual = nodoActual.Siguiente;


            } while (nodoActual != null);

            throw new Exception("El objeto no existe");


        }

        public void Vaciar() 
        {
            if (Vacia)
            {
                return;
            }
            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
            nodoActual = Top;
            do
            {
                nodoPrevio = nodoActual;
                nodoActual = nodoActual.Siguiente;
                nodoPrevio = default;


            } while (nodoActual != null);
            Top = null;

        }

        ~ClasePilaListaORdenada() 
        {
            this.Vaciar();
        }

    }
}
