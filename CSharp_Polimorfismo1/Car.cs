namespace Polimorfismo
{
    public class Car
    {
        private string tipo;
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public Car(string tipoVeiculo)
        {
            this.tipo = tipoVeiculo;
        }

        public virtual void Move()
        { }

        public virtual void Stop()
        { }
    }
}
