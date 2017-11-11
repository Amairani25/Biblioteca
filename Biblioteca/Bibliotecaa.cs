using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Bibliotecaa
    {
        List<Libro> l = new List<Libro>();

        public int cont = 0;
        public string Nombre { get; set; }


        public Bibliotecaa(string Nombre)
        {
            this.Nombre = Nombre;

        }
        public void Agregar(string nomb, string edit, string aut)
        {
            Libro l1 = new Libro(nomb, edit, aut);
            l.Add(l1);
            cont++;

        }
        public void Consultar(string a)
        {
            bool f = true;
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i].Nombre == a)
                {
                    Console.WriteLine("Se encontro " + l[i].Nombre);
                }
                if (l[i].Nombre != a)
                {
                    if (f == true)
                    {
                        Console.WriteLine("No se encontro " + l[i].Nombre);
                        f = false;
                    }
                }
            }

        }
    }
}
