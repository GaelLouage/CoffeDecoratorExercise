
public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee)
    {
    }
    public override string GetDescription()
    {
        return $"{base.GetDescription()} and Sugar";
    }
    public override decimal GetCost()
    {
        return base.GetCost() + 0.10M;
    }
}
