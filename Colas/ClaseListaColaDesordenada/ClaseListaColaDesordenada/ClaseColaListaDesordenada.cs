using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseListaColaDesordenada
{
    class ClaseColaListaDesordenada<Tipo> where Tipo : IEquatable<Tipo>
    {
        private ClaseNodo<Tipo> _frente;

        private ClaseNodo<Tipo> Frente
        {
            get { return _frente; }
            set { _frente = value; }
        }
        private ClaseNodo<Tipo> _final;

        private ClaseNodo<Tipo> Final
        {
            get { return _final; }
            set { _final = value; }
        }

        public ClaseColaListaDesordenada()
        {
            Frente = null;
            Final = null;
        }

        public bool Vacia
        {
            get {
                if (Final == null && Frente==null)
                {
                    return true;
                }
                return false;
            }
        }

        public IEnumerator<Tipo> GetEnumerator() 
        {
            if (Vacia)
            {
                yield break;
            }

            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            nodoActual = Frente;

            do
            {
                yield return (nodoActual.ObjetoConDatos);
                nodoActual = nodoActual.Siguiente;
            } while (nodoActual != null); ;

            yield break;

        }

        public void Encolar(Tipo objeto) 
        {
            ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();
            //El primerito
            if (Vacia)
            {
            nodoNuevo = new ClaseNodo<Tipo>();
                nodoNuevo.ObjetoConDatos = objeto;
                Frente = nodoNuevo;
                Final = nodoNuevo;
                return;
            }

            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
            nodoActual = Frente;
            nodoPrevio = Frente;
            //Si existe
            do
            {
                if (nodoActual.ObjetoConDatos.Equals(objeto))
                {
                    throw new Exception("Objeto duplicado");
                }
                nodoPrevio = nodoActual;
                nodoActual = nodoActual.Siguiente;
                    
            } while (nodoActual != null);
            //El ultimo
           nodoNuevo = new ClaseNodo<Tipo>();
            nodoNuevo.ObjetoConDatos = objeto;
            nodoPrevio.Siguiente = nodoNuevo;
            Final = nodoNuevo;

        }


        public Tipo Desencolar() 
        {

            if (Vacia)
            {
                throw new Exception("No existen datos");
            }

            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            ClaseNodo<Tipo> nodoEliminado = new ClaseNodo<Tipo>();
            nodoActual = Frente;

            if (nodoActual.Equals(Final))
            {
                nodoEliminado = nodoActual;
                nodoActual = default;
                Frente = null;
                Final = null;
                return nodoEliminado.ObjetoConDatos;
            }
            nodoEliminado = nodoActual;
            Frente = nodoActual.Siguiente;
            nodoActual = default;
            return nodoEliminado.ObjetoConDatos;
            


        }
        public Tipo Desencolar(Tipo objeto) 
        {
            if (Vacia)
            {
                throw new Exception("No existen datos");
            }
            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
            ClaseNodo<Tipo> nodoEliminado = new ClaseNodo<Tipo>();
            nodoActual = Frente;

            do
            {

                if (nodoActual.ObjetoConDatos.Equals(objeto))
                {
                    if (nodoActual.Equals(Frente) && nodoActual.Equals(Final))
                    {
                        Desencolar();
                    }
                    if (nodoActual.Equals(Frente))
                    {
                        Desencolar();
                    }
                    if (nodoActual.Equals(Final))
                    {
                        nodoEliminado = nodoActual;
                        Final = nodoPrevio;
                        nodoActual = default;
                        return (nodoEliminado.ObjetoConDatos);

                    }
                    nodoPrevio.Siguiente = nodoActual.Siguiente;
                    nodoEliminado = nodoActual;
                    nodoActual = default;
                    return (nodoEliminado.ObjetoConDatos);

                }
                nodoPrevio = nodoActual;
                nodoActual = nodoActual.Siguiente;



            } while (nodoActual!=null);
            throw new Exception("Datos no encontrado");
        }

        public Tipo Buscar(Tipo objeto) 
        {

            if (Vacia)
            {
                throw new Exception("Datos no encontrados");
            }

            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            nodoActual = Frente;
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

        public void Vaciar() 
        {
            if (Vacia)
            {
                return;
            }
            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
            nodoActual = Frente;

            do
            {
                nodoPrevio = nodoActual;
                nodoActual = nodoActual.Siguiente;
                nodoPrevio = default;

            } while (nodoActual!=null);
            Frente = null;
            Final = null;


        }








        ~ClaseColaListaDesordenada()
            {
            this.Vaciar();
        }



    }
}
