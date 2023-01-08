using Builder.Models;
using System.Text;

namespace Builder.Builders
{
    public class CarroAutomaticoBuilder : ICarroBuilder
    {
        private CarroAutomatico _carroAutomatico = new CarroAutomatico();
        private StringBuilder? _sb;

        public void SetNome(string nome)
        {
            this._carroAutomatico.Nome = nome;
        }

        public void SetCor(string cor)
        {
            this._carroAutomatico.Cor = cor;
        }
        public void SetAssentos(int assentos)
        {
            this._carroAutomatico.NumeroAssentos = assentos;
        }

        public void SetComputadorBordo(bool computadorBordo)
        {
            this._carroAutomatico.TemComputadorBordo = computadorBordo;
        }

        public void SetGPS(bool gps)
        {
            this._carroAutomatico.TemGPS = gps;
        }

        public void SetMotor(double motor)
        {
            this._carroAutomatico.Motor = motor;
        }

        public void SetNumeroPortas(int portas)
        {
            this._carroAutomatico.NumeroPortas = portas;
        }
        public string GetCarro()
        {
            Veiculo carroAutomaticoResult = this._carroAutomatico;

            _sb = new StringBuilder();
            _sb.Append("Nome:");
            _sb.Append(carroAutomaticoResult.Nome);
            _sb.Append("Cor:");
            _sb.Append(carroAutomaticoResult.Cor);
            _sb.Append("Tem GPS:");
            _sb.Append("");
            _sb.Append(carroAutomaticoResult.TemGPS ? "Sim" : "Não");
            _sb.AppendLine();
            _sb.Append("Tem Computador de Bordo");
            _sb.Append("");
            _sb.Append(carroAutomaticoResult.TemComputadorBordo ? "Sim" : "Não");
            _sb.AppendLine();
            _sb.Append("Numero de portas: ");
            _sb.Append("");
            _sb.Append(carroAutomaticoResult.NumeroPortas);
            _sb.AppendLine();
            _sb.Append("Motor");
            _sb.Append("");
            _sb.Append(carroAutomaticoResult.Motor);

            return _sb.ToString();
        }
        public void Reset()
        {
            this._carroAutomatico = new CarroAutomatico();
        }

    }
}
