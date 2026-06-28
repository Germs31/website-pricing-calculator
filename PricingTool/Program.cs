using PricingTool;

var availableFeatures = new List<Feature>
{
    new Feature("CMS", 800m),
    new Feature("E-commerce", 1200m),
    new Feature("SEO", 500m)
};

var pricing = new PricingService();

ComplexityTier tier = ComplexityTier.Premium;
Console.WriteLine("How Many Pages do you want to build?");
string? input = Console.ReadLine();

int pageCount;

if(!int.TryParse(input, out pageCount))
{
    Console.WriteLine("not a valid number - deafulting to 1");
    pageCount = 1;
}
bool isRush = true; 

decimal total = pricing.CalculateTotal(tier, pageCount, availableFeatures, isRush);


Console.WriteLine("===== Website Quote =====");
Console.WriteLine($"Tier: {tier}");
Console.WriteLine($"Pages: {pageCount}");
Console.WriteLine("Features:");
foreach (Feature feature in availableFeatures)
{
    Console.WriteLine($"  - {feature.Name}: {feature.Price:C}");
}
Console.WriteLine($"Rush job: {isRush}");
Console.WriteLine($"TOTAL: {total:C}");