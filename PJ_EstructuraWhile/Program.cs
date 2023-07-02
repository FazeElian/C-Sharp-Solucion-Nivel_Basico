using System;

namespace PJ_EstructuraWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Correlativo;
            Correlativo = 0;

            // Mientras la variable Correlativo sea menor a 20 hacer:
            while (Correlativo < 20)
            {
                Correlativo++; // Autoincrementador por 1
                Console.WriteLine("5 x " + Correlativo + " = " + (5 * Correlativo)); // Va a multiplicar 5 x 1-20, algo así como una tabla de multiplicar
            }

            Console.ReadKey();  
        }
    }
}
