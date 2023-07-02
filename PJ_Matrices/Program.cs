using System;

namespace PJ_Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creación de matriz
            string[,] Persona = new string[3, 2];

            // Añadiendo contenido a cada posición en columna y fila o celda
            Persona[0, 0] = "Nombre:";
            Persona[0, 1] = "Elian";

            Persona[1, 0] = "Apellido:";
            Persona[1, 1] = "Ibarra";

            Persona[2, 0] = "Apodo:";
            Persona[2, 1] = "Eliancho";

            for (int a = 0; a < 3; a++)
            {
                Console.WriteLine("Columna [" + a + "] = " + Persona[a, 0] + " " + Persona[a, 1]);   
            }
            Console.ReadKey();
        }
    }
}
