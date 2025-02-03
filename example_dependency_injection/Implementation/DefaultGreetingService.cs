internal sealed class DefaultGreetingService(IConsole console) : IGreetingService{
  //sealed: Niêm phong, không cho class nào kế thừa class này nữa
  public string Greet(string name){
    string greeting = $"Hello {name}";
    console.WriteLine( greeting ); 
    return greeting;
  }
}