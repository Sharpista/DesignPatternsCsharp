namespace Composite.Exemplo;

public class CompositeClass : Component
{
    protected ICollection<Component> _children = new List<Component>();

    public override void Add(Component componente)
    {
        _children.Add(componente);
    }

    public override void Remove(Component componente)
    {
        _children.Remove(componente);
    }

    public override string Operacao()
    {
        var i = 0;
        var result = "Branch(";

        foreach (var component in _children)
        {
            result += component.Operacao();
            if (i != _children.Count - 1) result += "+";
            i++;
        }

        return result + ")";
    }
}