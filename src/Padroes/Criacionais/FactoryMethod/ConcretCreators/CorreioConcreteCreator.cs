using FactoryMethod.ConcretProducts;
using FactoryMethod.Creator;
using FactoryMethod.Factory;

namespace FactoryMethod.ConcretCreators
{
    public class CorreioConcreteCreator: Correio
    {
        public override ITransporteFactory FactoryMethodTrasporte()
        {
            return new TransporteConcreteProduct();
        }
    }
}
