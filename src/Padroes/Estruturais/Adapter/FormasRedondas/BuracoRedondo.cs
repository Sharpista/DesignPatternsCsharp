namespace Adapter.FormasRedondas
{
    public class BuracoRedondo
    {
        private readonly double _radius;

        public BuracoRedondo()
        {

        }
        public BuracoRedondo(double radius)
        {
            _radius = radius;   
        }

        public double GetRadius()
        {
            return _radius;
        }

        public bool SeEncaixa(PinoRedondo pinoRedondo)
        {
            return this.GetRadius() >= pinoRedondo.GetRadius();
        }
    }
}
