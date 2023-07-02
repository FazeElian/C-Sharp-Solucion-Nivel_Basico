using System;

namespace PJ_ConversionTiposDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definimos variables con sus tipos de dato
            string Nombre;
            int Edad;
            bool Casado;
            double Sueldo;

            Console.Write("Ingrese su Nombre: ");
            Nombre = Console.ReadLine();

            // Para cambiar el tipo de dato pongo el tipo de dato.Parse y leo la línea
            Console.Write("Ingrese su edad: ");
            Edad = int.Parse(Console.ReadLine()); 

            Console.Write("Se encuentra casad@?: ");
            Casado = bool.Parse(Console.ReadLine());

            Console.Write("De cuánto es tu sueldo?: ");
            Sueldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Tu nombre es " + Nombre + ", tienes " + Edad + " años, estás casado?: " + Casado + " y tu sueldo es de: " + Sueldo);

            Console.ReadKey();
        }
    }
}
