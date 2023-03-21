namespace Composite.Exemplo;

public class Client
{
    public void ClientCode(Component leaf)
    {
        Console.WriteLine($"RESULT: {leaf.Operacao()}\n");
    }

    public void ClientCode2(Component component1, Component component2)
    {
        if (component1.IsComposite()) component1.Add(component2);

        Console.WriteLine($"RESULT: {component1.Operacao()}");
    }
}