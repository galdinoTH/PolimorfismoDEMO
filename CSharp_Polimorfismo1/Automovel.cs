using System;

namespace Polimorfismo
{
    public class Automovel : Car
    {
        public Automovel(string tipoVeiculo)
            : base(tipoVeiculo)
        { }

        public override void Move()
        {
 	        Console.WriteLine("Acelerando o veículo");
        }
        public override void Stop()
        {
            Console.WriteLine("Estou brecando o veículo.");
        }
    }
}
