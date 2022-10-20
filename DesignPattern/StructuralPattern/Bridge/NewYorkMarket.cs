using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralPattern.Bridge
{
    public class NewYorkMarket : Market
    {
        public NewYorkMarket(ITrader trader, string market) : base(trader, market)
        {

        }

        protected override void InitiateMarket()
        {
            var microsoftShares = new Share("Microsoft",248.070f,4563);
            var appleShares = new Share("Apple", 145.370f, 3664);
            var metaShares = new Share("Meta Platforms Inc.", 140.740f, 3542);
            var alphabetShares = new Share("Alphabet Inc Class A", 101.43f, 2348);
            var amazonShares = new Share("Amazon.com", 121.380f,2647);
            Shares.Add(microsoftShares.CompanyName,microsoftShares);
            Shares.Add(amazonShares.CompanyName, amazonShares);
            Shares.Add(appleShares.CompanyName, appleShares);
            Shares.Add(metaShares.CompanyName, metaShares);
            Shares.Add(alphabetShares.CompanyName, alphabetShares);
        }

        public override void TraderBuyShares(Share share, int quantity)
        {           
            _trader.AddAmericanShares(share,quantity);
        }
    }
}
