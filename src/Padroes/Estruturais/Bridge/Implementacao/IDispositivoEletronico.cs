namespace Bridge.Implementacao
{
    public interface IDispositivoEletronico
    {
        double SetVolume(double volume);
        double GetVolume();
        int SetCanal(int canal);
        int GetCanal();

        bool Liga();
        bool Desliga();
        bool EstaLigado();

        public void MostrarDispositivo();
    }
}
