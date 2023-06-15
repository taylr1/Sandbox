namespace DesignPatternShowcase.Mediator.Base;

public abstract class ShopperBase
{
    protected enum PaymentMethods
    {
        Cash = 1,
        Card = 2
    }
    
    protected enum CartItems
    {
        Apple = 1, 
        Bread = 2, 
        Soda = 3, 
        Candy = 4, 
        Veggies = 5
    }
    
    protected abstract string Name { get; }
    protected abstract PaymentMethods PaymentMethod { get; }
    protected abstract decimal AvailableFunds { get; }
    protected abstract List<CartItems> ItemsInCart { get; set; }
    
    // mediator instance
    protected ShopMediator ShopMediator => ShopMediator.Instance;

    protected void SendItemsToCart()
    {
        
    };
}