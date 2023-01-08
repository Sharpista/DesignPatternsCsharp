using Builder.Models;

namespace Builder.Builders
{
    public interface ICarroBuilder
    {
        void Reset();
        void SetNome(string nome);
        void SetCor(string cor);
        void SetAssentos(int assentos);
        void SetNumeroPortas(int portas);
        void SetMotor(double motor);
        void SetComputadorBordo(bool computadorBordo);
        void SetGPS(bool gps);
        string GetCarro();
    }
}
