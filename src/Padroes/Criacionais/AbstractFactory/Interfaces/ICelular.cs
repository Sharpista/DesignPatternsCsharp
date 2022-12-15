namespace AbstractFactory.Interfaces
{
    /// <summary>
    /// AbstractFactory
    /// </summary>
    public interface ICelular
    {
        ISmartPhone BuscarSmartphone();
        INormalPhone BuscarCelularNormal();
    }
}
