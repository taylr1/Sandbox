using DesignPatternShowcase.Mediator.Enum;

namespace DesignPatternShowcase.Mediator.Base;

public abstract class ClerkAbstract
{
    protected ClerkAbstract(ShopMediator shopMediator) { }
    
    public abstract string Name { get; }
    public abstract bool Available { get; }
    public abstract void Transact(List<CartItems> shopperItems);
}