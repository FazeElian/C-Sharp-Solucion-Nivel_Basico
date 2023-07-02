using System;

namespace DatosPrimitivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definir tipo de dato de variable edad
            int edad;
            string nombre;
            double sueldo;
            bool casado;

            Console.Write("Cuál es tu nombre? :  ");
            // Guarda la información recibida en la variable nombre
            nombre = Console.ReadLine(); // ReadLine Recibe datos solo tipo string

            Console.Write("Cuál es tu edad? :  "); 
            edad = Convert.ToInt32(Console.ReadLine()); // Convierto la entrada de datos a tipo entero

            Console.Write("De cuánto es tu sueldo? :  ");
            sueldo = Convert.ToDouble(Console.ReadLine()); // Convierto la entrada de datos a tipo moneda - double
            

            Console.Write("Te encuentras casad@? : ");
            casado = Convert.ToBoolean(Console.ReadLine()); // Convierto la entrada de datos a a tipo booleano


            // Impresión de los datos obtenidos por entradas de datos
            Console.WriteLine("Tu Nombre es " + nombre + ", tienes " + edad + " años, tu sueldo es de: " + sueldo + " y estás casado? :" + casado);

            // Hace que la ventana no se cierre la ventana al iniciar hasta que se presione una tecla
            Console.ReadKey();

            // Recibe la información que recibe por teclado - input
            //Console.ReadLine();
        }
    }
}