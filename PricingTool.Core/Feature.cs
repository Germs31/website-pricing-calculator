namespace PricingTool.Core;

public class Feature
{
    public string Name { get; set;}
    public decimal Price { get; set;}

    public Feature(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}