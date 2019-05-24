using InterfaceApp.ManBoy;
using InterfaceApp.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Casestudy1();
            Casestudy2();
        }

        public static void Casestudy2()
        {
            //  Bike honda = new Bike("honda", "city");
            //  Bike pulsar = new Bike("pulsar", "800");
            IMovable[] vehicles = new IMovable[4];
            vehicles[0] = new Car("honda", "city");
            vehicles[1] = new Car("Maruti", "800");
            vehicles[2] = new Truck("Mahindra", "tempo");
            vehicles[3] = new Bike("Pulsar", "220");
            StartRace(vehicles);
           





        }

        private static void StartRace(IMovable[] imove)
        {

            Console.WriteLine("Race Starts");
          
           foreach(IMovable movable in imove)
            {
                movable.Move();
            }
            Console.WriteLine("End Race");  
        }
        private static void Casestudy1()
        {
            AttheParty(new Man());
            AttheParty(new Boy());
            AttheMovie(new Boy());
            // AttheMovie(new Man()); we will get eror becoz man does not extend iemotionable interface

        }

        private static void AttheParty(IManerable imanner)
        {
            Console.WriteLine("At the Party");
            imanner.Wish();
            imanner.DepartingGoodBye();
        }

        private static void AttheMovie(IEmotionable iemotion)
        {
            Console.WriteLine("At the Movie");
            iemotion.Cry();
            iemotion.Laugh();
        }

    }

}
