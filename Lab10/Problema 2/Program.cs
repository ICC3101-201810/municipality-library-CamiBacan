using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Problema_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly archivoAssembly = Assembly.LoadFile(@"C:\Users\csepu\Desktop\municipality-library-CamiBacan\ClassLibrary1.dll");
            foreach (Type type in archivoAssembly.GetTypes())
            {
                if (type.IsClass)
                {
                    Console.WriteLine("Clase: " + type.Name);

                    foreach (PropertyInfo att in type.GetProperties())
                    {
                        Console.WriteLine("\tAtributos: " + att.Name + "({0})", att.PropertyType.Name);
                    }
                    foreach (MethodInfo meth in type.GetMethods())
                    {
                        Console.WriteLine("\t\tMetodos: " + meth.Name);
                        ParameterInfo[] parameters = meth.GetParameters();
                        Console.WriteLine("\t\tParametros: ");
                        foreach (ParameterInfo par in parameters)
                        {
                            Console.WriteLine("\t\t\t" + par.ParameterType.Name);
                        }
                        Console.WriteLine("\t\tRetorna: " + meth.ReturnType.Name);
                        Console.WriteLine("\n\n");
                    }


                }
                else if (type.IsInterface)
                {
                    Console.WriteLine("Interfaz: " + type.Name);


                }



            } //Reflection
        }
    }
}
