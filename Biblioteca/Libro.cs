using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Libro
    {
        public string Nombre { get; set; }
        public string Editorial { get; set; }
        public string Autor { get; set; }
        public Libro(string n, string e, string a)
        {
            Nombre = n;
            Editorial = e;
            Autor = a;
        }
    }
}
