using System;
using System.Collections.Generic;

namespace StructuralPattern.Bridge
{
    public class AmericanTrader : Trader, ITrader
    {
        private float _changeEurosDollars { get; set; }

        private float _changeYuanDollars { get; set; }

        public AmericanTrader(float cash)
        {
            Shares = new Dictionary<Share, int>();
            AmountCash = cash;
            _changeEurosDollars = 0.98f;
            _changeYuanDollars = 0.14f;
        }

        public override bool AddAmericanShares(Share share, int quantity)
        {
            bool result = AddShares(share, quantity, 1);
            return result;
        }

        public override bool AddFrenchShares(Share share, int quantity)
        {
            bool result = AddShares(share, quantity, _changeEurosDollars);
            return result;
        }

        public override bool AddChineseShares(Share share, int quantity)
        {
            bool result = AddShares(share, quantity, _changeYuanDollars);
            return result;
        }
    }
}

