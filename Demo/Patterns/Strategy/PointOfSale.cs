namespace Demo.Patterns.Strategy;
public class PointOfSale
{
  public List<IDiscountStrategy> Discounts { get; set; } = new();

  public decimal GetBestDiscount(Order order) => Discounts.Max(d => d.GetDiscount(order));


}