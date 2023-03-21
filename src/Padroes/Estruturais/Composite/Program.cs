// See https://aka.ms/new-console-template for more information

using Composite.Exemplo;

internal class Program
{
    public static void Main(string[] args)
    {
        var client = new Client();

        var leaf = new Leaf();
        Console.WriteLine("Client: I get a simple component:");
        client.ClientCode(leaf);

        CompositeClass tree = new CompositeClass();
        CompositeClass branch1 = new CompositeClass();
        branch1.Add(new Leaf());
        branch1.Add(new Leaf());
        CompositeClass branch2 = new CompositeClass();
        branch2.Add(new Leaf());
        tree.Add(branch1);
        tree.Add(branch2);
        Console.WriteLine("Client: Now I've got a composite tree:");
        client.ClientCode(tree);

        Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
        client.ClientCode2(tree, leaf);
    }
}