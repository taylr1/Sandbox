namespace DesignPatternShowcase.Mediator.Base;

public abstract class ClerkBase
{
    public abstract string Name { get; }
    public bool Available { get; set; }
    public abstract bool ProcessItemsFromCart(decimal funds);
}