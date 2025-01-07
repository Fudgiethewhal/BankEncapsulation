namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            
            var currentBalance = account.GetBalance();
            
            Console.WriteLine(currentBalance);
            
            account.Deposit(amount: 200);
            
            currentBalance = account.GetBalance();
            
            Console.WriteLine(currentBalance);
            
        }
    }
}
