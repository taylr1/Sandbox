using DesignPatternShowcase.Mediator.Base;
using DesignPatternShowcase.Mediator.Enum;

namespace DesignPatternShowcase.Mediator.SubTypes;

public class ShopperA : ShopperAbstract
{
    private readonly ShopMediator _shopMediator;
    
    public ShopperA(ShopMediator shopMediator) : base(shopMediator)
    {
        _shopMediator = shopMediator;
    }
    
    public override string Name => "Tina";

    public override List<CartItems> ItemsInCart => new()
    {
        CartItems.Bread,
        CartItems.Soda,
        CartItems.Veggies
    };


    public override void InitiateCheckout()
    {
        _shopMediator.NotifyAvailableClerk(ItemsInCart);
    }

    public override void HandleTransactionComplete()
    {
        ShoppingComplete = true;
        Console.WriteLine("Tina says: Thanks!");
    }
}

public class ShopperB : ShopperAbstract
{
    private readonly ShopMediator _shopMediator;
    
    public ShopperB(ShopMediator shopMediator) : base(shopMediator)
    {
        _shopMediator = shopMediator;
    }
    
    public override string Name => "Bill";

    public override List<CartItems> ItemsInCart => new()
    {
        CartItems.Apple,
        CartItems.Candy
    };

    public override void InitiateCheckout()
    {
        _shopMediator.NotifyAvailableClerk(ItemsInCart);
    }

    public override void HandleTransactionComplete()
    {
        ShoppingComplete = true;
        Console.WriteLine("Bill says: Thanks!");
    }
}