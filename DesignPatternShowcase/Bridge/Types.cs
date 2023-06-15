using DesignPatternShowcase.Bridge.Abstract;

namespace DesignPatternShowcase.Bridge;

// the base abstraction can be extended without effecting the implementation classes 
public class StandardShop : ShopAbstract
{
    public StandardShop(IShopImplementation implementation) : base(implementation)
    {
    }
}

public class Shop_1 : IShopImplementation
{
    public int ShopId => 1;
    public string ShopState => "CA";
    public void CalculateEmployeePay()
    {
        int employeeHours = 40;
        double weeklyBonus = 20.00;
        double baseHourly = 15.25;

        var weeklyStandardRate = (employeeHours * baseHourly) + weeklyBonus;
        
        Console.WriteLine($"Standard weekly employee pay for Shop 1 is: {weeklyStandardRate}");
    }
}

public class Shop_2 : IShopImplementation
{
    public int ShopId => 2;
    public string ShopState => "OR";
    public void CalculateEmployeePay()
    {
        int employeeHours = 40;
        double baseHourly = 15.25;

        var weeklyStandardRate = (employeeHours * baseHourly);
        
        Console.WriteLine($"Standard weekly employee pay for Shop 2 is: {weeklyStandardRate}");
    }
}