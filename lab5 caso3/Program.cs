using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_caso3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de notas: ");
            int notas = int.Parse(Console.ReadLine());

            int promedio;
            int suma = 0;
            for (int i = 1; i <= notas; i++) 
            {
                Console.Write("Ingrese la nota "+i+": ");
                int numero = int.Parse(Console.ReadLine());
                suma = suma + numero;
            }
             promedio =  suma/ notas;
            Console.Write("El promedio es: "+promedio);
            Console.ReadKey();
        }
    }
}
