using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    /// <summary>
    /// Ride class to get ride based on the travel time and distance
    /// </summary
    public class Ride
    {
        public double distance;
        public int minutes;

        public Ride(double distance, int minutes)
        {
            this.distance = distance;
            this.minutes = minutes;
        }
    }
}
