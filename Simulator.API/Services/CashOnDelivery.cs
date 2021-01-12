using Simulator.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Simulator.API.Services
{
    public class CashOnDelivery : ECommerce
    {

        public CallCenter CallCenter { get; private set; }
        public Shipping Shipping { get; private set; }

        public CashOnDelivery(Traffic traffic,
                              LandingPage landingPage,
                              SalesPage salesPage,
                              UpSell upSell,
                              CallCenter callCenter,
                              Shipping shipping)
            : base(traffic, landingPage, salesPage, upSell)
        {
            (CallCenter, Shipping) = (callCenter, shipping);

            double actions = Traffic.Amount * LandingPage.CTR * CallCenter.CR;

            Costs = new Number
            {
                Name = "Total Costs",
                Total = Traffic.TotalCost 
                + (actions * SalesPage.CR * SalesPage.Cost)
                + (actions * UpSell.CR * UpSell.Cost)
                + (actions * Shipping.Cost)
                + (Traffic.Amount * LandingPage.CTR * CallCenter.Cost)
            };

            Profits = new Number
            {
                Name = "Total Profits",
                Total = 
                (
                    (Traffic.Amount * LandingPage.CTR * CallCenter.CR * SalesPage.TotalProfitPerAction * SalesPage.TotalProfitPerAction) +
                    (Traffic.Amount * LandingPage.CTR * CallCenter.CR * UpSell.TotalProfitPerAction * UpSell.TotalProfitPerAction)
                )
                * Shipping.Deliverability
            };

            Balance = new Number
            {
                Name = "Balance",
                Total = Profits.Total - Costs.Total
            };
        }

        public override List<Number> GetNumbers()
        {
            var nums = base.GetNumbers();
            nums.Add(new Number
            {
                Name = "Total Call center cost",
                Total = Traffic.Amount * LandingPage.CTR * CallCenter.Cost
            });

            nums.Add(new Number
            {
                Name = "Total shipping cost",
                Total = Traffic.Amount * LandingPage.CTR * CallCenter.CR * Shipping.Cost
            });

            return nums;
        }
    }
}
