using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Model
{
    public class FlightDb: DbContext
    {
        public DbSet<Flight> Flights { get; set; }
    }
}