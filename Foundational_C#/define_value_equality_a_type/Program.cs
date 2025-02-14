// Link demo https://learn.microsoft.com/vi-vn/dotnet/csharp/programming-guide/statements-expressions-operators/how-to-define-value-equality-for-a-type
using System.Data;

namespace ValueEqualityClass;

class TwoDPoint : IEquatable<TwoDPoint>
{
  public int X { get; set; }
  public int Y { get; set; }
  public TwoDPoint(int x, int y)
  {
    //Cách so sánh này mới này.
    if(x is (< 1 or > 2000) || y is(<1 or > 2000)){
      throw new ArgumentException("Point must be in range 1 - 2000");
    }
    X = x; Y = y;    
  }

    public override bool Equals(object? obj) => this.Equals(obj as TwoDPoint);

    public bool Equals(TwoDPoint? other)
    {
        if(other is null) return false;
        //Nếu cùng tham chiếu thì đương nhiên chúng bằng nhau rồi.
        if(Object.ReferenceEquals(other, this)) return true;
        //Nếu type của 2 object khác nhau thì đương nhiêu chúng không bằng nhau được rồi.
        if(this.GetType() != other.GetType()) return false;
        return (this.X == other.X) && (this.Y == other.Y);

    }

  //Hàm này giúp tạo ra mã băm, mục đích của hàm này là đảm bảo 2 object mà có cùng X và Y thì sẽ có cùng mã băm.
  //Điều này giúp đảm bảo đúng nguyên tắc là 2 object bằng nhau thì phải có cùng mã băm.
    public override int GetHashCode() => (X,Y).GetHashCode();
    

    public static bool operator ==(TwoDPoint lhs, TwoDPoint rhs){
      if(lhs is null){
        //Nếu cả 2 thằng cùng null => true
        if(rhs is null){
          return true;
        }
        return false;
      }
      //Cần check lhs null trước vì nếu lhs null thì method Equals sẽ throw exception.
      return lhs.Equals(rhs);

    }

    //Tận dụng Overload toán tử == vừa  ở trên để Overload !=
    public static bool operator !=(TwoDPoint lhs, TwoDPoint rhs) => !(lhs == rhs);
 }

 class ThreePoint :TwoDPoint, IEquatable<ThreePoint>{
  public int Z { get; set; }

  public ThreePoint(int x, int y, int z) : base(x, y)
  {
    if(z is (<1 or > 2000))
    {
      throw new ArgumentException("Point must be in range 1 - 2000");
    }
    Z = z;
  }

    public override bool Equals(object? other) => this.Equals(other as ThreePoint);

    public bool Equals(ThreePoint? p){
      if(p is null) return false;
      if(Object.ReferenceEquals(this, p)) return true;
      if(this.GetType() != p.GetType()) return false;
      return base.Equals(p) && this.Z == p.Z;

    }

    public override int GetHashCode() => (X, Y, Z).GetHashCode();

    public static bool operator ==(ThreePoint lhs, ThreePoint rhs)
    {
        if (lhs is null)
        {
            if (rhs is null)
            {
                // null == null = true.
                return true;
            }

            // Only the left side is null.
            return false;
        }
        // Equals handles the case of null on right side.
        return lhs.Equals(rhs);
    }

    public static bool operator !=(ThreePoint lhs, ThreePoint rhs) => !(lhs == rhs);

}

class Program{
  public static void Main(string[] agrs){
    var pointA = new ThreePoint(5,6,7);
    var pointB = new ThreePoint(5,6,7);
    ThreePoint? pointC = null;
    int i = 4;
    Console.WriteLine("pointA.Equals(pointB) = {0}", pointA.Equals(pointB));
    Console.WriteLine($"pointA == pointB = {pointA == pointB}");
    Console.WriteLine("null comparison = {0}", pointA.Equals(pointC));
    Console.WriteLine("Compare to some other type = {0}", pointA.Equals(i));
  }
}