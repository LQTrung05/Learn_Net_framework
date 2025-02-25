public class Person
{
  public string? Name { get; set; }
  public int Age { get; set; }

  public virtual void Print()
  {
    Console.WriteLine("Name: " + Name);
    Console.WriteLine("Age: " + Age);
  }

  public Person()
  {
    this.Name = "";
    this.Age = 0;
  }
  public Person(int age)
  {
    this.Age = age;
  }
  public Person(string name, int age)
  {
    this.Name = name;
    this.Age = age;
  }

}

public class Man : Person
{
  public new string Name { get; set; }

  public override void Print()
  {
    base.Print();
    if (Age is <= 0 and <= 18)
    {
      Console.WriteLine("Children");
    }
    else
    {
      Console.WriteLine("Adult");
    }
  }

  public Man(string name, int age) : base(age)
  {
    this.Name = name;
    this.Age = age;
  }
}