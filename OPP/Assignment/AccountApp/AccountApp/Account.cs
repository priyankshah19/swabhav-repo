using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp
{
     abstract class Account
    {
        protected int _accno;
        protected string _name;
        protected double _balance;
        public Account(int accno,string name,double balance)
        {
            this._accno = accno;
            this._name = name;
            this._balance = balance;
        }
        public int GetAccNo { get { return _accno; } }
        public string GetName { get { return _name; } }
        public double GetBalance { get { return _balance; } }
        public void Deposit(int amount)
        {
            _balance = _balance + amount;
        }
        public abstract void WithDraw(double amount);

    }
}
