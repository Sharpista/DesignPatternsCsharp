namespace Prototype.Model
{
    public class Circulo : Forma
    {
        public int Radius { get; set; }

        public Circulo(Circulo circulo) : base(circulo)
        {
            Radius = circulo.Radius;
        }
        public Circulo()
        {

        }
       
        public override Forma Clone()
        {
           return new Circulo(this);
        }
    }
}
