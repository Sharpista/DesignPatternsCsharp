namespace Prototype.Model
{
    public class Retangulo : Forma

    {
        public int Altura { get;  set; }
        public int Largura { get; set; }
        public Retangulo(Retangulo quadrado) : base(quadrado)
        {
            Altura = quadrado.Altura;
            Largura = quadrado.Largura;
        }
        public Retangulo()
        {

        }

        public override Forma Clone()
        {
            return new Retangulo(this);
        }
    }
}
