using System;
using System.Collections.Generic;

namespace StructuralPattern.Bridge
{
    public abstract class Market
    {
        public string MarketName { get; set; }

        public Dictionary<Share,int> Shares { get; set; }

        public abstract void InitiateMarket();

        public Market()
        {
        }
    }
}

