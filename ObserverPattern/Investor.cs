using System;
using System.Collections.Generic;
using System.Text;

namespace MyObserver
{
    public class Investor : IInvestor<Stock>
    {
        private string name;
        private double entryPrice;
        private double currentPrice;
        private string stockName;
        private IDisposable unsubscriber;

        public Investor(string name, Stock stock)
        {
            this.name = name;
            this.stockName = stock.Name;
            this.entryPrice = stock.Price;
            this.currentPrice = stock.Price;
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("An error has occured");
        }

        public void OnNext(Stock value)
        {
            if(value.Name == stockName)
            {
                Console.WriteLine($"{this.name} has followed the price change from {this.currentPrice:f4} to {value.Price:f4} of {value.Name}");
                currentPrice = value.Price;
            }
        }

        public void Invest(IStockMarket<Stock> stockMarket)
        {
            unsubscriber = stockMarket.Subscribe(this);
        }

        public void StopInvestment()
        {
            unsubscriber.Dispose();
            var priceDifference = Math.Abs(entryPrice - currentPrice);
            Console.WriteLine($"{this.name} has exited the {stockName} Market with a price difference of {priceDifference}");
            Console.WriteLine("---");
        }
    }
}
