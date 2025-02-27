public class CalculateDiscountRegular : IDiscountCalculator
{
    public double CalculateDiscount(double price)
    {
        return price * 0.05;
    }
}