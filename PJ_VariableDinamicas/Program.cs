using System;

namespace PJ_VariableDinamicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creación varianle dinámica, recibe siempre información pero podemos recibir cualquier tipo de dato
            dynamic Contenido;
            Contenido = "Bienvenido a mi sistema";

            Console.WriteLine("Contenido: " + Contenido);

            Console.ReadKey();
        }
    }
}
