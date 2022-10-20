 using System;
using System.Collections.Generic;

namespace StructuralPattern.Bridge
{
    public abstract class Market
    {
        protected ITrader _trader { get; set; }
        
        public IDictionary<string, Share> Shares { get; set; }

        public string MarketName { get; set; }

        public Market(ITrader trader, string marketName)
        {
            Shares = new Dictionary<string, Share>();
            _trader = trader;
            MarketName = marketName;
            InitiateMarket();
        }

        protected abstract void InitiateMarket();

        public abstract void TraderBuyShares(Share share, int quantity);
    }
}

