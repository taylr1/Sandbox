using DesignPatternShowcase.Mediator.Enum;
using DesignPatternShowcase.Mediator.SubTypes;

namespace DesignPatternShowcase.Mediator.Base;

public abstract class ShopperAbstract
{
    protected ShopperAbstract(ShopMediator shopMediator) { }
    
    public abstract string Name { get; }
    public abstract List<CartItems> ItemsInCart { get; }
    public abstract void InitiateCheckout();
    public abstract void HandleTransactionComplete();
    protected bool ShoppingComplete { get; set; } = false;
}