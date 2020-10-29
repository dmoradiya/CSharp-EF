using CSharp_EF.Models;
using System;

namespace CSharp_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleContext context = new VehicleContext();

            context.Vehicle.Add(new Vehicle()
            {
               Id = 9,
               Manufacturer = "Honda",
               Model = "Civic",
               ModelYear = 2006,
               Colour = "Blue"

            });
            context.SaveChanges();
        }
    }
}
