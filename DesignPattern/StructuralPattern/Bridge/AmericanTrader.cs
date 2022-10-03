using System;
using System.Collections.Generic;

namespace StructuralPattern.Bridge
{
    public class AmericanTrader : ITrader
    {
        private float _eurosDollarsChange { get; set; }

        private float _yuanDollarsChange { get; set; }

        public Dictionary<Share, int> Shares { get; set; }
        public float AmountCash { get; set; }

        public AmericanTrader(float cash, float eurosDollarsChange, float yuanDollarsChange)
        {
            Shares = new Dictionary<Share, int>();
            AmountCash = cash;
            _eurosDollarsChange = eurosDollarsChange;
            _yuanDollarsChange = yuanDollarsChange;
        }

        public bool AddAmericanShares(Share share, int quantity)
        {
            float priceBuy = share.Price * quantity;
            if (priceBuy > AmountCash)
                return false;
            else
            {
                if (Shares.ContainsKey(share))
                {

                    int lastQuantity = Shares[share]
                }
                return true;
            }
        }

        public bool AddFrenchShares(Share share, int quantity)
        {
            throw new NotImplementedException();
        }

        public bool AddChineseShares(Share share, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}

