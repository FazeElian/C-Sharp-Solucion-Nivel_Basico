using System;

namespace PJ_EstructuraDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num;
            Num = 0;

            // Ejecuta un primer proceso y luego pregunta o evalúa
            do { // Haz Esto:
                Console.WriteLine("El valor de la variable Num es: " + Num);
                Num++; // Autoincrementador 1 por 1
            } while (Num <= 10); // Mientras Num sea menor o igual a 10

            Console.ReadKey();
        }
    }
}
