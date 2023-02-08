using Adapter.FormasQuadradas;
using Adapter.FormasRedondas;

namespace Adapter.Adapters
{
    public class PinoQuadradoAdapter : PinoRedondo
    {
        private readonly PinoQuadrado? _pinoQuadrado;

        public PinoQuadradoAdapter(PinoQuadrado? pinoQuadrado)
        {
            _pinoQuadrado = pinoQuadrado;
        }

        public override double GetRadius()
        {
            return (Math.Sqrt(Math.Pow((_pinoQuadrado.GetLargura() / 2), 2) * 2));
        }

    }
}
