namespace Prototype.Model
{
    public abstract class Forma
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string? Cor { get; set; }

        public Forma(Forma forma)
        {
            X = forma.X;
            Y = forma.Y;
            Cor = forma.Cor;
        }
        public Forma()
        {

        }

        public abstract Forma Clone(); 
    }
}
