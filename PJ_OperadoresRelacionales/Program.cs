using System;

namespace PJ_OperadoresRelacionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definimos más de una variable como entero
            int Num1, Num2;

            // Definimos la variable Operaciones como booleano
            bool Operaciones;

            Num1 = 8;
            Num2 = 8;

            // Es bueno utilizar paréntesis en las operaciones entre variable para cerrar una primera operación
            // en caso de que sea más de una operación
            Operaciones = (Num1 != Num2);

            // Si el número 1 es mayor que el número 2
            Console.WriteLine("El número 1 = " + Num1 + " es menor que el número 2 = " + Num2 + " ? " + (Num1 > Num2));
            
            // Si el número 1 es mayor o igual al número 2
            Console.WriteLine("El número 1 = " + Num1 + " es menor que el número 2 = " + Num2 + " ? " + (Num1 >= Num2));

            // Si el número 1 es mayor o igual al número 2 Pero reemplazamos la operación directamente guardandola en
            // una variable "Operaciones"
            Console.WriteLine("El número 1 = " + Num1 + " es menor que el número 2 = " + Num2 + " ? " + Operaciones);

            Console.ReadKey();
        }
    }
}
