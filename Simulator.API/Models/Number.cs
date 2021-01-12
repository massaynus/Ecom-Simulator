using System;
using System.Collections.Generic;
using System.Text;

namespace Simulator.API.Models
{
    public class Number
    {
        public string Name { get; set; }
        public double Total { get; set; }

        public override string ToString()
        {
            return string.Format("{0, -40}{1:N2}", Name, Total);
        }
    }
}
