using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteCreator
{
    public class CaminhaoFactory : VeiculoFactory
    {
        private string? _nome { get; set; }
        private string? _ano { get; set; }
        private string? _modelo { get; set; }
        private string? _cor { get; set; }

        public CaminhaoFactory(string? nome, string? ano, string? modelo, string? cor)
        {
            _nome = nome;
            _ano = ano;
            _modelo = modelo;
            _cor = cor;
        }

        public override Veiculo BuscarVeiculo()
        {
            return new Caminhao(_ano, _modelo, _nome, _cor);
        }
    }
}
