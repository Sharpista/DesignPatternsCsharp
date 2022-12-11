using FactoryMethod.Product;

namespace FactoryMethod.ConcreteProduct
{
    public class Caminhao : Veiculo
    {
        public Caminhao(string? ano, string? modelo, string? nome, string? cor) : base(ano, modelo, nome, cor)
        {
        }
    }
}
