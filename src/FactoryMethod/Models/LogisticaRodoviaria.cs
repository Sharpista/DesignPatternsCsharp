using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{
    public class LogisticaRodoviaria : Logistica
    {
        public override ITransporte FactoryMethod()
        {
            return new Caminhao();
        }
    }
}
