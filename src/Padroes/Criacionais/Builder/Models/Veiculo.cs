namespace Builder.Models
{
    public abstract class Veiculo
    {
        public string? Nome { get; set; }
        public double Motor { get; set; }
        public string? Cor { get; set; }
        public int NumeroPortas { get; set; }
        public int NumeroAssentos { get; set; }
        public bool TemGPS { get; set; }
        public bool TemComputadorBordo { get; set; }
    }
}
