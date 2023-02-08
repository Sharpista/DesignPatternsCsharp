namespace Adapter.FormasQuadradas
{
    public class PinoQuadrado
    {
        private readonly double _largura;

        public PinoQuadrado()
        {

        }
        public PinoQuadrado(double largura)
        {
            _largura = largura;
        }

        public double GetLargura()
        {
            return this._largura;
        }

        public double GetQuadrado()
        {
            return Math.Pow(_largura, 2);
        }
    }
}
