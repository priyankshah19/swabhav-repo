using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismApp
{
    static class Constants
    {
        public const double currentminimum = -5000;
        public const double savingminimum = 500;
    }
   public abstract class AccountDetails
    {
        protected string _name;
        protected int _accountnumber;
        protected double _balance;

        public AccountDetails(string name,int accountnumber, double balance)
        {
            this._name = name;
            this._accountnumber = accountnumber;
            this._balance = balance;
        }

        public string GetName { get { return _name; } }
        public int GetAccountNumber { get { return _accountnumber; } }
        public double GetBalance { get { return _balance; } }

        public void Deposit(double amount)
        {
            _balance = _balance + amount;
        }

        public abstract void Withdraw(double amount);
        
    }
}
