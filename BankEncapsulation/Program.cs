namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount();

            Console.WriteLine("How much money will you be depositing today?");
            double amountToDeposit = double.Parse(Console.ReadLine());

            ba.Deposit(amountToDeposit);
            double userBalance = ba.GetBalance();

            Console.WriteLine($"your current balance is: {userBalance, 0:c}");
        }

        //static void Main(string[] args)
        //{
        //    BankAccount ba = new BankAccount();

        //    Console.WriteLine("How much money will you be withdrawing today?");
        //    double amountToWithdraw = double.Parse(Console.ReadLine());

        //    ba.Withdraw(amountToWithdraw);
        //    double userBalance = ba.GetBalance();

        //    Console.WriteLine($"your balance is: {userBalance,0:c}");
        //}
    }
}
