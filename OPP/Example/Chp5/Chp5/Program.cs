using System;
using System.Collections.Generic;
using System.Text;

namespace Chp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Block b = new Block();
            b.run();
        }
        class Block
        {
            int move;
            String[] input = new String[8];
            public void run()
            {
                int i;
                input[2] = "ship";
                input[3] = "is";
                input[4] = "sinking";
                for(i=0;i<input.Length;i++)
                {
                    if(input[i]==null)
                    {
                        input[i] = "miss";
                    }
                    else
                    {

                    }
                }
                Console.WriteLine("Enter your move");
               
                move = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your move");

            }



        }
    }
}
