using System;
using System.Collections.Generic;
using System.Text;

namespace OverridingApp
{
    class Account
    {
         int _accountnumber;
          string _name;
         double _balance;

        public Account(string name, double balance, int accountnumber)
        {
            _accountnumber = accountnumber;
            _name = name;
            _balance = balance;
        }

       public  Account(int accountnumber, string name)
        {
            _accountnumber = accountnumber;
            _name = name;
            
        }

        public void Deposit(double balance)
        {
            _balance =_balance+ balance ;

           

        }
        
        public void WithDraw(double amount)
        {



           
               double   newbalance = _balance - amount;

                if (newbalance < 500)
                {
                    Console.WriteLine("Cannot withdraw");
                }
                else
                {
                    _balance = _balance - amount;
                }

           
            

        }

        public int Accountnumber { get { return _accountnumber; } }
        public string Name { get { return _name; } }
        public double Balance { get { return _balance; } }


        public override string ToString()    //here we have override tostring method to get output
        {
           
            return (base.ToString() +" " + "Account: " + _accountnumber + " " + _name + " " + _balance ) ; 
        }
            


        public override bool Equals(object customer2)
        {
            return true; 
        }
    }
}
