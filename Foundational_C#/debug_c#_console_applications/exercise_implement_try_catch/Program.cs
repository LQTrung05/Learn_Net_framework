try
{
  int num1 = int.MaxValue;
  int num2 = int.MaxValue;

//Nếu không dùng checked thì result = -2, lý do là vì: Trong C# mặc định, các phép tính số nguyên được thực hiện trong chế độ unchecked. Điều này có nghĩa là nếu kết quả phép tính vượt quá phạm vi của kiểu số (ở đây là kiểu int), thì kết quả sẽ bị "tràn số" (overflow) mà không ném ra ngoại lệ.
  int result = checked(num1 + num2);
  Console.WriteLine("Result: " + result);
}
catch (OverflowException ex)
{
  Console.WriteLine("Error: The number is too large to be represented as an integer." + ex.Message);
}
try
{

  string str = null;
  int length = str.Length;
  Console.WriteLine("String Length: " + length);
}
catch (NullReferenceException ex)
{
  Console.WriteLine("Error: The reference is null." + ex.Message);
}

try
{

  int[] numbers = new int[5];
  numbers[5] = 10;
  Console.WriteLine("Number at index 5: " + numbers[5]);
}
catch (IndexOutOfRangeException ex)
{
  Console.WriteLine("Error: Index out of range." + ex.Message);
}
try
{

  int num3 = 10;
  int num4 = 0;
  int result2 = num3 / num4;
  Console.WriteLine("Result: " + result2);
}
catch (DivideByZeroException ex)
{
  Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
}

Console.WriteLine("Exiting program.");

