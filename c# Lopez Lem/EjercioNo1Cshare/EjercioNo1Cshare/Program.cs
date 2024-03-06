using System;

namespace CalculoPromedioVentas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido al programa de cálculo de promedio de ventas mensuales!");


            Console.Write("Por favor, introduzca su nombre: ");
            string nombreVendedor = Console.ReadLine();

            Console.Write("Ahora, introduzca su apellido: ");
            string apellidoVendedor = Console.ReadLine();


            double[] ventasPorMes = new double[12];
            double totalVentas = 0;

            for (int i = 0; i < 12; i++)
            {
                Console.Write($"Ingrese las ventas del mes {(i + 1)}: ");
                ventasPorMes[i] = Convert.ToDouble(Console.ReadLine());
                //totalVentas += ventasPorMes[i];
            }


            //double totalVentas = 0;
            foreach (double venta in ventasPorMes)
            {
                totalVentas += venta;
            }

            double promedioVentas = totalVentas / 12;


            Console.WriteLine($"El promedio de ventas mensuales de {nombreVendedor} {apellidoVendedor} es: {promedioVentas:C}");


            Console.ReadKey();
        }
    }
}