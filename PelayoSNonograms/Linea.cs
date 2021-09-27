using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonogramasDePelayo
{
    class Linea
    {
        public int[] Casillas;


        public Linea(int[] intCasillas)
        {
            this.Casillas = intCasillas;
        }

        //Constructor que genera una linea, con todos los estados a 0, dada su longitud
        public Linea(int intLongitud)
        {
            this.Casillas = new int[intLongitud];
        }

        //Devuelve la longitud de la linea
        public int Longitud()
        {
            return Casillas.Length;
        }

        //Comprueba que una posicion de la linea contenga un estado concreto
        public bool ObtenerCoincidenciaCasilla (int intIndice, int intEstado)
        {
            if(Casillas[intIndice] == intEstado)
            {
                return true;
            }
            return false;
        }

        //Compara la linea con otra linea recivida como parametro, devuelve verdadero si coinciden a la perfeccion
        public bool ObtenerCoincidenciaLinea (Linea lnResuelta)
        {
            if(lnResuelta.Longitud() == this.Longitud())
            {
                for(int i = 0; i < lnResuelta.Longitud(); i++)
                {
                    if(Casillas[i] != lnResuelta.Casillas[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                Console.WriteLine("Atencion! Se han comparado dos lineas de diferente longitud");
                return false;
            }
        }

        //Cambia el estado de una de las casillas
        public void ModificarCasilla(int intIndice, int intEstado)
        {
            Casillas[intIndice] = intEstado;
        }

        //Devuelve un string que contiene las longitudes de los bloques de un determinado estado, separados por comas
        public string ObtenerInformacionBloques(int intEstado)
        {
            string s = "";
            int BloqueActual = 0;
            for(int i = 0; i < Casillas.Length; i++)
            {
                if(Casillas[i] != intEstado && BloqueActual != 0)
                {
                    s += " " + BloqueActual;
                    BloqueActual = 0;
                }
                else if(Casillas[i] == intEstado)
                {
                    BloqueActual++;
                }
            }
            if(BloqueActual != 0)
            {
                s += " " + BloqueActual;
            }
            return s;
        }

        //Devuelve una lista de bloques con estados y tamaños
        public List<Bloque> ObtenerInformacionBloques()
        {
            List<Bloque> bloques = new List<Bloque>();

            int tamañoActual = 0;
            int estadoActual = 0;

            for (int i = 0; i < Casillas.Length; i++)
            {
                if (estadoActual == 0)
                {
                    if (Casillas[i] != 0)
                    {
                        tamañoActual++;
                        estadoActual = Casillas[i];
                    }
                }
                else
                {
                    if (Casillas[i] == estadoActual)
                    {
                        tamañoActual++;
                    }
                    else
                    {
                        if (Casillas[i] == 0)
                        {
                            bloques.Add(new Bloque(estadoActual, tamañoActual));
                            estadoActual = 0;
                            tamañoActual = 0;
                        }
                        else
                        {
                            bloques.Add(new Bloque(estadoActual, tamañoActual));
                            estadoActual = Casillas[i];
                            tamañoActual = 1;
                        }
                    }
                   
                }
                if(i+1 == Casillas.Length && estadoActual != 0)
                {
                    bloques.Add(new Bloque(estadoActual, tamañoActual));
                    estadoActual = 0;
                    tamañoActual = 0;
                }
            }
                return bloques;
        }

        override
        public string ToString()
        {
            string s = "[";
            for(int i = 0; i < Casillas.Length; i++)
            {
                s += " " + Casillas[i] + " ";
            }
            s += "]";
            return s;
        }
    }

    class Bloque
    {
       public int estado;
       public int tamaño;
       
        public Bloque(int estado, int tamaño)
        {
            this.estado = estado;
            this.tamaño = tamaño;
        }
    }
}
