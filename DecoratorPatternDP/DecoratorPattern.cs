using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternDP
{
    class FlightWithDP
    {
        public string GetFlight()
        {
            return "flightdata";
        }
    }

    class FlightWithTimelinesWithDP
    {
        private readonly FlightWithDP _flight;
        public FlightWithTimelinesWithDP(FlightWithDP flight)
        {
            _flight = flight;
        }
        public string GetTimelines()
        {
            return _flight.GetFlight() + ";" + "timelinesdata";
        }
    }

    class FlightWithPassengersWithDP
    {
        private readonly FlightWithDP _flight;
        public FlightWithPassengersWithDP(FlightWithDP flight)
        {
            _flight = flight;
        }
        public string GetPassengers()
        {
            return _flight.GetFlight() + ";" + "passengersdata";
        }
    }
}
