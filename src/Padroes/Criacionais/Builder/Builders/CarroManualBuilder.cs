using Builder.Models;
using System.Text;

namespace Builder.Builders
{
    public class CarroManualBuilder : ICarroBuilder
    {
        private CarroManual _carroManual = new();
        private StringBuilder _sb = new();
        public void SetNome(string nome)
        {
            this._carroManual.Nome = nome;
        }

        public void SetCor(string cor)
        {
            this._carroManual.Cor = cor;
        }

        public void SetAssentos(int assentos)
        {
            this._carroManual.NumeroAssentos = assentos;
        }

        public void SetComputadorBordo(bool computadorBordo)
        {
            this._carroManual.TemComputadorBordo = computadorBordo;
        }

        public void SetGPS(bool gps)
        {
            this._carroManual.TemGPS = gps;
        }

        public void SetMotor(double motor)
        {
            this._carroManual.Motor = motor;
        }

        public void SetNumeroPortas(int portas)
        {
            this._carroManual.NumeroPortas = portas;
        }
        public string GetCarro()
        {
            Veiculo carroManual = this._carroManual;

            _sb = new StringBuilder();
            _sb.Append("Nome:");
            _sb.Append(carroManual.Nome);
            _sb.Append("Cor:");
            _sb.Append(carroManual.Cor);
            _sb.Append("Tem GPS");
            _sb.Append(carroManual.TemGPS ? "Sim" : "Não");
            _sb.Append("Tem Computador de Bordo");
            _sb.Append(carroManual.TemComputadorBordo ? "Sim" : "Não");
            _sb.Append("Numero de portas: ");
            _sb.Append(carroManual.NumeroPortas);
            _sb.Append("Motor");
            _sb.Append(carroManual.Motor);

            this.Reset();  

            return _sb.ToString();
        }
        public void Reset()
        {
            this._carroManual = new();
        }

    }
}
