using System;
using System.Collections.Generic;
using System.Text;

namespace Simulator.API.Models
{
    public class CallCenter
    {
        /// <summary>
        /// Call cost
        /// </summary>
        public double Cost { get; set; }

        /// <summary>
        /// Confirmation Rate
        /// </summary>
        public float CR { get; set; }
    }
}
