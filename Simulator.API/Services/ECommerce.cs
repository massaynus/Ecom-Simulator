using Simulator.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Simulator.API.Services
{
    public class ECommerce
    {
        public Traffic Traffic { get; private set; }
        public LandingPage LandingPage { get; private set; }
        public SalesPage SalesPage { get; private set; }
        public UpSell UpSell { get; private set; }
        public Number Costs { get; set; }
        public Number Profits { get; set; }
        public Number Balance { get; set; }

        public ECommerce(Traffic traffic, LandingPage landingPage, SalesPage salesPage, UpSell upSell)
        {
            (Traffic, LandingPage, SalesPage, UpSell) = (traffic, landingPage, salesPage, upSell);
            double actions = Traffic.Amount * LandingPage.CTR * SalesPage.CR;

            Costs = new Number
            {
                Name = "Total Costs",
                Total = Traffic.TotalCost
                + (actions * SalesPage.Cost)
                + (actions * UpSell.CR * UpSell.Cost)
            };

            Profits = new Number
            {
                Name = "Total Profits",
                Total = (actions * SalesPage.Price)
                + (actions * UpSell.CR * UpSell.Price)
            };

            Balance = new Number
            {
                Name = "Balance",
                Total = Profits.Total - Costs.Total
            };
        }

        public virtual List<Number> GetNumbers()
        {
            double actions = Traffic.Amount * LandingPage.CTR * SalesPage.CR;
            List<Number> numbers = new List<Number>();

            numbers.Add(new Number
            {
                Name = "Total Traffic Spendings",
                Total = Traffic.TotalCost
            });

            numbers.Add(new Number
            {
                Name = "Clicked Through",
                Total = Traffic.Amount * LandingPage.CTR
            });

            numbers.Add(new Number
            {
                Name = "Sales Page sales",
                Total = actions
            });

            numbers.Add(new Number
            {
                Name = "Sales Page profits",
                Total = actions * SalesPage.TotalProfitPerAction
            });

            numbers.Add(new Number
            {
                Name = "UpSell sales",
                Total = actions * UpSell.CR
            });


            numbers.Add(new Number
            {
                Name = "UpSell profits",
                Total = actions * UpSell.CR * UpSell.TotalProfitPerAction
            });

            return numbers;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            GetNumbers().ForEach(n => builder.AppendLine(n.ToString()));

            builder.AppendLine("\n\n");

            builder.AppendLine(Costs.ToString());
            builder.AppendLine(Profits.ToString());
            builder.AppendLine(Balance.ToString());

            return builder.ToString();
        }

    }
}