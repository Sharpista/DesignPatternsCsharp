using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{
    public class Navio : ITransporte
    {
        public string CriarTransporte()
        {
            return "Criou um Navio !";
        }
    }
}
