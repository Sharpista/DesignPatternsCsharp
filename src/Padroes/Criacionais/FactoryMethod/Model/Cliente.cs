using FactoryMethod.ConcretCreators;
using FactoryMethod.Creator;
using FactoryMethod.ValueObjects;

namespace FactoryMethod.Model
{
    public class Cliente
    {
        public void Main()
        {
            Menu();
            var numero = Convert.ToInt32(Console.ReadLine());
            var tipoTransporte = (TipoTransporte) Enum.ToObject(typeof(TipoTransporte), numero); 
            Console.WriteLine("Iniciando Criador Concreto");
            ClienteCode(new CorreioConcreteCreator(), tipoTransporte);

        }

        public void ClienteCode(Correio correio, TipoTransporte tipoTrasporte)
        {
            Console.WriteLine("Cliente: Eu não estou ciente da classe do criador mas ainda funciona" + "\n" + correio.RealizarEntrega(tipoTrasporte) + "\n");
        }

        public void Menu()
        {
            Console.WriteLine("Bem vindo!");
            Console.WriteLine("------------------------");
            Console.WriteLine("Escolha o  tipo de trasporte que deseja utilizar para realizar sua entrega");
            Console.WriteLine("------------------------");
            Console.WriteLine("(1) TREM, (2) CAMINHÃO E (3) AVIÃO");
        }
    }
}
