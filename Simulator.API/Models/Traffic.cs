using System;
using System.Collections.Generic;
using System.Text;

namespace Simulator.API.Models
{
    public class Traffic
    {
        /// <summary>
        /// How much traffic
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Cost-Per-Click
        /// </summary>
        public double CPC { get; set; }

        /// <summary>
        /// Total traffic cost
        /// </summary>
        public double TotalCost => Amount * CPC;
    }
}
