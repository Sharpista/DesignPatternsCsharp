using Prototype.Model;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("PROTOTYPE!");

        var formas = new List<Forma>();

        Circulo circulo = new();

        circulo.X = 10;
        circulo.Y = 20;
        circulo.Radius = 15;
        formas.Add(circulo);

        //Copia do primeiro circulo
        Circulo outroCirculo = (Circulo)circulo.Clone();
        formas.Add(outroCirculo);


        Retangulo retangulo = new Retangulo();
       
        retangulo.Altura = 10;
        retangulo.Largura = 20;
        formas.Add(retangulo);

        var formasCopias = new List<Forma>();

        foreach (var f in formas)
        {
            formasCopias.Add(f.Clone());
        }

        Console.WriteLine("Lista de Formas Copiadas");

    }
}