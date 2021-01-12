using System;
using static System.Console;

using Simulator.API;
using Simulator.API.Models;
using Simulator.API.Services;


namespace Simulator.SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            ECommerce eCommerce = new ECommerce(
                new Traffic { Amount = 1000, CPC = 0.02 },
                new LandingPage { CTR = 1 },
                new SalesPage { Cost = 1, Price = 10, CR = .01f },
                new UpSell { Cost = 2, Price = 10, CR = .5f });


            WriteLine(eCommerce);

            ReadLine();
        }
    }
}
