using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{

    public class Caminhao : ITransporte
    {
        public string CriarTransporte()
        {
            return "Criou um Caminhão !";
        }
    }
}
