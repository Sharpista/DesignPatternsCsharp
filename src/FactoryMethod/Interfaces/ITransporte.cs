namespace FactoryMethod.Interfaces
{
    //A interface do produto declara as operações que todos os produtos concretos
    //deve implementar.
    public interface ITransporte
    {
        string CriarTransporte();
    }
}
