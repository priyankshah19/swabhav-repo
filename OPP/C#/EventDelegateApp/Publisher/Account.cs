using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publisher
{
   public delegate void DBalance(Account account);
   public class Account
    {
        private int _accountno;
        private string _name;
        private double _balance;
        public event DBalance BalanceChangeEvent;
        public Account(int accountno,string name,double amount)
        {
            this._accountno = accountno;
            this._name = name;
            this._balance = amount;
        }
        public int GetAccountno { get { return _accountno; } }
        public string GetName { get { return _name; } }
        public double GetAmount { get { return _balance; } }
        public void Deposit(double amount)
        {
            _balance = _balance + amount;
            if(BalanceChangeEvent!=null)
            {
                BalanceChangeEvent(this);
            }
        }
       
    }
}
