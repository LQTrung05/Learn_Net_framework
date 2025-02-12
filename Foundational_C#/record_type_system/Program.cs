public record Person(string FirstName, string LastName, string[] PhoneNumber);
public static class Program{
  public static void Main(){
    var phoneNumbers = new string[2]{ "123456789", "987654321" }; 
    var person1 = new Person("LQ","Trung", phoneNumbers);
    var person2 = new Person("LQ","Trung", phoneNumbers);
    Console.WriteLine(person1 == person2); // output: True

    phoneNumbers[0] = "123456789"; 
    Console.WriteLine(person1 == person2); // output: True
    
    Console.WriteLine(ReferenceEquals(person1, person2)); // output: False

  }
}