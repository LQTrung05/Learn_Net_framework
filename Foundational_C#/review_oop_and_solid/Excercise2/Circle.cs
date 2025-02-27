public class Circle : Shape
{
  public int Radius { get; set; }

  public override double CalculateArea()
  {
    double area = Math.PI * Math.Pow(Radius, 2);
    return area;
  }
  public Circle()
  {
    Radius = 0;
  }
  public Circle(int radius)
  {
    Radius = radius;
  }
}