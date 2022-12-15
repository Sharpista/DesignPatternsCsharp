using AbstractFactory.Interfaces;

namespace AbstractFactory.Products
{
    /// <summary>
    /// ProdutoB2
    /// </summary>
    public class SamsungGuru : INormalPhone
    {
        public string BuscarDetalhesModelo()
        {
            return "Modelo: Samsung Guru  \n RAM:512mb \n Camera:2MP \n";
        }
    }
}
