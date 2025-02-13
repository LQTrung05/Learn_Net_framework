public partial class Student
{
  public int Id { get; set; }
  public void PrintId()
  {
    System.Console.WriteLine("Id: " + Id);
  }
  public class NestedClass{
    public int NestID { get; set; }

  }
}

public partial class Student
{
  public string Name { get; set; }
  public void PrintName()
  {
    Console.WriteLine("Name: " + Name);
  }

  public Student(int Id, string Name){
    this.Id = Id;
    this.Name = Name;
  }
}
public class Program
{
  public static void Main()
  {
    var student1 = new Student(1, "TrungLQ");
    student1.PrintId();
    student1.PrintName();

    var nestObj = new Student.NestedClass();
    
  }

}
