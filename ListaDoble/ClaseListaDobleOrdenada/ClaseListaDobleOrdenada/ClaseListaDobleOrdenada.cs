using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseListaDobleOrdenada
{
    internal class ClaseListaDobleOrdenada<Tipo> where Tipo: IEquatable<Tipo>, IComparable<Tipo>
    {
        public ClaseListaDobleOrdenada()
        {
            NodoInicial = null;
            NodoFinal = null;
        }

        private ClaseNodo<Tipo> _nodoInicial;

        public ClaseNodo<Tipo> NodoInicial
        {
            get { return _nodoInicial; }
            set { _nodoInicial = value; }
        }

        private ClaseNodo<Tipo> _nodoFinal;

        public ClaseNodo<Tipo> NodoFinal
        {
            get { return _nodoFinal; }
            set { _nodoFinal = value; }
        }

        public IEnumerable<Tipo> HaciaAdelante
        {
            get
            {
                if (Vacia)
                {
                    yield break;
                }
            
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                nodoActual = NodoInicial;

                do
                {

                    yield return(nodoActual.ObjetoConDatos);
                    nodoActual = nodoActual.Siguiente;

                } while (nodoActual!=null);
                yield break;
            }
            
        }
        public IEnumerable<Tipo> HaciaAtras
        {
            get {
                if (Vacia)
                {
                    yield break;
                }

                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                nodoActual = NodoFinal;

                do
                {

                    yield return (nodoActual.ObjetoConDatos);
                    nodoActual = nodoActual.Anterior;

                } while (nodoActual != null);
                yield break;
            }
        }

        public bool Vacia
        {
            get
            {

                if (NodoInicial == null && NodoFinal == null)
                {
                    return true;
                }
                return false;
            }
        }

        public Tipo BuscarNodo(Tipo objeto) 
        {
            if (Vacia)
            {
                throw new Exception ("La lista esta vacia");
            }
            ClaseNodo<Tipo> nodoActual=new ClaseNodo<Tipo>();
            nodoActual=NodoFinal;
            do
            {
                if (objeto.Equals(nodoActual.ObjetoConDatos))
                {
                    return nodoActual.ObjetoConDatos;
                }
            
                nodoActual = nodoActual.Anterior;



            } while (nodoActual!=null);

            throw new Exception("El objeto no existe");
        }

        public void AgregarNodo(Tipo objeto)
        {
            ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();

            if (Vacia)
            {    
                nodoNuevo.ObjetoConDatos = objeto;
                NodoInicial = nodoNuevo;
                    NodoFinal = nodoNuevo;
                return;
            }

            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            nodoActual = NodoFinal;

            do
            {
                if (objeto.Equals(nodoActual.ObjetoConDatos))
                {
                    throw new Exception("Objetos duplicados");

                }
                //Si es mayor al actual
                if (objeto.CompareTo(nodoActual.ObjetoConDatos) > 0)
                {
                    //Si el actual es el ultimo
                    if (objeto.CompareTo(NodoFinal.ObjetoConDatos) > 0 )
                    {
                        nodoNuevo.ObjetoConDatos = objeto;
                        nodoNuevo.Anterior = NodoFinal;
                        NodoFinal.Siguiente = nodoNuevo;
                        NodoFinal = nodoNuevo;
                        return;
                    }

                    //Si va entre el inicial y el final o enmedio
                    nodoNuevo.ObjetoConDatos = objeto;
                    nodoNuevo.Siguiente = nodoActual.Siguiente;
                    nodoActual.Siguiente.Anterior = nodoNuevo;
                    nodoNuevo.Anterior = nodoActual;
                    nodoActual.Siguiente = nodoNuevo;

                    return;

                }

                
                nodoActual = nodoActual.Anterior;

            } while (nodoActual!=null);

            //Si va al inicio
            nodoNuevo.ObjetoConDatos = objeto;
            nodoNuevo.Siguiente = NodoInicial;
            NodoInicial.Anterior = nodoNuevo;
            NodoInicial = nodoNuevo;


        }

        public Tipo EliminarNodo(Tipo objeto) 
        {            
            if (Vacia)
            {   throw new Exception("Lista vacia");   }
            
            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            ClaseNodo<Tipo> nodoEliminado = new ClaseNodo<Tipo>();
            nodoActual = NodoFinal;
            
            do
            {
                if (nodoActual.ObjetoConDatos.Equals(objeto))
                {
                    //Si solo hay uno
                    if (nodoActual.Equals(NodoFinal) && nodoActual.Equals(NodoInicial))
                    {
                        nodoEliminado = nodoActual;
                        NodoInicial = null;
                        NodoFinal = null;
                        return nodoEliminado.ObjetoConDatos;
                    }
                    //Si es el ultimo
                    else if (nodoActual.Equals(NodoFinal))
                    {
                        nodoEliminado = nodoActual;
                        NodoFinal = nodoActual.Anterior;
                        nodoActual = default;
                        return nodoEliminado.ObjetoConDatos;
                    }
                    //Si es el primero
                    else if (nodoActual.Equals(NodoInicial))
                    {
                        nodoEliminado = nodoActual;
                        NodoInicial = nodoActual.Siguiente;
                        nodoActual = default;
                        return nodoEliminado.ObjetoConDatos;
                    }
                  
                        nodoEliminado = nodoActual;
                        nodoActual.Anterior.Siguiente = nodoActual.Siguiente;
                        nodoActual.Siguiente.Anterior = nodoActual.Anterior;
                        nodoActual = default;
                        return nodoEliminado.ObjetoConDatos;
                }
                 nodoActual = nodoActual.Anterior;

            } while (nodoActual != null);

            throw new Exception("No se ha encontrado el objeto a eliminar");
        }

        public void Vaciar() 
        {

            if (Vacia)
            {
                throw new Exception("Esta vacia");
            }

            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            nodoActual = NodoFinal;
            ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
            nodoPrevio = NodoFinal;

            do
            {
                nodoPrevio = nodoActual;
                nodoActual = nodoActual.Anterior;
                nodoPrevio = default;


            } while (nodoActual!=null);
            NodoInicial = null;
            NodoFinal = null; 
        }

        ~ClaseListaDobleOrdenada()
        {
            this.Vaciar();
        }

    }
}
