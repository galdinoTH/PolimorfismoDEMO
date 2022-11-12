using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] veiculo = new Car[2];

            veiculo[0] = new Automovel("Ferrari");
            veiculo[1] = new AirPlane("Tucano");

            MovimentarVeiculo(veiculo[0]);
            MovimentarVeiculo(veiculo[1]);
            Console.ReadKey();
        }

        public static void MovimentarVeiculo(Car veiculo)
        {
            Console.WriteLine(veiculo.Tipo);
            veiculo.Move();
        }
    }
}
