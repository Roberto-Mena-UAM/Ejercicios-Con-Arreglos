using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Con_Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rangosSalarios = new int[9];

            Console.WriteLine("Ingresa el numero de vendedores: ");
            int numeroVnededores = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeroVnededores; i++)
            {
                Console.WriteLine($"Ingrese las ventas brutas del vendedor {i + 1}: ");
                decimal ventasBrutas = decimal.Parse(Console.ReadLine());

                decimal salario = 200 + (ventasBrutas * 0.09m);

                int salarioEnteros = (int)salario;

                if (salarioEnteros >= 1000)
                {
                    rangosSalarios[8]++;
                }

                else if (salarioEnteros >= 900)
                {
                    rangosSalarios[7]++;
                }
                else if (salarioEnteros >= 800)
                {
                    rangosSalarios[6]++;
                }
                else if ( salarioEnteros >= 700)
                {
                    rangosSalarios[5]++;
                }
                else if ( salarioEnteros >= 600)
                {
                    rangosSalarios[4]++;
                }
                else if ( salarioEnteros >= 500)
                {
                    rangosSalarios[3]++;
                }
                else if ( salarioEnteros >= 400)
                {
                    rangosSalarios[2]++;
                }
                else if ( salarioEnteros >= 300)
                {
                    rangosSalarios[1]++;
                }
                else if ( salarioEnteros >= 200)
                {
                    rangosSalarios[0]++;
                }
                Console.WriteLine("\nDistribució de salario: ");
                Console.WriteLine($"$200 - $299: {rangosSalarios[0]} vendedores");
                Console.WriteLine($"$300 - $399:{rangosSalarios[1]} vendedores");
                Console.WriteLine($"$400 - $499: {rangosSalarios[2]} vendedores");
                Console.WriteLine($"$500 - $599: {rangosSalarios[3]} vendedores");
                Console.WriteLine($"$600 - $699: {rangosSalarios[4]} vendedores");
                Console.WriteLine($"$700 - $799: {rangosSalarios[5]} vendedores");
                Console.WriteLine($"$800 - $899: {rangosSalarios[6]} vendedores");
                Console.WriteLine($"$900 - $999: {rangosSalarios[7]} vendedores");
                Console.WriteLine($"$1000 o superior {rangosSalarios[8]} vendedores");
                Console.ReadKey();
            }
        }
    }
}
