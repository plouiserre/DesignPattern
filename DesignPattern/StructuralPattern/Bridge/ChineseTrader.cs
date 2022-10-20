using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralPattern.Bridge
{
    public class ChineseTrader : Trader, ITrader
    {
        private float _changeDollarsYuan { get; set; }

        private float _changeEurosYuan { get; set; }

        public ChineseTrader(float cash)
        {
            Shares = new Dictionary<Share, int>();
            _changeDollarsYuan = 7.11f;
            _changeEurosYuan = 6.97f;
            AmountCash = cash;
        }

        public override bool AddAmericanShares(Share share, int quantity)
        {
            bool result = AddShares(share, quantity, _changeDollarsYuan);
            return result;
        }

        public override bool AddChineseShares(Share share, int quantity)
        {
            bool result = AddShares(share, quantity, _changeEurosYuan);
            return result;
        }

        public override bool AddFrenchShares(Share share, int quantity)
        {
            bool result = AddShares(share, quantity, 1);
            return result;
        }
    }
}
