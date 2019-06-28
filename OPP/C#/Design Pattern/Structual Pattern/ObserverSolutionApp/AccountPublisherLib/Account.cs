using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPublisherLib
{
  public  class Account
    {
        private string _name;
        private int _accountno;
        private double _balance;
        private string _email;
        private double _mobileno;
        private List<IBalanceChangeNotifer> _subscribelist=new List<IBalanceChangeNotifer>();
        public Account(string name,int accountno,string email,double mobileno,double balance)
        {
            this._name = name;
            this._accountno = accountno;
            this._email = email;
            this._mobileno = mobileno;
            this._balance = balance;

        }
        public string Name { get { return _name; } }
        public int Accountno { get { return _accountno; } }
        public double Balance { get { return _balance; } }
        public string Email { get { return _email; } }    
        public double MobileNo { get { return _mobileno; } }
        public double Deposit(double amount)
        {
            _balance = Balance + amount;
            Notification();
            return _balance;
          
        }
        public double WithDraw(double amount)
        {
           _balance = Balance - amount;
            Notification();
            return _balance;
          
        }
        public void RegisterNotifer(IBalanceChangeNotifer subscribe)
        {
            _subscribelist.Add(subscribe);
        }
        private void Notification()
        {
            foreach(var observer in _subscribelist)
            {
                observer.Notify(this);
            }
        }
      
    }
}
