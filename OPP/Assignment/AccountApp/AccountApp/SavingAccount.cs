using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp
{
    class SavingAccount:Account
    {
        public SavingAccount(int accno,string name,double balance):base(accno,name,balance)
        {

        }

        public override void WithDraw(double amount)
        {
            double _newbalance = _balance - amount;
            if(_newbalance<500)
            {
                Console.WriteLine("cannot withdraw");
            }
            else
            {
                _balance = _newbalance;
            }
        }
    }
}
