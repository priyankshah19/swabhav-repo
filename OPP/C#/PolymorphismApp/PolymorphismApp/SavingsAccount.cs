using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismApp
{
    class SavingsAccount : AccountDetails
    {
      //  public const double savingminimum= 500;
        
        public SavingsAccount(string name1, int accountnumber1, double balance1) :base(name1,accountnumber1,balance1)
        {

        }
        public override void Withdraw(double amount)
        {
            double _newbalance = _balance - amount;
            if (_newbalance < Constants.savingminimum)
            {
                Console.WriteLine("You cannot withdraw");
            }
            else
            {
                _balance = _balance - amount;
            }
        }

    }
}
