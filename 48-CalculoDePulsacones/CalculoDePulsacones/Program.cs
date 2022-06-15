using System;

namespace CalculoDePulsacones
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Calcular el número de pulsaciones que una persona debe tener por cada 10 segundos de ejercicio,
             * si la formula es: num.pulsaciones = (220 - edad) / 10*/

            Console.WriteLine("Bienvenido al medidor de pulsaciones: ");

            Console.WriteLine("Ingrese la edad para determinar el numero de pulsaciones que debe tener:");
            int edad = Convert.ToInt32(Console.ReadLine());

            CalculoDePulsaciones pulsaciones = new CalculoDePulsaciones();

            Console.WriteLine("Su numero de pulsaciones por minuto de acuerdo a su es edad debe ser: " + pulsaciones.CalculoDePulsion(edad));

            Console.ReadKey();
        }
    }
}
