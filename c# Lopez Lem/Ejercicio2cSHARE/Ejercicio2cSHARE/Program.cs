using System;

namespace Ejercicio2cSHARE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido al programa de cálculo de sueldo neto!");

            double sueldoBase;

            while (true)
            {
                Console.Write("Por favor, introduzca el sueldo base del empleado: ");
                if (double.TryParse(Console.ReadLine(), out sueldoBase))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error: ¡Por favor, ingrese un valor numérico válido!");
                }
            }

            
            double renta = sueldoBase * 0.10;
            double afp = sueldoBase * 0.07;
            double seguroSocial = sueldoBase * 0.05;

       
            double sueldoNeto = sueldoBase - renta - afp - seguroSocial;

           
            Console.WriteLine("\nResumen de Descuentos:");
            Console.WriteLine($"Renta (10%): {renta:C}");
            Console.WriteLine($"AFP (7%): {afp:C}");
            Console.WriteLine($"Seguro Social (5%): {seguroSocial:C}");
            Console.WriteLine("\nSueldo Neto a Pagar: " + sueldoNeto.ToString("C"));

            Console.ReadKey();
        }
    }
}
