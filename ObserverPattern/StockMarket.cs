using System;
using System.Collections.Generic;
using System.Text;

namespace MyObserver
{
    public class StockMarket : IStockMarket<Stock>
    {
        private readonly List<IObserver<Stock>> observers;

        public StockMarket()
        {
            observers = new List<IObserver<Stock>>();
        }

        public IDisposable Subscribe(IObserver<Stock> observer)
        {
            if(!observers.Contains(observer))
            {
                observers.Add(observer);
            }
            return new Unsubscriber<Stock>(observers, observer);
        }

        public void PriceChange(Stock stock, double newPrice)
        {
            stock.Price = newPrice;
            foreach(var o in observers)
            {
                o.OnNext(stock);
            }
            Console.WriteLine("---");
        }
    }
}
