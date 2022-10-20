using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralPattern.Bridge
{
    public class ParisMarket : Market
    {
        public ParisMarket(ITrader trader, string marketName) : base(trader, marketName)
        {

        }

        protected override void InitiateMarket()
        {
            var airBusShare = new Share("Airbus Group", 94.700f, 456);
            var bnpShare = new Share("BNP Paribas", 45.475f, 89);
            var bouyguesShare = new Share("Bouygues", 27.670f, 254);
            var publicisShare = new Share("Publicis", 52, 125);
            var thalesShare = new Share("Thales", 114.4f, 875);
            Shares.Add(airBusShare.CompanyName, airBusShare);
            Shares.Add(bouyguesShare.CompanyName, bouyguesShare);
            Shares.Add(publicisShare.CompanyName, publicisShare);
            Shares.Add(bnpShare.CompanyName, bnpShare);
            Shares.Add(thalesShare.CompanyName, thalesShare);
        }

        public override void TraderBuyShares(Share share, int quantity)
        {
            _trader.AddFrenchShares(share, quantity);            
        }
    }
}
