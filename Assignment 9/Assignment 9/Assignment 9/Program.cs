using System;

using System.Threading;



namespace TrafficLightSimulation

{

    enum TrafficLight

    {

        Red,

        Yellow,

        Green

    }



    class Program

    {

        static void Main()

        {

            Console.Write("Enter the number of cycles: ");

            int cycles;

            if (!int.TryParse(Console.ReadLine(), out cycles) || cycles <= 0)

            {

                Console.WriteLine("Invalid input. Please enter a positive number.");

                return;

            }



            TrafficLight currentLight = TrafficLight.Red;



            for (int i = 0; i < cycles; i++)

            {

                switch (currentLight)

                {

                    case TrafficLight.Red:

                        Console.WriteLine("Red Light - Stop");

                        Thread.Sleep(3000); // Wait for 3 seconds

                        currentLight = TrafficLight.Green;

                        break;



                    case TrafficLight.Green:

                        Console.WriteLine("Green Light - Go");

                        Thread.Sleep(2000); // Wait for 2 seconds

                        currentLight = TrafficLight.Yellow;

                        break;



                    case TrafficLight.Yellow:

                        Console.WriteLine("Yellow Light - Get Ready");

                        Thread.Sleep(1000); // Wait for 1 second

                        currentLight = TrafficLight.Red;

                        break;

                }

            }



            Console.WriteLine("Simulation Complete");

        }

    }

}