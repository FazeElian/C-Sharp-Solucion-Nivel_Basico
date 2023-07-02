using System;

namespace PJ_OperadoresLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definimos variables
            int a, b, c, d;
            bool Resultado;

            a = 9;  
            b = 12;  
            c = 7;  
            d = 34;

            // Si A es igual a C y si B es diferente a D, por lo tanto será falso, esto porque almenos uno es falso
            Resultado = (a <= c) && (b == d);
            Console.WriteLine("El resultado de la operación lógica && (a == c) && (b != d) es: " + Resultado);
            
            // Si B es diferente a D y si A es mayor a D, por lo tanto será verdadero
            // Los dos lados de las operaciones tienen que ser verdaderos para que sea verdadero
            Resultado = (b != d) && (a > c);
            Console.WriteLine("El resultado de la operación lógica && (b == d) && (a > c) es: " + Resultado);

            // Si uno de ellos es verdadero el resultado será verdadero - Usando ó, or
            Resultado = (a < c) || (b != d); 
            Console.WriteLine("El resultado de la operación lógica || (a <= c) || (b == d) es: " + Resultado);

            // En este operador ! se está negando la operación, es decir si el resulado es falso, será verdadero
            Resultado = !(a == b);
            Console.WriteLine("El resultado de la operacíón lógica !(a == b) es: " + Resultado);

            Console.ReadKey();  
        }
    }
}