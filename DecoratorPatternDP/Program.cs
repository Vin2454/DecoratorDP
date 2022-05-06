using DecoratorPatternDP;
using System;

namespace AdapterPatternDP
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Inheritance with class explosion, the problem
            //FlightWithTimelines ft = new FlightWithTimelines();
            //string flightTimelinesData = ft.GetTimelines();
            //Console.WriteLine(flightTimelinesData);

            //FlightWithPassengers fp = new FlightWithPassengers();
            //string flightPassengersData = fp.GetPassengers();
            //Console.WriteLine(flightPassengersData);
            //Console.ReadLine();

            // composition using adapter pattern
            FlightWithDP flight = new FlightWithDP();
            FlightWithTimelinesWithDP ft = new FlightWithTimelinesWithDP(flight);
            string flightTimelinesData = ft.GetTimelines();
            Console.WriteLine(flightTimelinesData);

            FlightWithPassengersWithDP fp = new FlightWithPassengersWithDP(flight);
            string flightPassengersData = fp.GetPassengers();
            Console.WriteLine(flightPassengersData);
            Console.ReadLine();
        }
    }
}
