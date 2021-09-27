using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonogramasDePelayo
{
    class Nonograma
    {
        public Linea[] Filas;
        public Linea[] Columnas;

        //Constructor que genera un nonograma con todas las casillas a estado 0 dado el tamaño
        public Nonograma(int intLongitud)
        {
            Filas = new Linea[intLongitud];
            Columnas = new Linea[intLongitud];
            for(int i = 0; i < intLongitud; i++)
            {
                Filas[i] = new Linea(intLongitud);
                Columnas[i] = new Linea(intLongitud);
            }
        }

        //Comprueba una casilla del Nonograma, devolviendo verdadero en caso de coincidir con el estado
        public bool ElegirCasilla (int intX, int intY, int intEstado)
        {
            return Columnas[intY].ObtenerCoincidenciaCasilla(intX, intEstado);
        }

        //Modifica una casilla del nonograma
        public void ModificarCasilla (int intX, int intY, int intEstado)
        {
            Columnas[intY].ModificarCasilla(intX, intEstado);
            Filas[intX].ModificarCasilla(intY, intEstado);
        }

        public static Nonograma LeerDeArchivo(string strNombreArchivo)
        {
            string[] lineas = System.IO.File.ReadAllLines(Application.StartupPath + "\\resources\\" + strNombreArchivo);
            Nonograma n = new Nonograma(lineas.Length);
            for(int i = 0; i < lineas.Length; i++)
            {
                string[] l = lineas[i].Split(' ');
                for(int j = 0; j < l.Length; j++)
                {
                    n.ModificarCasilla(i, j, Convert.ToInt32(l[j]));
                }
            }
            return n;
        }

        //Se emple para calcular el tamaño de los paneles
        public int ObtenerNumeroMaxmioBloquesFilas()
        {
            int max = 0;
            foreach(Linea l in Filas)
            {
                int tamañoL = l.ObtenerInformacionBloques().Count;
                if (tamañoL > max)
                {
                    max = tamañoL;
                }
            }
            return max;
        }

        public int ObtenerNumeroMaxmioBloquesColumnas()
        {
            int max = 0;
            foreach (Linea l in Columnas)
            {
                int tamañoL = l.ObtenerInformacionBloques().Count;
                if (tamañoL > max)
                {
                    max = tamañoL;
                }
            }
            return max;
        }

        //Devuelve la altura del nonograma
        public int Alto()
        {
            return Filas.Length ;
        }
        //Devuelve el ancho del nonograma
        public int Ancho()
        {
            return Columnas.Length ;
        }
        //Imprime por consola una representacion del nonograma
        public void Print()
        {
            Console.WriteLine("---------------------------------------");
            foreach(Linea f in Filas)
            {
                Console.WriteLine(f.ToString());
            }
            Console.WriteLine("---------------------------------------");
        }
        //Compara un nonograma a otro, devolviendo verdadero unícamente si el estado de todas las casillas coincide
        public bool Equals(Nonograma n)
        {
            if(this.Alto() != n.Alto() || this.Ancho() != n.Ancho())
            {
                Console.Error.WriteLine("Error: Se esta tratando de comparar dos nonogramas de distinto tamaño.");
                return false;
            }
            else
            {
                for(int i = 0; i < Alto(); i++)
                {
                    for(int j = 0; j < Ancho(); j++)
                    {
                        if(Filas[i].Casillas[j] != n.Filas[i].Casillas[j])
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
