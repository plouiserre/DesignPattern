using System;
using System.Collections.Generic;

namespace StructuralPattern.Product
{
    public class AmericanTrader
    {
        public string Identity  { get; set; }

        public List<Share> Shares { get; set; }

        public float DollarsAmount { get; set; }
        
        public AmericanTrader(string identity, float money)
        {
            Identity = identity;
            DollarsAmount = money;
            Shares = new List<Share>();
        }

        public virtual void BuyShares(List<Share> shares)
        {
            foreach(var share in shares)
            {
                float newAmount = DollarsAmount - share.Price * share.Stock;
                if (newAmount > 0)
                {
                    DollarsAmount = newAmount;
                    Shares.Add(share);
                }
                else
                {
                    Console.WriteLine("{0} cannot buy more shares");
                    break;
                }
            }
        }
    }
}

