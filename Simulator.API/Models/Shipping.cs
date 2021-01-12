using System;
using System.Collections.Generic;
using System.Text;

namespace Simulator.API.Models
{
    public class Shipping
    {
        /// <summary>
        /// Shipping cost
        /// </summary>
        public double Cost { get; set; }

        /// <summary>
        /// Delivrable %
        /// </summary>
        public float Deliverability { get; set; }
    }
}
