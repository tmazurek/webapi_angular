namespace WebApplication1.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication1.Model;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Model.FlightDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebApplication1.Model.FlightDb context)
        {
            if(!context.Flights.Any())
            {
                context.Flights.AddRange(
                    new List<Flight>()
                    { new Flight {ID = 1, Airline= "united", Approved=false, Cities= new[]{"org","ny"}, Date=DateTime.Now, EndTime=DateTime.Now, StartTime= DateTime.Now, FlightNumber="12", Price=400, TotalDuration=2}

                    }
                    );


            }
            
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
