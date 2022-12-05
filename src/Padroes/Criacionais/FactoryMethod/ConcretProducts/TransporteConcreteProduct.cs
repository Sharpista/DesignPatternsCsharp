using FactoryMethod.Factory;
using FactoryMethod.ValueObjects;

namespace FactoryMethod.ConcretProducts
{
    public class TransporteConcreteProduct : ITransporteFactory
    {

        public string CriarTrasporte(TipoTransporte tipoTrasnporte)
        {
            switch (tipoTrasnporte)
            {
                case TipoTransporte.TREM:
                    return "Criou um transporte e está realizando uma entrega terrestre através de um TREM";
                case TipoTransporte.CAMINHAO:
                    return "Criou um transporte e está realizando uma entrega terrestre através de um  CAMINHÃO";
                case TipoTransporte.AVIAO:
                    return "Criou um transporte e está realizando uma entrega aerea através de um AVIÃO";
                default:
                    break;
            }
            return "Transporte Invalido";
            
        }
    }
}
