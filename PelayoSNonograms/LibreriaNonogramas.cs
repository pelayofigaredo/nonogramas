using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonogramasDePelayo
{
    class LibreriaNonogramas
    {
        public Dictionary<int, InformacionNonograma> lista = new Dictionary<int, InformacionNonograma>();

        private Random r = new Random();

        private string path = "\\resources\\config.txt";

        //Constructor por defecto que carga la libreria desde el archivo de configuración
        public LibreriaNonogramas()
        {
            leerDeArchivo();
        }
        
        public void leerDeArchivo()
        {
            lista = new Dictionary<int, InformacionNonograma>();
            string[] listaDeNonogramas = System.IO.File.ReadAllLines(Application.StartupPath + path);

            for (int i = 0; i < listaDeNonogramas.Length; i++)
            {
                string[] l = listaDeNonogramas[i].Split('-');
                bool resuelto = true;
                if (l[3].Equals("0"))
                {
                    resuelto = false;
                }
                InformacionNonograma n = new InformacionNonograma(l[0],l[1],l[2],resuelto);
                lista.Add(i, n);
            }
        }

        public void Guardar()
        {
            StreamWriter file = new StreamWriter(Application.StartupPath + path);
            for (int i = 0; i < lista.Count; i++)
            {
                file.WriteLine(lista[i].ToString());
            }
            file.Close();
        }

        public void ResetearProgreso()
        {
            leerDeArchivo();
            StreamWriter file = new StreamWriter(Application.StartupPath + path);
            for (int i = 0; i < lista.Count; i++)
            {
                lista[i].setResuelto(false);
                file.WriteLine(lista[i].ToString());
            }
            file.Close();
        } 

        //Devuelve true si todos los nonogramas han sido completados
        public bool estanTodosResueltos()
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].getResuelto() == false)
                {
                    return false;
                }
            }
            return true;
        }

        public void MarcarComoResuelto(int  i)
        {
            lista[i].setResuelto(true);
            Guardar();
        }

        //Obtenedores
        public string ObtenerDireccion (int indice)
        {
            return lista[indice].getDireccion();
        }

        public string ObtenerTamaño(int indice)
        {
            return lista[indice].getTamaño();
        }

        public string ObtenerNombre(int indice)
        {
            return lista[indice].getNombre();
        }


        public bool obtenerResuelto(int indice)
        {
            return lista[indice].getResuelto();
        }

        //Busca el siguiente nonograma sin hacer despues del indice (inlullendo el indice), si todos estan resueltos se devuelve el del indice
        // si el indice es un numero negativo se genera un nuevo indice aleatorio
        public string direccionAleatoria (ref int indice)
        {
            if(indice < 0)
            {
                Random r = new Random();
                indice = r.Next(lista.Count - 1);
            }

            if(estanTodosResueltos())
            {
                return lista[indice].getDireccion();
            }
            else
            {
                while (true)
                {
                    if (lista[indice].getResuelto() == false)
                    {
                        return lista[indice].getDireccion();
                    }
                    indice++;
                    if(indice >= lista.Count)
                    {
                        indice = 0;
                    }
                }
            }  
        }
    }

    class InformacionNonograma
    {
        string direccion;
        string nombre;
        string tamaño;
        bool resuelto;

        public InformacionNonograma(string direccion,string nombre,string tamaño, bool resuelto)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.tamaño = tamaño;
            this.resuelto = resuelto;
        }

        public string getDireccion()
        {
            return direccion;
        }

        public string getTamaño()
        {
            return tamaño;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setResuelto (bool resuelto)
        {
            this.resuelto = resuelto;
        }

        public bool getResuelto()
        {
            return resuelto;
        }

        override public string ToString()
        {
            string t = direccion + "-" + nombre + "-" + tamaño + "-";
            if (resuelto)
            {
                t += "1";
            }
            else
            {
                t += "0";
            }
            return t;
        }
    }
}
