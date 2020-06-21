using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda
{
    class Program
    {
        static string[,] registro = new string[4, 10];
        static int contactos = 0;
        static int conteo = 0;

        static void Main(string[] args)
        {
            contactos = NoContacto();
            registro = new string[4, contactos];
            Console.WriteLine("\n");

            int m = 0;
            
            Console.WriteLine("...............................................");

            Console.WriteLine("Ingrese el numero de su opcion a elegir.");
            Console.WriteLine("1. Crear contacto");
            Console.WriteLine("2. Mostrar contactos");
            Console.WriteLine("3. Buscar contacto");
            Console.WriteLine("4. Modificar contacto");
            Console.WriteLine("5. Eliminar contacto");
            Console.WriteLine("6. Salir");
            Console.WriteLine("...............................................");
            int No = int.Parse(Console.ReadLine());

            while (true)
            {

                if (No == 1)
                {

                    Console.WriteLine("Ingrese nombre: ");
                    registro[0, m] = Console.ReadLine();


                    Console.WriteLine("Ingrese apellido: ");
                    registro[1, m] = Console.ReadLine();

                    Console.WriteLine("Ingrese dirección: ");
                    registro[2, m] = Console.ReadLine();


                    Console.WriteLine("Ingrese telefono: ");
                    registro[3, m] = Console.ReadLine();
                    m = m + 1;
                }

                if (No == 2)
                {
                    for (int e = 0; e <= contactos; e++)
                    {

                        Console.WriteLine(registro[0, e] + "__" + registro[1, e] + "__" + registro[2, e] + "__" + registro[3, e]);
                    }
                }


                if (No == 3)
                {
                    for (int r = 0; r < contactos; r++)
                    {
                        string usuario = "No encontrado";
                        string buscar = "";
                        Console.WriteLine("Ingrese el nombre del contacto a buscar: ");
                        buscar = Console.ReadLine();
                        if (buscar == registro[0, r])
                        {
                            usuario = registro[0, r] + "--" + registro[1, r] + "--" + registro[2, r] + "--" + registro[3, r];
                        }
                        Console.WriteLine(usuario);
                        Console.ReadKey();
                        break;
                    }
                }


                if (No == 4)
                {

                    Console.WriteLine("Escriba el nombre del contacto que desea modificar");
                    string mod = Console.ReadLine();
                    Modificar(mod);
                }


                if (No == 5)
                {
                    Console.WriteLine("Escriba el nombre del contacto que desea eliminar");
                    string eli = Console.ReadLine();
                    Eliminar(eli);
                }

                if (No == 6)
                {
                    Console.Clear();
                }
                Console.ReadKey();
            }      
           
        }

        static int NoContacto()
        {

            Console.Write("cuantos contactos quiere agregar: ");
            return int.Parse(Console.ReadLine());

        }


        static string pedirDatos(string linea)
        {
            string dato = "";
            dato = "ingrese" + linea + ":";
            return dato;
        }

        static void guardarContacto()
        {
            if (conteo < contactos)
            {
                Console.Write(pedirDatos("\nNombre"));
                registro[0, conteo] = Console.ReadLine();

                Console.Write(pedirDatos("Apellido"));
                registro[1, conteo] = Console.ReadLine();

                Console.Write(pedirDatos("Dirección"));
                registro[2, conteo] = Console.ReadLine();

                Console.Write(pedirDatos("Teléfono"));
                registro[3, conteo] = Console.ReadLine();
                Console.WriteLine("\n");

                conteo++;
            }
            else
            {
                Console.WriteLine("AGENDA LLENA\n");
            }

        }

        static void Modificar(string mod)
        {
            string buscar = "";
            Console.Write("Ingrese el nombre del contacto a eliminar: ");
            buscar = Console.ReadLine();

            for (int e = 0; e < contactos; e++)
            {

                if (buscar == registro[0, e])
                {
                    Console.Write(pedirDatos("Nombre"));
                    registro[0, e] = Console.ReadLine();

                    Console.Write(pedirDatos("Apellido"));
                    registro[1, e] = Console.ReadLine();

                    Console.Write(pedirDatos("Dirección"));
                    registro[2, e] = Console.ReadLine();

                    Console.Write(pedirDatos("Teléfono\n"));
                    registro[3, e] = Console.ReadLine();
                }
            }
        }

        static void Eliminar(string x)
        {
            string buscar = "";
            Console.Write("Ingrese el nombre del contacto a eliminar: ");
            buscar = Console.ReadLine();

            for (int e = 0; e < contactos; e++)
            {
                if (buscar == registro[0, e])
                {
                    registro[0, e] = "";
                    registro[1, e] = "";
                    registro[2, e] = "";
                    registro[3, e] = "";
                }
            }

        }



    }

}
