using Bridge.Implementacao;

namespace Bridge.Abstracao
{
    public class ControleRemotoAvancado : ControleRemoto
    {
        public ControleRemotoAvancado(IDispositivoEletronico dispositivoEletronico) : base(dispositivoEletronico)
        {
        }

        public int? Mute()
        {
            Console.WriteLine("Controle Remoto Avançado : Foi clicado o Mute !");

            return _dispositivoEletronico?.SetCanal(0);
        }
    }
}
