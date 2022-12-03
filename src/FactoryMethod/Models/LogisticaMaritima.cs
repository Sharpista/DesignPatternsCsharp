using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{
    public class LogisticaMaritima : Logistica
    {
        public override ITransporte FactoryMethod()
        {
            return new Navio();
        }
    }
}
