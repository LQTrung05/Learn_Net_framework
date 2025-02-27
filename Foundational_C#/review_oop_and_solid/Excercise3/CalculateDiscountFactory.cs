public class CalculateDiscountFactory{
  public static IDiscountCalculator GetDiscountCalculator(string customerType )
  {
    return customerType switch
    {
      "Regular" => new CalculateDiscountRegular(),
      "VIP" => new CalculateDiscountVIP(),
      _ => throw new ArgumentException("Invalid customer type")
    };
  }
}