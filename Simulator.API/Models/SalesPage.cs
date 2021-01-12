using System;
using System.Collections.Generic;
using System.Text;

namespace Simulator.API.Models
{
    public class SalesPage
    {
        /// <summary>
        /// Sale price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Buying price
        /// </summary>
        public double Cost { get; set; }

        /// <summary>
        /// Conversion Rate
        /// </summary>
        public float CR { get; set; }

        /// <summary>
        /// Profit from one action
        /// </summary>
        public double TotalProfitPerAction => Price - Cost;
    }
}
