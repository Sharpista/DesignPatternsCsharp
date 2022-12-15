using AbstractFactory.Interfaces;
using AbstractFactory.Products;

namespace AbstractFactory.ConcreteFactory
{
    public class SamsungFactory : ICelular
    {
        /// <summary>
        /// Concrete Factory 2
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public INormalPhone BuscarCelularNormal()
        {
            return new SamsungGuru();
        }

        public ISmartPhone BuscarSmartphone()
        {
            return new SamsungGalaxy();
        }
    }
}
