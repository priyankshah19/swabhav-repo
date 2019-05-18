using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismApp
{
    class CurrentAccount : AccountDetails
    {
       // public const double currentminimum = -5000;
        public CurrentAccount(string name, int accountnumber, double balance) : base(name, accountnumber, balance)
        {

        }
        public override void Withdraw(double amount)
        {

            double _newbalance = _balance - amount;
            if (_newbalance < Constants.currentminimum)
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
