using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralPattern.Bridge
{
    public class ShanghaiMarket : Market
    {
        public ShanghaiMarket(ITrader trader, string marketName) : base(trader, marketName)
        {

        }

        protected override void InitiateMarket()
        {
            var kweichowMoutaiShare = new Share("Kweichow moutai", 1872.50f, 574);
            var icbcShare = new Share("ICBC", 4.35f, 5336);
            var pingAnShare = new Share("Ping An", 41.58f, 987);
            var bankOfChinaShare = new Share("Bank Of China", 3.09f, 7423);
            var petroChinaShare = new Share("Petro China", 5.09f, 4125);
            Shares.Add(kweichowMoutaiShare.CompanyName, kweichowMoutaiShare);
            Shares.Add(icbcShare.CompanyName, icbcShare);
            Shares.Add(pingAnShare.CompanyName, pingAnShare);
            Shares.Add(petroChinaShare.CompanyName, petroChinaShare);
            Shares.Add(bankOfChinaShare.CompanyName, bankOfChinaShare);
        }

        public override void TraderBuyShares(Share share, int quantity)
        {
            _trader.AddChineseShares(share, quantity);            
        }
    }
}
