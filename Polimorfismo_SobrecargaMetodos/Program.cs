using System;

namespace Polimorfismo_SobrecargaMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calc = new Calculate();
            Console.WriteLine("\nPolimorfismo com sobrecarga\n");
            Console.WriteLine("Sum 2 numbers...");
            Console.WriteLine(calc.Sum(45,43));
            Console.WriteLine("Sum 3 numbers...");
            Console.WriteLine(calc.Sum(45, 43, 100 ));
            Console.ReadKey();
        }
    }
}
