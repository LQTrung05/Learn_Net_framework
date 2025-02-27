public abstract class Employee
{
  //Tất cả nhân viên của công ty đểu có các đặc điểm chung là có tên, và được nhận lương
  public string Name { get; set; }

  public void GetPaid()
  {
    Console.WriteLine("You get paid");
  }

//Mỗi nhân viên sẽ có một công việc khác nhau
  public abstract void Work();

  public Employee()
  {
    Name = string.Empty;
  }
  public Employee(string name)
  {
    Name = name;
  }
}

//Dev kế thừa từ Employee, và có thêm một thuộc tính riêng
public class Dev : Employee
{
  public string Level { get; set; }
  
  public Dev()
  {
    Level = "Intern";
  }
  public Dev(string name, string level) : base(name){
    Level = level;
  }

  //Override lại abstract method của class cha
  public override void Work()
  {
    Console.WriteLine("Dev is coding.");
  }
}
