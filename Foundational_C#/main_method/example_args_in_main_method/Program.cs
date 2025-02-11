class Program{
  static void Main(string[] args){
    if(args?.Length < 2){
      Console.WriteLine("Must enter 2 numbers.");
    }
    if(int.TryParse(args[0], out int num1) && int.TryParse(args[1], out int num2)){
      Console.WriteLine($"Sum: {num1 + num2}");
    }
    else 
    {
      Console.WriteLine("Invalid input.");
    }
  }
}