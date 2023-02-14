using Bridge.Implementacao;
using System.Threading.Channels;

namespace Bridge.ImplementacaoConcreta
{
    public class Radio : IDispositivoEletronico
    {
        private bool ligado = false;
        private double volume = 30;
        private int canal = 1;

        public int GetCanal()
        {
            return canal;
        }

        public double GetVolume()
        {
           return volume;
        }
        public int SetCanal(int canal)
        {
            return this.canal = canal;
        }

        public double SetVolume(double volume)
        {
            if(volume > 100)
            {
                this.volume = 100;
            }
            else if(volume < 0)
            {
                this.volume = 0;
            }

            return this.volume = volume;

        }
        public bool Liga()
        {
            return ligado = true;
        }
        public bool Desliga()
        {
            return ligado = false;
        }

        public bool EstaLigado()
        {
           return ligado;
        }

        public void MostrarDispositivo()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("| Eu sou o  Rádio.");
            Console.WriteLine("| Estou" + (ligado ? "ligado" : "desligado"));
            Console.WriteLine("| Volume Atual é " + volume + "%");
            Console.WriteLine("| Canal atual é " + canal);
            Console.WriteLine("------------------------------------\n");
        }
    }
}
