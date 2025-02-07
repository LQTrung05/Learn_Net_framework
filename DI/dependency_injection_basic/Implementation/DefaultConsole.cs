public class DefaultConsole : IConsole{
  public bool IsEnables { get; set; } = true;
  public void WriteLine(string message){
    if(IsEnables){
      Console.WriteLine(message);
    }
    else return;
  }
}