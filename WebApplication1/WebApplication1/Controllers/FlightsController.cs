using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    public class FlightsController : ApiController
    {
        //
        // GET: /Flights/
        public IHttpActionResult GetAllFlights()
        {
            var model = new List<Flight>
            {
                new Flight(){ID=1, Airline="from mdel", Approved=false, Cities= new[]{"ny","org"}, Date=new DateTime(2013,01,12), EndTime=(DateTime.Now.AddHours(3)), FlightNumber="122", Price=654.30, StartTime= DateTime.Now, TotalDuration=2},
                new Flight(){ID=1, Airline="from mdel", Approved=false, Cities= new[]{"ny","org"}, Date=new DateTime(2013,01,12), EndTime=DateTime.Now.AddHours(3), FlightNumber="122", Price=654.30, StartTime= DateTime.Now, TotalDuration=2}
            
            };
            return Ok(model) ;
            
        }
    }
}