using System;

namespace PJ_Variables_constantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            int Edad;

            // Definición variable tipo constante, es decir no cambia durante todp el proceso
            // Si yo trato de realizar una operación para cambiar el valor de una variable constante, saldría
            // un error puesto que al ser constante no debe cambiar
            const double Sueldo = 1500.25;


            Nombre = "Elián";
            Edad = 14;

            Console.WriteLine("Mi nombre es: " + Nombre + ", mi edad es de: " +  Edad + " y mi sueldo fijo es de: " + Sueldo);

            Console.ReadKey();
        }
    }
}
