using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternDP
{
    class Flight
    {
        protected string GetFlight()
        {
            return "flightdata";
        }
    }

    class FlightWithTimelines : Flight
    {
        public string GetTimelines()
        {
            return GetFlight() + ";" + "timelinesdata";
        }
    }

    class FlightWithPassengers : Flight
    {
        public string GetPassengers()
        {
            return GetFlight() + ";" + "passengersdata";
        }
    }
}
