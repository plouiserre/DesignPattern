using System;
using System.Collections.Generic;

namespace StructuralPattern.Bridge
{
    public interface ITrader
    {
        public Dictionary<Share,  int> Shares { get; set; }

        public float AmountCash { get; set; }

        public bool AddAmericanShares(Share share, int quantity);

        public bool AddFrenchShares(Share share, int quantity);

        public bool AddChineseShares(Share share, int quantity);
    }
}

