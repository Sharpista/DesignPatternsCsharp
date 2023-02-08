namespace Adapter.FormasRedondas
{
    public class PinoRedondo
    {
        private readonly double _radius;

        public PinoRedondo()
        {

        }
        public PinoRedondo(double radius)
        {
            _radius = radius;
        }

        public virtual double GetRadius()
        {
            return _radius; 
        }
    }
}
