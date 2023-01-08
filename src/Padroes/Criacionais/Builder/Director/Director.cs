using Builder.Builders;

namespace Builder.Director
{
    public class Director
    {
        private readonly ICarroBuilder? _carroBuilder;
        public Director(ICarroBuilder? carroBuilder)
        {
            _carroBuilder = carroBuilder;
        }

        public void BuildCarroManual(string nome, string cor, bool temGps, int numeroPortas, bool temComputadorBordo, int numeroAssentos, int motor)
        {
            this._carroBuilder?.Reset();
            this._carroBuilder?.SetNome(nome);
            this._carroBuilder?.SetCor(cor);
            this._carroBuilder?.SetGPS(temGps);
            this._carroBuilder?.SetNumeroPortas(numeroPortas);
            this._carroBuilder?.SetComputadorBordo(temComputadorBordo);
            this._carroBuilder?.SetAssentos(numeroAssentos);
            this._carroBuilder?.SetMotor(motor);
        }
        public void BuildCarroAutomatico(string nome, string cor, bool temGps, int numeroPortas, bool temComputadorBordo, int numeroAssentos, int motor)
        {
            this._carroBuilder?.Reset();
            this._carroBuilder?.SetNome(nome);
            this._carroBuilder?.SetCor(cor);
            this._carroBuilder?.SetGPS(temGps);
            this._carroBuilder?.SetNumeroPortas(numeroPortas);
            this._carroBuilder?.SetComputadorBordo(temComputadorBordo);
            this._carroBuilder?.SetAssentos(numeroAssentos);
            this._carroBuilder?.SetMotor(motor);
        }
       
    }
}
