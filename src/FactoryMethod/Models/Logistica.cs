using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{
    public abstract class Logistica
    {
        public abstract ITransporte FactoryMethod();

        public string PlanejarEntrega()
        {
            var transporte = FactoryMethod();

            var resultado = $"Logistica: o codigo do mesmo criador está trabalhando com {transporte.CriarTransporte()}";

            return resultado;
        }

    }
}
