using System;
using System.Collections.Generic;
using System.Text;

namespace AccountApp.Business
{
    class InsufficientException : Exception
    {
        // private  string _message;
        /*  public InsufficientException(string message):base(message)
          {
              _message = message;  
          }
          public override string Message
          {
              get
              {
                  return _message;
              }
          } */
        private double _balance1;
        public string _name1 { get; set; }
        public int _accountnumber1 { get; set; }
        Account _account1 = new Account(1002, "meet", 1000.0);



        //  Account meet = new Account(1000,"meet",1000);
        public InsufficientException(Account account)
        {
            _account1 = account;

        }

        public Account Account1 { get { return _account1; } }

        //  public double Balance1 { get { return _balance1; } }
    }
}
