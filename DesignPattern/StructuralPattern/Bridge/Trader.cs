using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralPattern.Bridge
{
    public abstract class Trader : ITrader
    {
        public Dictionary<Share, int> Shares { get; set; }
        public float AmountCash { get; set; }

        public abstract bool AddAmericanShares(Share share, int quantity);
        public abstract bool AddChineseShares(Share share, int quantity);
        public abstract bool AddFrenchShares(Share share, int quantity);

        protected bool AddShares(Share share, int quantity, float changeRate)
        {
            float price = share.Price * quantity * changeRate;
            if (price > AmountCash)
                return false;
            else
            {
                if (Shares.ContainsKey(share))
                {
                    int newQuantity = Shares[share] + quantity;
                    Shares[share] = newQuantity;
                }
                else
                {
                    Shares.Add(share, quantity);
                }
                AmountCash -= price;
                return true;
            }
        }
    }
}
