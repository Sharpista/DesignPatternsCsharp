using AbstractFactory.Interfaces;

namespace AbstractFactory.Products
{
    /// <summary>
    /// ProdutoB1
    /// </summary>
    public class Redmi : INormalPhone
    {
        public string BuscarDetalhesModelo()
        {
            return "Modelo: Redmi 6 \n RAM:2GB \n Camera: 10 Mpx \n";
        }
    }
}
