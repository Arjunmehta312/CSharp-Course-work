using System;
using System.Collections.Generic;
using System.Linq;

namespace FlightInformationSystem
{
    class Flight
    {
        public string FlightNumber { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string Status { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Flight> flights = new List<Flight>
            {
                new Flight { FlightNumber = "FL001", Origin = "New York", Destination = "London", DepartureTime = DateTime.Now.AddHours(2), ArrivalTime = DateTime.Now.AddHours(8), Status = "On Time" },
                new Flight { FlightNumber = "FL002", Origin = "Los Angeles", Destination = "Tokyo", DepartureTime = DateTime.Now.AddHours(3), ArrivalTime = DateTime.Now.AddHours(13), Status = "Delayed" },
                new Flight { FlightNumber = "FL003", Origin = "Chicago", Destination = "Paris", DepartureTime = DateTime.Now.AddHours(1), ArrivalTime = DateTime.Now.AddHours(9), Status = "Cancelled" },
                new Flight { FlightNumber = "FL004", Origin = "New York", Destination = "Toronto", DepartureTime = DateTime.Now.AddHours(5), ArrivalTime = DateTime.Now.AddHours(7), Status = "On Time" },
                new Flight { FlightNumber = "FL005", Origin = "San Francisco", Destination = "Sydney", DepartureTime = DateTime.Now.AddHours(4), ArrivalTime = DateTime.Now.AddHours(16), Status = "On Time" },
                new Flight { FlightNumber = "FL006", Origin = "New York", Destination = "Dubai", DepartureTime = DateTime.Now.AddHours(6), ArrivalTime = DateTime.Now.AddHours(14), Status = "Delayed" },
                new Flight { FlightNumber = "FL007", Origin = "Miami", Destination = "Berlin", DepartureTime = DateTime.Now.AddHours(7), ArrivalTime = DateTime.Now.AddHours(11), Status = "On Time" },
                new Flight { FlightNumber = "FL008", Origin = "New York", Destination = "Rome", DepartureTime = DateTime.Now.AddHours(8), ArrivalTime = DateTime.Now.AddHours(12), Status = "Cancelled" },
                new Flight { FlightNumber = "FL009", Origin = "Chicago", Destination = "Moscow", DepartureTime = DateTime.Now.AddHours(9), ArrivalTime = DateTime.Now.AddHours(17), Status = "Delayed" },
                new Flight { FlightNumber = "FL010", Origin = "Los Angeles", Destination = "Beijing", DepartureTime = DateTime.Now.AddHours(10), ArrivalTime = DateTime.Now.AddHours(20), Status = "On Time" }
            };

            while (true)
            {
                Console.WriteLine("\nFlight Information System");
                Console.WriteLine("1. Display flights from a specific origin");
                Console.WriteLine("2. Display flights sorted by departure time");
                Console.WriteLine("3. Display delayed or cancelled flights");
                Console.WriteLine("4. Display the earliest departing flight");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter origin city: ");
                        string origin = Console.ReadLine();
                        var flightsFromOrigin = flights.Where(f => f.Origin == origin);
                        foreach (var flight in flightsFromOrigin)
                            Console.WriteLine($"{flight.FlightNumber} to {flight.Destination} departs at {flight.DepartureTime}");
                        break;

                    case 2:
                        var sortedFlights = flights.OrderBy(f => f.DepartureTime);
                        foreach (var flight in sortedFlights)
                            Console.WriteLine($"{flight.FlightNumber} to {flight.Destination} departs at {flight.DepartureTime}");
                        break;

                    case 3:
                        var delayedOrCancelledFlights = flights.Where(f => f.Status == "Delayed" || f.Status == "Cancelled");
                        foreach (var flight in delayedOrCancelledFlights)
                            Console.WriteLine($"{flight.FlightNumber} to {flight.Destination} is {flight.Status}");
                        break;

                    case 4:
                        var earliestFlight = flights.OrderBy(f => f.DepartureTime).FirstOrDefault();
                        Console.WriteLine($"{earliestFlight.FlightNumber} to {earliestFlight.Destination} departs at {earliestFlight.DepartureTime}");
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}