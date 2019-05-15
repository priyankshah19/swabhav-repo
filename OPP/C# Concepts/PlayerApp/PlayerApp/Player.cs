using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerApp
{
    class Player
    {
        private string _name;
        private int _age, _id;
      static int  count;
        
       public Player(string _name, int _age, int _id)
        
        {
            
           
            this._name = _name;
            this._age = _age;
            this._id = _id;
            Console.WriteLine("inside constructor");
                count++;
        }

        
        public  Player(string _name,  int _id) :this(_name,18,_id)
        {
          // this.count++;
        }

         public  Player  WhoisElder(Player player)
        {
            if(player._age>_age)
            {

                return player;
            }
            else
            {
                return this;
            }
        }

      public static int GetCount()
        {
         
            return count;
           
        }

        static Player()
        {
            Console.WriteLine("inside static constructor");
        }

        public string Name { get { return _name; } }
        public int Age {  get { return _age; } }
        public int Id { get { return _id; } }
     //  public int GetCount { get { return count; } }
    }
    
         
        }
    

