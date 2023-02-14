using Bridge.Abstracao;
using Bridge.Implementacao;
using Bridge.ImplementacaoConcreta;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        TestarDispositivo(new Radio());
        TestarDispositivo(new Televisao());
    }

    public static void TestarDispositivo(IDispositivoEletronico dispositivoEletronico)
    {
        Console.WriteLine("Testando controle remoto básico.");
        ControleRemoto controleRemoto = new (dispositivoEletronico);
        controleRemoto.Power();
        dispositivoEletronico.MostrarDispositivo();

        Console.WriteLine("Tests with advanced remote.");
        ControleRemotoAvancado controleRemotoAvancado = new ControleRemotoAvancado(dispositivoEletronico);
        controleRemotoAvancado.Power();
        controleRemotoAvancado.Mute();
        dispositivoEletronico.MostrarDispositivo();
    }
}