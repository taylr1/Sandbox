using DesignPatternShowcase.Mediator.Base;
using DesignPatternShowcase.Mediator.Enum;

namespace DesignPatternShowcase.Mediator.SubTypes;

public class ClerkA : ClerkAbstract
{
    private readonly ShopMediator _shopMediator;
    
    public ClerkA(ShopMediator shopMediator) : base(shopMediator)
    {
        _shopMediator = shopMediator;
    }
    
    public override string Name => "William";
    public override bool Available => false;
    public override void Transact(List<CartItems> shopperItems)
    {
        Console.WriteLine($"Clerk {Name} is completing checkout of the following items: {string.Join(',', shopperItems)}");
        _shopMediator.NotifyShopperOfPurchaseResult();
    }
}

public class ClerkB : ClerkAbstract
{
    private readonly ShopMediator _shopMediator;
    
    public ClerkB(ShopMediator shopMediator) : base(shopMediator)
    {
        _shopMediator = shopMediator;
    }
    
    public override string Name => "Timothy";
    public override bool Available => true;
    public override void Transact(List<CartItems> shopperItems)
    {
        Console.WriteLine($"Clerk {Name} is completing checkout of the following items: {string.Join(',', shopperItems)}");
        _shopMediator.NotifyShopperOfPurchaseResult();
    }
}