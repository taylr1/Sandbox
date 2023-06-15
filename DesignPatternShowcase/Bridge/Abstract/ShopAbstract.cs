namespace DesignPatternShowcase.Bridge.Abstract;

/// <summary>
/// the bridge pattern divides the implementation of classes into several class hierarchies. this is accomplished by creating a parent abstract type
/// then making it dependent on a concrete implementation of another abstract type created to represent the more individualistic
/// attributes associated with a specific implementation. the bridge pattern is useful in scenarios where you are integrating with a third party service.
/// each integration follows a similar pattern, although when it comes to actually implementing code around the integration each service has their
/// own unique attributes.  
/// </summary>
public abstract class ShopAbstract
{
    private IShopImplementation _implementation;

    protected ShopAbstract(IShopImplementation implementation)
    {
        _implementation = implementation;
    }

    public virtual void ListShopAttributes()
    {
        Console.WriteLine($"Shop Id: {_implementation.ShopId}, Shop State: {_implementation.ShopState}");
    }

    // we defer to the provided implementation to calculate pay since this is something that is determined on a
    // 'shop by shop' basis (or an implementation by implementation basis leaving our example behind).
    public virtual void CalculateEmployeePay()
    {
        _implementation.CalculateEmployeePay();
    }
}