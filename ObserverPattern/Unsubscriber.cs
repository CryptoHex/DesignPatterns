using System;
using System.Collections.Generic;
using System.Text;

namespace MyObserver
{
    internal class Unsubscriber<Stock> : IDisposable
    {
        private List<IObserver<Stock>> investors;
        private IObserver<Stock> investor;

        internal Unsubscriber(List<IObserver<Stock>> investors, IObserver<Stock> investor)
        {
            this.investors = investors;
            this.investor = investor;
        }

        public void Dispose()
        {
            if(investors.Contains(investor))
                investors.Remove(investor);
        }

    }
}
