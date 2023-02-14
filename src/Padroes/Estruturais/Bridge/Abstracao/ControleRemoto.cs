using Bridge.Implementacao;

namespace Bridge.Abstracao
{
    public class ControleRemoto
    {
        protected readonly IDispositivoEletronico? _dispositivoEletronico;

        public ControleRemoto(IDispositivoEletronico dispositivoEletronico)
        {
            _dispositivoEletronico = dispositivoEletronico;
        }

        public bool? Power()
        {
            Console.WriteLine("Controle Remoto : Foi clicado do power !");
            return _dispositivoEletronico.EstaLigado() ? _dispositivoEletronico.Desliga() : _dispositivoEletronico.Liga();
        }

        public double? DiminuirVolume()
        {
            Console.WriteLine("Controle Remoto : Diminuindo Volume !");
            return _dispositivoEletronico?.SetVolume(_dispositivoEletronico.GetVolume() - 10);
        }
        public double? AumentarVolume()
        {
            Console.WriteLine("Controle Remoto : Aumentando Volume !");

            return _dispositivoEletronico?.SetVolume(_dispositivoEletronico.GetVolume() + 10);
        }

        public int? ProximoCanal()
        {
            Console.WriteLine("Controle Remoto : Próximo Canal !");

            return _dispositivoEletronico?.SetCanal(_dispositivoEletronico.GetCanal() + 1);
        }

        public int? CanalAnterior()
        {
            Console.WriteLine("Controle Remoto : Canal Anterior !");

            return _dispositivoEletronico?.SetCanal(_dispositivoEletronico.GetCanal() - 1);
        }
    }
}
