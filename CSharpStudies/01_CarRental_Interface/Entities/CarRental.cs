using System;

namespace CSharpStudies.Entities
{
    internal class CarRental
    {
        public Vehicle Vehicle { get; private set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(Vehicle vehicle, DateTime start, DateTime finish)
        {
            Vehicle = vehicle;
            Start = start;
            Finish = finish;
            Invoice = null;
        }
    }
}