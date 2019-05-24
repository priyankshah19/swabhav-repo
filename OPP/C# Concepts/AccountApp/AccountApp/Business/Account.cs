using System;
using System.Collections.Generic;
using System.Text;

namespace AccountApp.Business
{
    class Account
    {
        protected int _accountnumber;
        protected string _name;
        protected double _balance;


        public Account(int accountnumber, string name, double balance)
        {
            _accountnumber = accountnumber;
            _name = name;
            _balance = balance;
        }

        public Account(int accountnumber, string name)
        {
            _accountnumber = accountnumber;
            _name = name;

        }

        public void Deposit(double balance)
        {
            _balance = _balance + balance;



        }

        public void WithDraw(double amount)
        {




            double newbalance = _balance - amount;

            if (newbalance < 500)
            {



                throw new InsufficientException(this);
            }
            else
            {
                _balance = _balance - amount;
            }




        }

        public int Accountnumber { get { return _accountnumber; } }
        public string Name { get { return _name; } }
        public double Balance { get { return _balance; } }


    }
}
