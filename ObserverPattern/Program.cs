using System;

namespace MyObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            var eurUsd = new Stock("EURUSD", 1.2388);
            var eurGbp = new Stock("EURGBP", 1.4111);

            var stockMarket = new StockMarket();

            var investorOne = new Investor("Michael", eurUsd);
            investorOne.Invest(stockMarket);
            var investorTwo = new Investor("David", eurUsd);
            investorTwo.Invest(stockMarket);
            var investorThree = new Investor("John", eurGbp);
            investorThree.Invest(stockMarket);

            stockMarket.PriceChange(eurUsd, 1.3000);
            stockMarket.PriceChange(eurUsd, 1.3444);
            stockMarket.PriceChange(eurGbp, 1.5222);

            investorOne.StopInvestment();

            stockMarket.PriceChange(eurUsd, 1.3555);
        }
    }
}
