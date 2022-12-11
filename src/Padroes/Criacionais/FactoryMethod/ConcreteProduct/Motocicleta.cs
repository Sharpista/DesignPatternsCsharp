using FactoryMethod.Product;

namespace FactoryMethod.ConcreteProduct
{
    public class Motocicleta : Veiculo
    {
        public Motocicleta(string? ano, string? modelo, string? nome, string? cor) : base(ano, modelo, nome, cor)
        {
        }
    }
}
