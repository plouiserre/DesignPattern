using System;
using System.Collections.Generic;

namespace StructuralPattern.Product
{
    public class EuropeanTrader
    {
        public string  Identity { get; set; }

        public List<Share> Shares { get; set; }

        public float EurosAmount { get; set; }

        public EuropeanTrader(string identity)
        {
            Shares = new List<Share>();
            Identity = identity;
        }
    }
}

