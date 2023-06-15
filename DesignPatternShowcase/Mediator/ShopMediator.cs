using System.Net.Http.Headers;
using DesignPatternShowcase.Mediator.Base;
using DesignPatternShowcase.Mediator.Enum;
using DesignPatternShowcase.Mediator.SubTypes;

namespace DesignPatternShowcase.Mediator;

/// <summary>
/// the mediator design pattern is useful when you have several different object that are dependent upon one another, and rather than
/// managing those dependencies on a class by class basis we offload that responsibility entirely to the mediator. Which effectively serves
/// as an intermediary for the classes to communicate. 
/// </summary>
public class ShopMediator
{
    private List<ClerkAbstract>? _clerks;
    private ShopperAbstract? _shopper;

    public List<ClerkAbstract> Clerks
    {
        set => _clerks = value;
    }

    public ShopperAbstract Shopper
    {
        set => _shopper = value;
    }

    public void NotifyAvailableClerk(List<CartItems> cartItems)
    {
        if (_clerks is null)
            throw new ArgumentNullException(nameof(_clerks), "No clerks have been initialized.");
        
        var availableClerk = _clerks.FirstOrDefault(x => x.Available);

        if (availableClerk is not null)
            availableClerk.Transact(cartItems);
        else 
            Console.WriteLine("No clerks are currently available!");
    }

    public void NotifyShopperOfPurchaseResult()
    {
        if (_shopper is ShopperA shopperA)
            shopperA.HandleTransactionComplete();
        if (_shopper is ShopperB shopperB)
            shopperB.HandleTransactionComplete();
    }
}