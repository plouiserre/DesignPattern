using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralPattern.Bridge
{
    public class EuropeanTrader : Trader, ITrader
    {
        private float _changeDollarsEuros { get; set; }
        private float _changeYuanEuros { get; set; }

        public EuropeanTrader(float cash)
        {
            _changeDollarsEuros = 1.02f;
            _changeYuanEuros = 0.14f;
            Shares = new Dictionary<Share, int>();
            AmountCash = cash;
        }

        public override bool AddAmericanShares(Share share, int quantity)
        {
            bool result = AddShares(share, quantity, _changeDollarsEuros);
            return result;
        }

        public override bool AddChineseShares(Share share, int quantity)
        {
            bool result = AddShares(share, quantity, _changeYuanEuros);
            return result;
        }

        public override bool AddFrenchShares(Share share, int quantity)
        {
            bool result = AddShares(share, quantity, 1);
            return result;
        }
    }
}
