
public class SimpleCoffee : ICoffee
{
    public decimal GetCost()
    {
        return 5.0M;
    }

    public string GetDescription()
    {
        return "Simple coffee.";
    }
}