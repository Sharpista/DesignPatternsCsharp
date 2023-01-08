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
    }
}