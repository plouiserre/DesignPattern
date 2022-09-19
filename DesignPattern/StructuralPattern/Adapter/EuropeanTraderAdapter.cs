using System;
using System.Collections.Generic;
using StructuralPattern.Product;

namespace StructuralPattern.Adapter
{
    public class EuropeanTraderAdapter : AmericanTrader
    {
        private float _exchangeRate { get; set; }

        private EuropeanTrader _europeanTrader { get; set; }

        public EuropeanTraderAdapter(float exchangeRate, EuropeanTrader trader, float money) : base(trader.Identity, money)
        {
            _exchangeRate = exchangeRate;
            _europeanTrader = trader;
        }

        public override void BuyShares(List<Share> shares)
        {
            base.BuyShares(shares);

            float amoutEuros = DollarsAmount * _exchangeRate;

            _europeanTrader.Shares.AddRange(Shares);

            _europeanTrader.EurosAmount = amoutEuros;

        }
    }
}

