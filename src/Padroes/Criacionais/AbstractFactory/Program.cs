using AbstractFactory;
using AbstractFactory.ConcreteFactory;
using AbstractFactory.Interfaces;

public class Program
{
    private static void Main(string[] args)
    {
        ICelular xiaomiCelular = new XiaomiFactory();
        CelularClient xiaomiClient = new CelularClient(xiaomiCelular);

        Console.WriteLine("****************** XIAOMI ******************");
        Console.WriteLine(xiaomiClient.BuscarSmartPhoneModeloDetalhes());
        Console.WriteLine(xiaomiClient.BuscarNormalPhoneModeloDetalhes());


        ICelular samsungCelular = new SamsungFactory();
        CelularClient samsungClient = new CelularClient(samsungCelular);

        Console.WriteLine("****************** SAMSUNG ******************");
        Console.WriteLine(samsungClient.BuscarSmartPhoneModeloDetalhes());
        Console.WriteLine(samsungClient.BuscarNormalPhoneModeloDetalhes());


        Console.ReadKey();
    }
}