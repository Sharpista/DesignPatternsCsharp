using Adapter.Adapters;
using Adapter.FormasQuadradas;
using Adapter.FormasRedondas;

internal class Program
{
    private static void Main(string[] args)
    {
        BuracoRedondo buracoRedondo = new BuracoRedondo(5);
        PinoRedondo pinoRedondo = new PinoRedondo(5);


        if(buracoRedondo.SeEncaixa(pinoRedondo))
        {
            Console.WriteLine($"Pino redondo de {pinoRedondo.GetRadius()} radius se encaixa no Buraco redondo de {buracoRedondo.GetRadius()} radius");
        }
        
        PinoQuadrado pequenoPinoQuadrado = new PinoQuadrado(2);
        PinoQuadrado grandePinoQuadrado = new PinoQuadrado(20);

        //Não funciona
        // buracoRedondo.SeEncaixa(grandePinoQuadrado)

        PinoQuadradoAdapter pequenoPinoQuadradoAdapter = new PinoQuadradoAdapter(pequenoPinoQuadrado);
        PinoQuadradoAdapter grandePinoQuadradoAdapter = new PinoQuadradoAdapter(grandePinoQuadrado);

        if (buracoRedondo.SeEncaixa(pequenoPinoQuadradoAdapter))
        {
            Console.WriteLine($"Pino quadrado com Largura : {pequenoPinoQuadrado.GetLargura()} se encaixa no buraco redondo de radius: {buracoRedondo.GetRadius()}");
        }
        
        if (!buracoRedondo.SeEncaixa(grandePinoQuadradoAdapter))
        {
            Console.WriteLine($"Pino quadrado com Largura : {grandePinoQuadrado.GetLargura()} não se encaixa no buraco redondo de radius: {buracoRedondo.GetRadius()}");
        }


    }
}