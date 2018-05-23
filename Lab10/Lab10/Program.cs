using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using ClassLibrary1;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\t\tBienvenido a la municipalidad");
                Console.WriteLine("1. Inscribir personas\n2. Inscribir propiedades\n3. Inscribir automoviles");
                string ans = Console.ReadLine();
                if (ans == "1")
                {
                    Console.Clear();
                    Console.WriteLine("\tIngrese nombre: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("\tApellido: ");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("\tAño nacimiento: ");
                    string a = Console.ReadLine();
                    int ano = Int32.Parse(a);
                    Console.WriteLine("\tMes nacimiento: ");
                    string b = Console.ReadLine();
                    int mes = Int32.Parse(a);
                    Console.WriteLine("\tDia nacimiento: ");
                    string c = Console.ReadLine();
                    int dia = Int32.Parse(a);
                    DateTime fechaNac = new DateTime(ano, mes, dia);
                    Console.WriteLine("\tDireccion (si no posee ninguna, presione ENTER): ");
                    string d;
                    ConsoleKeyInfo response = Console.ReadKey(true);
                    Address address;
                    if (response.Key == ConsoleKey.Enter)
                    {
                        d = null;
                        address = null;
                    }
                    else
                    {
                        Console.WriteLine("\t\tStreet: ");
                        string str = Console.ReadLine();
                        Console.WriteLine("\t\tNumber: ");
                        string n = Console.ReadLine();
                        int num = Int32.Parse(n);
                        Console.WriteLine("\t\tCommune: ");
                        string comm = Console.ReadLine();
                        Console.WriteLine("\t\tCity: ");
                        string city = Console.ReadLine();
                        Console.WriteLine("\t\tAño de construccion: ");
                        int anoConstr = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\t\tNumero de piezas: ");
                        int piezas = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\t\tNumero de ba;os: ");
                        int banos = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\t\tTiene patio? (true or false): ");
                        string patio = Console.ReadLine();
                        bool jardin = false;
                        patio.ToLower();
                        if (patio == "true")
                        {
                            jardin = true;
                        }
                        //Console.WriteLine("\t\tOwner: ");

                        address = new Address(str, num, comm, city, null, anoConstr, piezas, banos, jardin, false);
                    }

                    Console.WriteLine("\tRut: ");
                    string rut = Console.ReadLine();

                    Person person = new Person(nombre, apellido, fechaNac, address, rut, null, null);


                }
            }

            Console.ReadLine();
        }
    }
}
