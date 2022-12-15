using AbstractFactory.Interfaces;

namespace AbstractFactory.Products
{
    /// <summary>
    /// ProdutoA1
    /// </summary>
    public class Mi : ISmartPhone
    {
        public string BuscarDetalhesModelo()
        {
            return "Modelo: Mi 11 Ultra  \n RAM:12GB \n Camera:50 Mp + 48 Mp + 48 Mp \n";
        }
    }
}
