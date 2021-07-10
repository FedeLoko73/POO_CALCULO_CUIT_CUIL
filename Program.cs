using System;
using System.Collections.Generic;
using System.Text;

namespace prog_orientada_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            int cadena1;
            float cadena2;
            persona p1;
            p1 = new persona();
            Console.WriteLine("Ingrese Apellido: ");
            p1.apellido = Console.ReadLine();
            Console.WriteLine("Ingrese Nombre: ");
            p1.nombre=Console.ReadLine();
            Console.WriteLine("Ingrese dni: ");
            cadena=Console.ReadLine();
            while (int.TryParse(cadena, out cadena1)==false)
            {
                Console.WriteLine("formato incorrecto, vuelva a ingresar: ");
                cadena=Console.ReadLine();
            }
            p1.dni = cadena1;
            Console.WriteLine("Ingrese sexo M/F: ");
            p1.sexo=Console.ReadKey().KeyChar;
            Console.WriteLine("Ingrese Categoria: ");
            p1.cat=Console.ReadLine();
            Console.WriteLine("Ingrese salario:");
            cadena=Console.ReadLine();
            while(float.TryParse(cadena, out cadena2)==false)
            {
                Console.WriteLine("formato incorrecto, vuelva a ingresar: ");
                cadena=Console.ReadLine();
            }
            p1.salario = cadena2;
            Console.Clear();
            Console.WriteLine(p1.legajo);
            Console.WriteLine(p1.nombre +" "+p1.apellido);
            Console.WriteLine("dni: "+p1.dni);
            Console.WriteLine("salario: "+p1.salario);
            Console.WriteLine("categoria: "+p1.cat);
            Console.WriteLine("cuil: " + p1.cuil);
            
            Console.ReadKey();
        }
    }
}
