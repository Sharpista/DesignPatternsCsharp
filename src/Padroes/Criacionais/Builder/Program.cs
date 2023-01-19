using Builder.Builders;
using Builder.Director;

internal class Program
{
    private static void Main(string[] args)
    {
        ICarroBuilder builderCarroAutomatico = new CarroAutomaticoBuilder();
        var director = new Director(builderCarroAutomatico);

        director.BuildCarroAutomatico("POLO", "PRETO", false, 4, false, 5, 1);

        Console.WriteLine(builderCarroAutomatico.GetCarro());

        builderCarroAutomatico.SetCor("PRETO");
        builderCarroAutomatico.SetNome("POLO");
        builderCarroAutomatico.SetComputadorBordo(false);
        builderCarroAutomatico.SetNumeroPortas(4);
        builderCarroAutomatico.SetGPS(false);
        builderCarroAutomatico.SetMotor(2);
        builderCarroAutomatico.SetAssentos(5);
        Console.WriteLine("SEM O DIRECTOR");
        Console.WriteLine(builderCarroAutomatico.GetCarro());
    }
}