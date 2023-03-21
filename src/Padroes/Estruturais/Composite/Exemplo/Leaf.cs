namespace Composite.Exemplo;

public class Leaf : Component
{
    public override string Operacao()
    {
        return "Leaf";
    }

    public override bool IsComposite()
    {
        return false;
    }
}