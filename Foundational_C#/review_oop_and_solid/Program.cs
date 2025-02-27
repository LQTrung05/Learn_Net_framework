//1. Excercise 1
// var bankacc = new BankAccount(0123456);
// bankacc.GetBalance();
// bankacc.Deposit(100);
// bankacc.GetBalance();
// bankacc.Withdraw(150); 

//2. Excercise 2
// var circle = new Circle(10);
// var rectangle = new Rectangle(1,2);

// System.Console.WriteLine($"Circle area: {circle.CalculateArea()}");
// System.Console.WriteLine($"Circle area: {circle.CalculateArea()}");

//3. Excercise 3
// string customerType = "VIP";
// double price = 500;
// var discountCalculator = CalculateDiscountFactory.GetDiscountCalculator(customerType);
// var discount = discountCalculator.CalculateDiscount(price);
// Console.WriteLine($"Customer Type: {customerType}, Discount: {discount}");

//4. Example about boxing
// int number = 10;
// object obj = number;
// System.Console.WriteLine(obj);
// System.Console.WriteLine(number);
// number = 15;
// System.Console.WriteLine(obj);
// System.Console.WriteLine(number);

//5. Example unboxing but not boxing
using System.Collections;

// int a = 10;
// object b =  a;
// long c = (long)b; // Sai, chỉ có thể unboxing về kiểu int
// Console.WriteLine(a);
// Console.WriteLine(b);
// Console.WriteLine(c);

//6. Example about using ArrayList
var arrList = new ArrayList();
arrList.Add(1); // Boxing: int -> object
arrList.Add(2); //Boxing: int -> object
//int sum = arrList[0] + arrList[1]; // Lỗi, vì arrList[1] và arrList[2] là object
var sum = (int)arrList[0] + (int)arrList[1]; //Unboxing: Object -> int (tốn CPU)
System.Console.WriteLine(sum);

var list = new List<int>();
list.Add(1); // Không cần boxing
list.Add(2);
int sum2 = list[0] + list[1]; // Không cần boxing thì đương nhiên k cần unboxing
System.Console.WriteLine(sum2);
