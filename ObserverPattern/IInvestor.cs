using System;
using System.Collections.Generic;
using System.Text;

namespace MyObserver
{
    public interface IInvestor<Stock> : IObserver<Stock>
    {
        void StopInvestment();
        void Invest(IStockMarket<Stock> stockMarket);
    }
}
