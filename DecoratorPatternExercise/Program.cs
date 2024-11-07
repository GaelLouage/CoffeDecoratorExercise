internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        ICoffee coffee = new SimpleCoffee();

        coffee = new MilkDecorator(coffee);
        Console.WriteLine(coffee.GetCost());
        Console.WriteLine(coffee.GetDescription());

        coffee = new SugarDecorator(coffee);
        Console.WriteLine(coffee.GetCost());
        Console.WriteLine(coffee.GetDescription());
    }
}