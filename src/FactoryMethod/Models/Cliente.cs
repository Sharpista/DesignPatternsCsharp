namespace FactoryMethod.Models
{
    public class Cliente
    {
        public void Main()
        {
            Console.WriteLine("Iniciando primeiro criador concreto");
            ClientCode(new LogisticaRodoviaria());
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Iniciando segundo criador concreto");
            ClientCode(new LogisticaMaritima());
        }

        public void ClientCode(Logistica creator)
        {
            Console.WriteLine("Cliente: Eu não estou ciente da classe do criador mas ainda funciona" + "\n" + creator.PlanejarEntrega());
        }
    }
}
