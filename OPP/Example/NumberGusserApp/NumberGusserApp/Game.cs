using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGusserApp
{
    class Game
    {
     


            public void run()
            {
               

                Boolean x = false;
                int read;



                Random random = new Random();
                int randomNumber = random.Next(1, 10);

                read = randomNumber;
                Console.WriteLine(read);
                while (x != true)
                {

                    Console.WriteLine("Enter number");
                    int input = Convert.ToInt32(Console.ReadLine());

                if ((input > 1) && (input < 10))
                    {


                        if (input > read)
                        {
                            Console.WriteLine("High");
                        }
                        else if (input < read)
                        {
                            Console.WriteLine("Low");
                        }
                        else if (input == read)
                        {
                            Console.WriteLine("Match Found");
                            x = true;
                        }

                    }


                    else
                    {
                        Console.WriteLine("Number not in range");

                    }


                }



            }


        }
    }

