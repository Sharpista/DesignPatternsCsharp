using AbstractFactory.Interfaces;

namespace AbstractFactory.Products
{
    /// <summary>
    /// Produto A2
    /// </summary>
    public class SamsungGalaxy : ISmartPhone
    {
        public string BuscarDetalhesModelo()
        {
            return "Modelo: Samsung Galaxy S22 \n RAM:12GB \n Camera:50 Mp + 48 Mp + 48 Mp \n";
        }
    }
}
