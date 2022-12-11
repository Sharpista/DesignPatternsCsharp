using FactoryMethod.ConcreteCreator;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            VeiculoFactory? veiculoFactory = null;
            Console.WriteLine("Digite o veiculo que gostaria de buscar");
            var retorno = Console.ReadLine();

            switch (retorno?.ToLower())
            {
                case "motocicleta":
                    veiculoFactory = new MotocicletaFactory("Yamaha", "2022", "YZ250", "Vermelha");
                    break;
                case "caminhao":
                    veiculoFactory = new CaminhaoFactory("Volvo", "2011", "FH 520", "Branco");
                    break;
                case "carro":
                    veiculoFactory = new CarroFactory("Volkswagen", "2003", "Passat", "Verde");
                    break;
                default:
                    break;
            }

            Veiculo? veiculo = veiculoFactory?.BuscarVeiculo();

            Console.WriteLine("O veiculo buscado foi:");
            Console.WriteLine($"\n {veiculo?.Nome} | {veiculo?.Ano} | {veiculo?.Modelo} | {veiculo?.Ano} | {veiculo?.Cor}");


        }
    }
}
