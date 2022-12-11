namespace FactoryMethod.Product
{
    public abstract class Veiculo
    {
        public string? Ano { get; set; }
        public string? Modelo { get; set; }
        public string? Nome { get; set; }
        public string? Cor { get; set; }

        protected Veiculo(string? ano, string? modelo, string? nome, string? cor)
        {
            Ano = ano;
            Modelo = modelo;
            Nome = nome;
            Cor = cor;
        }
    }
}
