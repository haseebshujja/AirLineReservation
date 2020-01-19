using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLine
{
    public interface IFlight
    {
         int PassengerID { get; set; }
         string PassengerName { get; set; }
         int LuggageWeightCarried { get; set; }
         string FlightTo { get; set; }
         int SeatNumber { get; set; }

         string SeatColumn { get; set; }
    }
}
