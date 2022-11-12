using System;

namespace Polimorfismo
{
    public class AirPlane : Car
    {
        public AirPlane(string tipoVeiculo)
            : base(tipoVeiculo)
        { }

        public override void Move()
        {
            Console.WriteLine("Decolando a aeronave");
        }
        public override void Stop()
        {
            Console.WriteLine("Estou aterrisando a aeronave.");
        }
    }
}
