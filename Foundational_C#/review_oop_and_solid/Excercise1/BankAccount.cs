public class BankAccount{
  private int AccountNumber  { get; } //Chỉ đọc, không thể khởi tạo
  private int Balance;

public BankAccount()
  {
    this.AccountNumber = 0; 
    this.Balance = 0;
  }
  //Khởi tao một lần duy nhất khi dùng contructor
  public BankAccount(int accountNumber)
  {
    this.AccountNumber = accountNumber; 
  }
  public void Deposit(int desposit){
    if(desposit > 0){
      Balance += desposit;
    }
    else {
      Console.WriteLine("Deposit must > 0");
    }
  }
  public void Withdraw(int withdraw){
    if( withdraw > 0 && withdraw <= Balance )
    {
        Balance -= withdraw;
    }
    else 
    {
      Console.WriteLine("Withdraw must > 0 and <= balance");
    }
  }
  public void GetBalance(){
    Console.WriteLine($"Account number: {AccountNumber} has {Balance}." );
  }

}
