
public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee)
    { }
    public override string GetDescription()
    {
        return $"{base.GetDescription()} and Milk";
    }
    public override decimal GetCost()
    {
        return base.GetCost() + 0.05M;
    }
}
