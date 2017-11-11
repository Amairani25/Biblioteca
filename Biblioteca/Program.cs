using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Program
    {
        static byte a;
        static void Main(string[] args)
        {

            string c = "";
            string nom = "";
            string edit = "";
            string aut = "";
            Console.WriteLine("Ingresa el nombre de la primer biblioteca");
            c = Console.ReadLine();
            Bibliotecaa b1 = new Bibliotecaa(c);
            Console.WriteLine("Ingrese el nombre de la segunda biblioteca");
            c = Console.ReadLine();
            Bibliotecaa b2 = new Bibliotecaa(c);
            Console.WriteLine("Ingrese el nombre de la tercera biblioteca");
            c = Console.ReadLine();
            Bibliotecaa b3 = new Bibliotecaa(c);

            do
            {
                Menu();
                switch (a)
                {
                    case 1:
                        Console.WriteLine("En cual biblioteca quieres agregar");
                        c = Console.ReadLine();
                        if (c == b1.Nombre)
                        {
                            Console.WriteLine("Ingrese el titulo del libro");
                            nom = Console.ReadLine();
                            Console.WriteLine("Ingrese la editorial");
                            edit = Console.ReadLine();
                            Console.WriteLine("Ingrese el autor");
                            aut = Console.ReadLine();

                            b1.Agregar(nom, edit, aut);
                        }
                        if (c == b2.Nombre)
                        {
                            Console.WriteLine("Ingrese el titulo del libro");
                            nom = Console.ReadLine();
                            Console.WriteLine("Ingrese la editorial");
                            edit = Console.ReadLine();
                            Console.WriteLine("Ingrese el autor");
                            aut = Console.ReadLine();

                            b2.Agregar(nom, edit, aut);
                        }
                        if (c == b3.Nombre)
                        {
                            Console.WriteLine("Ingrese el titulo del libro");
                            nom = Console.ReadLine();
                            Console.WriteLine("Ingrese la editorial");
                            edit = Console.ReadLine();
                            Console.WriteLine("Ingrese el autor");
                            aut = Console.ReadLine();

                            b3.Agregar(nom, edit, aut);
                        }
                        break;
                    case 2:
                        Console.WriteLine("¿Cual biblioteca quieres consultar?");
                        c = Console.ReadLine();
                        if (c == b1.Nombre)
                        {
                            Console.WriteLine("Ingresa el titulo del libro");
                            nom = Console.ReadLine();
                            b1.Consultar(nom);
                        }
                        if (c == b2.Nombre)
                        {
                            Console.WriteLine("Ingresa el titulo del libro");
                            nom = Console.ReadLine();
                            b2.Consultar(nom);
                        }
                        if (c == b3.Nombre)
                        {
                            Console.WriteLine("Ingresa el  titulo del libro");
                            nom = Console.ReadLine();
                            b2.Consultar(nom);
                        }
                        break;


                }

            }
            while (a != 0);

        }

        static void Menu()
        {

            Console.WriteLine("Elija una opcion:");
            Console.WriteLine(" 1-Agregar \n 2-Consultar");
            a = byte.Parse(Console.ReadLine());

        }
    }
}