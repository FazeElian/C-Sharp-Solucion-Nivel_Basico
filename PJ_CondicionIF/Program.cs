using System;

namespace PJ_CondicionIF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            double Sueldo;

            Console.Write("Ingresa tu nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Ingresa tu sueldo: ");
            Sueldo = double.Parse(Console.ReadLine());
            // Sueldo mínimo = 1200.25


            //Si la entrada que escribe el usuario en Sueldo es menor o igual a 1200.25 
            if (Sueldo <= 1200.25) 
            {
                // Va a mostrar su nombre y el mensaje: " Tienes un sueldo insuficiente
                Console.WriteLine("");
                Console.WriteLine(Nombre  + ", tienes un sueldo insuficiente");
            }
            else if (Sueldo>1200.25 && Sueldo <= 2000) // Sino si Sueldo es mayor a 1200.25 y menor o igual a 2000, entonces:
            {
                Console.WriteLine("");
                Console.WriteLine(Nombre  +  ", tienes un sueldo Promedio");
            }else if (Sueldo>2000) // Sino el sueldo es mayor a 2000, entonces:
            {
                Console.WriteLine("");
                Console.WriteLine(Nombre + ", tienes un sueldo suficiente, Felicidades!");
            }

            Console.ReadKey();
        }
    }
}
