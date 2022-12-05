using FactoryMethod.Factory;
using FactoryMethod.ValueObjects;

namespace FactoryMethod.Creator
{
    public abstract class Correio
    {
        public abstract ITransporteFactory FactoryMethodTrasporte();


        public string RealizarEntrega(TipoTransporte tipoTrasporte)
        {
            var produto = FactoryMethodTrasporte();

            var result = $"Criador: o codigo do mesmo criador está trabalhando e {produto.CriarTrasporte(tipoTrasporte)}";

            return result;

        }
    }
}
