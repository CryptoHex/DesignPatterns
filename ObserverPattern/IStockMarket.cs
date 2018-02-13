using System;
using System.Collections.Generic;
using System.Text;

namespace MyObserver
{
    public interface IStockMarket<Stock> : IObservable<Stock>
    {
    }
}
