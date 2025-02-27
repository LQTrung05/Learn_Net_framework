public class Rectangle : Shape
{
  public int Width { get; set; }
  public int Height { get; set; }

  public override double CalculateArea()
  {
    double area = Width * Height;
    return area;
  }

  public Rectangle()
  {
    Width = 0;
    Height = 0;
  }
  public Rectangle(int width, int height)
  {
    Width = width;
    Height = height;
  }
}