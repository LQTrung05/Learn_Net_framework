public class CalculateDiscountVIP : IDiscountCalculator
{
    public double CalculateDiscount(double price)
    {
        return price * 0.1;
    }
}