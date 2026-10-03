namespace part_01.src.Shipping;

public class ShippingCostCalculator
{
    private readonly IShippingCostCalculator _shippingCostCalculator;

    public ShippingCostCalculator(IShippingCostCalculator shippingCostCalculator)
    {
        _shippingCostCalculator = shippingCostCalculator;
    }

     public decimal Calculate( decimal weightKg)
     {
        return _shippingCostCalculator.Calculate(weightKg);
    
     }

}
