using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    /// <summary>
    /// Client
    /// </summary>
    public class CelularClient
    {
       ISmartPhone? smartPhone;
       INormalPhone? normalPhone;

        public CelularClient(ICelular celularFactory)
        {
            smartPhone = celularFactory.BuscarSmartphone();
            normalPhone = celularFactory.BuscarCelularNormal();
        }

        public string? BuscarSmartPhoneModeloDetalhes()
        {
            return smartPhone?.BuscarDetalhesModelo();
        }

        public string? BuscarNormalPhoneModeloDetalhes()
        {
            return normalPhone?.BuscarDetalhesModelo();
        }
    }
}
