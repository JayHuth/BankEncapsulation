using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0;

        public void Deposit(double amount)
        {
            Console.WriteLine($"Accepting a deposit of {amount, 0:c} to your account.");
            _balance = amount;
        }

        //public void Withdraw(double amount)
        //{
        //    Console.WriteLine($"Initiating your withdraw of {amount,0:c} from your account.");
        //    _balance = amount;
        //}

        public double GetBalance()
        {
            return _balance;
        }

    }

        
}
