using System;

namespace PJ_Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creación de vector, nos permite añadir contenido por posiciones o índices (Iniciar desde =9
            string[] Nombres = {"Elián", "Ana", "Juan", "Verónica", "Luis", "Jorge"};
            Console.WriteLine("El  nombre del vector en la posición 5 es: " + Nombres[5]);

            // Utilizamos for para mostrar todo el contenido por su posición usando la variable x
            for (int x=0; x<Nombres.Length; x++)
            {
                Console.WriteLine("Contenido del vector Nombre en el índice " + x + " es: " + Nombres[x]);
            }


            // Con el atributo lengh puedo obtener la cantidad de elementos de un vector
            Console.WriteLine("");
            Console.WriteLine("La cantidad de elementos que tienen tu vector es: " + Nombres.Length);

            Console.ReadKey();
        }
    }
}
