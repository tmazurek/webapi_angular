using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Model
{
    public class Flight
    {
        public int ID { get; set; }
        public string Airline { get; set; }
        public string FlightNumber { get; set; }
        
    
        
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int TotlaDuration { get; set; }
        public double Prize { get; set; }
        public DateTime Date { get; set; }
        public string[] Cities { get; set; }
        public bool Approved { get; set; }

    }
}