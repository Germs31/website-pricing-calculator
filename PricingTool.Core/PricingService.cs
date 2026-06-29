namespace PricingTool.Core;

public class PricingService
{
    private readonly Dictionary<ComplexityTier, decimal> _basePrices = new()
    {
        {ComplexityTier.Basic, 1000m},
        {ComplexityTier.Standard, 2500m},
        {ComplexityTier.Premium, 5000m}
    };

    private const decimal PricerPerPage = 150m;
    private const decimal RushSurChargeRate = 0.2m;

    public decimal CalculateTotal(ComplexityTier tier, int pageCount, List<Feature> features, bool isRush)
    {
        decimal basePrice = _basePrices[tier];
        decimal pagesCost = pageCount * PricerPerPage;
        decimal featuresCost = features.Sum(f => f.Price);

        decimal subtotal = basePrice + pagesCost + featuresCost;

        if(isRush)
        {
            subtotal += subtotal * RushSurChargeRate;
        }

        return subtotal;
    }

}