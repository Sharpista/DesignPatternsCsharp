using FactoryMethod.ConcretProducts;
using FactoryMethod.ValueObjects;

namespace FactoryMethod.Factory
{
    public interface ITransporteFactory
    {
        string CriarTrasporte(TipoTransporte tipoTrasnporte);
    }
}
