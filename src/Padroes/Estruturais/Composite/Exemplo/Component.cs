namespace Composite.Exemplo;

public abstract class Component
{
    public abstract string Operacao();

    public virtual void Add(Component componente)
    {
        throw new NotImplementedException();
    }

    public virtual void Remove(Component componente)
    {
        throw new NotImplementedException();
    }

    public virtual bool IsComposite()
    {
        return true;
    }
}