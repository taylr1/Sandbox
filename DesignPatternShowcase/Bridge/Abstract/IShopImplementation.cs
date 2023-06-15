namespace DesignPatternShowcase.Bridge.Abstract;

public interface IShopImplementation
{
    int ShopId { get; }
    string ShopState { get; }
    void CalculateEmployeePay();
}