using System;

namespace PJ_InstruccionFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NumEntero;
            NumEntero = 0;

            Console.Write("Ingrese un número para definir la Tabla de Sumar: ");
            NumEntero = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++) { // La variable se va a ejecutar mientras i sea menor o igual a 10 y lo vaya incrementando a 1
                // Ejecutamos un proceso
                Console.WriteLine(NumEntero + " + " + i + " = " + (NumEntero + i));
            }


            Console.ReadKey();
        }
    }
}
