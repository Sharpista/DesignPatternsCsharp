using AbstractFactory.Interfaces;
using AbstractFactory.Products;

namespace AbstractFactory.ConcreteFactory
{
    public class XiaomiFactory : ICelular
    {   /// <summary>
        /// Concrete Factory 1
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public INormalPhone BuscarCelularNormal()
        {
            return new Redmi();
        }

        public ISmartPhone BuscarSmartphone()
        {
            return new Mi();
        }
    }
}
