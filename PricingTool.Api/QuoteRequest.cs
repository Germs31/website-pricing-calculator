using PricingTool.Core;

namespace PricingTool.Api;

public class QuoteRequest
{
    public ComplexityTier Tier { get; set; }
    public int PageCount { get; set; }
    public List<Feature> Features { get; set; } = new();
    public bool IsRush { get; set; }
}