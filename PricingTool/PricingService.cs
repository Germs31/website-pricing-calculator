namespace PricingTool;

public class PricingService
{
    private readonly Dictionary<ComplexityTier, decimal> _basePrices = new()
    {
        {ComplexityTier.Basic, 1000m},
        {ComplexityTier.Standard, 2500m},
        {ComplexityTier.Premium, 5000m}
    };

    private const decimal PricerPerPage = 150m;

    public decimal CalculateTotal(ComplexityTier tier, int pageCount)
    {
        decimal basePrice = _basePrices[tier];
        decimal pagePrice = pageCount * PricerPerPage;
        return basePrice + pagePrice;
    }
}