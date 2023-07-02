using System;

namespace PJ_EstructuraSelectiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Dia;
            Console.Write("Ingrese el día en número: ");
            Dia = int.Parse(Console.ReadLine());

            // Estructura selectiva - switch
            switch (Dia)
            {
                // Si la variable optiene el valor de 1:
                case 1:
                    Console.WriteLine("El número de día ingresado equivale a un Lunes");
                    break; // Corta la continuidad que el valor siga verificando en los otros procesos o cases

                case 2:
                    Console.WriteLine("El número de día ingresado equivale a un Martes");
                    break;

                case 3:
                    Console.WriteLine("El número de día ingresado equivale a un Miércoles");
                    break;

                case 4:
                    Console.WriteLine("El número de día ingresado equivale a un Jueves");
                    break;

                case 5:
                    Console.WriteLine("El número de día ingresado equivale a un Viernes");
                    break;

                case 6:
                    Console.WriteLine("El número de día ingresado equivale a un Sábado");
                    break;

                case 7:
                    Console.WriteLine("El número de día ingresado equivale a un Domingo");
                    break;

                // Si el usuario escribe un número fuera de rango va a mostrar algo con el método default
                default:
                    Console.WriteLine("");
                    Console.WriteLine("El número ingresado es inválido o está fuera del rango");
                    break;
            }

            Console.ReadKey();
        }
    }
}
