using System;
using System.Collections.Generic;
using System.Text;

namespace Cab_InvoiceGenerator
{
    public class Ride
    {
        public double rideDistance;
        public int rideTime;
        public Ride(double rideDistance, int rideTime)
        {
            this.rideDistance = rideDistance;
            this.rideTime = rideTime;
        }
    }
}
