using FactoryMethod.Product;

namespace FactoryMethod.ConcreteProduct
{
    public class Carro : Veiculo
    {
        public Carro(string? ano, string? modelo, string? nome, string? cor) : base(ano, modelo, nome, cor)
        {
        }
    }
}
