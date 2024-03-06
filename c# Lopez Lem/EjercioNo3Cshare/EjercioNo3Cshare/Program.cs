using System;

namespace ConversionUnidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido al programa de conversión de unidades!");

          
            Console.Write("Por favor, introduzca la cantidad en kilómetros: ");
            double cantidadKilometros = Convert.ToDouble(Console.ReadLine());

            double cantidadMetros = cantidadKilometros * 1000;
            double cantidadYardas = cantidadKilometros * 1093.61;
            double cantidadVaras = cantidadKilometros * 1196.3;

            
            Console.WriteLine($"\n{cantidadKilometros} kilómetros es equivalente a:");
            Console.WriteLine($"{cantidadMetros} metros");
            Console.WriteLine($"{cantidadYardas} yardas");
            Console.WriteLine($"{cantidadVaras} varas");
            Console.ReadKey();
        }
    }
}