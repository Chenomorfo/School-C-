using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseListaSimpleOrdenada___Motocicletas
{
    class ClaseListaSimpleOrdenada<Tipo> where Tipo: IComparable<Tipo>, IEquatable<Tipo>
    {
        public ClaseListaSimpleOrdenada()
        {
            NodoInicial = null;
        }

        private ClaseNodo<Tipo> _nodoInicial;

        private ClaseNodo<Tipo> NodoInicial
        {
            get { return _nodoInicial; }
            set { _nodoInicial = value; }
        }

        public bool Vacia
        {
            get
            {

                if (NodoInicial == null)
                {
                    return true;
                }
                return false;
            }
        }


        public void AgregarNodo(Tipo objeto)
        {
            //Primer nodo o nodo inicial
            if (Vacia)
            {
                ClaseNodo<Tipo> PrimerNodo = new ClaseNodo<Tipo>();
                PrimerNodo.ObjetoConDatos = objeto;
                PrimerNodo.Siguiente = null;
                NodoInicial = PrimerNodo;
                return;
            }

            ClaseNodo<Tipo> NodoActual;
            ClaseNodo<Tipo> NodoPrevio = new ClaseNodo<Tipo>();
            NodoActual = NodoInicial;
            do
            {
                //Si ya existe
                if (NodoActual.ObjetoConDatos.Equals(objeto))
                {
                        throw new Exception("Objeto duplicado");

                }

                //si el nuevo es menor al actual
                if (NodoActual.ObjetoConDatos.CompareTo(objeto) > 0)
                {
                    ClaseNodo<Tipo> nuevoNodo;
                    
                    //Si el nuevo es menor al inicial
                    if (objeto.CompareTo(NodoInicial.ObjetoConDatos) < 0)
                    {
                        nuevoNodo = new ClaseNodo<Tipo>();
                        nuevoNodo.ObjetoConDatos = objeto;
                        nuevoNodo.Siguiente = NodoInicial;
                        NodoInicial = nuevoNodo;

                    }
                    else
                    //Si  es intermedio
                    {
                        nuevoNodo = new ClaseNodo<Tipo>();
                        nuevoNodo.ObjetoConDatos = objeto;
                        nuevoNodo.Siguiente = NodoPrevio.Siguiente;
                        NodoPrevio.Siguiente = nuevoNodo;
                    }

                    return;
            
                }

                else
                {
                    NodoPrevio = NodoActual;
                    NodoActual = NodoActual.Siguiente;
                }

            } while (NodoActual != null);
            //Si va al final
            ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();
            nodoNuevo.ObjetoConDatos = objeto;
            NodoPrevio.Siguiente = nodoNuevo;
            nodoNuevo.Siguiente = null;
            return;
        }

        public Tipo EliminarNodo(Tipo objeto)
        {
            if (Vacia)
            {
                throw new Exception("No contiene datos");
            }

            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
            ClaseNodo<Tipo> nodoEliminado = new ClaseNodo<Tipo>();
            nodoActual = NodoInicial;
            do
            {

                if (nodoActual.ObjetoConDatos.Equals(objeto))
                {
                    if (nodoActual.Equals(NodoInicial))
                    {
                        NodoInicial = nodoActual.Siguiente;
                        nodoEliminado = nodoActual;
                        nodoActual = default; 
                    }
                    else
                    {
                        nodoPrevio.Siguiente = nodoActual.Siguiente;
                        nodoEliminado = nodoActual;
                        nodoActual = default;
                    }
                    return nodoEliminado.ObjetoConDatos;
                }

                if (objeto.CompareTo(nodoActual.ObjetoConDatos) < 0)
                {
                    throw new Exception("El objeto no existe");
                }

                nodoPrevio = nodoActual;
                nodoActual = nodoActual.Siguiente;

            } while (nodoActual != null) ;

            throw new Exception("El objeto no existe");

        }

        public Tipo BuscarNodo(Tipo objeto)
        {

            if (Vacia)
            {
                throw new Exception("La lista esta vacia");
            }
            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            nodoActual = NodoInicial;
            do
            {

                if (nodoActual.ObjetoConDatos.Equals(objeto))
                {
                    return nodoActual.ObjetoConDatos;
                }
                nodoActual = nodoActual.Siguiente;

            } while (nodoActual != null);
            throw new Exception("No se encontro el objeto");

        }

        public void Vaciar()
        {

            if (Vacia)
            {
                return;
            }

            ClaseNodo<Tipo> nodoActual;
            ClaseNodo<Tipo> nodoPrevio;
            nodoActual = NodoInicial;


            do
            {

                nodoPrevio = nodoActual;
                nodoActual = nodoActual.Siguiente;
                nodoPrevio = default;

            } while (nodoActual != null);
            
            NodoInicial = null;

        }

        public IEnumerator<Tipo> GetEnumerator()
        {
            ClaseNodo<Tipo> nodoActual;
            nodoActual = NodoInicial;

            do
            {

                yield return (nodoActual.ObjetoConDatos);

                nodoActual = nodoActual.Siguiente;

            } while (nodoActual != null);
            yield break;
        }
        ~ClaseListaSimpleOrdenada()
        {
            this.Vaciar();
        }

    }
}
