using System;
using System.Collections.Generic;
using StructuralPattern.Adapter;
using StructuralPattern.Product;

namespace StructuralPattern.Client
{
    public class AdapterClient : IClient
    {
        public AdapterClient()
        {
        }

        public void CallPatern()
        {
            Console.WriteLine("Start Adapter Pattern");
            var american = new AmericanTrader("Chris Gardner", 230650);

            var european = new EuropeanTrader("Pierre Andurand");
            european.EurosAmount = 54861;

            Console.WriteLine("{0} American trader buy some actions and had {1} $", american.Identity, american.DollarsAmount);
            var shareMS = new Share("Microsoft", 242.14f, 12);
            var shareExxon = new Share("Exxon", 93.10f, 45);
            List<Share> americanPurcharse = new List<Share>();
            americanPurcharse.Add(shareMS);
            americanPurcharse.Add(shareExxon);
            american.BuyShares(americanPurcharse);
            Console.WriteLine("{0} has now {1} dollars", american.Identity, american.DollarsAmount);

            float dollarsAmount = european.EurosAmount * 1.00009f;
            Console.WriteLine("{0} European trader with adapter buy some actions with {1} € and {2}$", european.Identity, european.EurosAmount, dollarsAmount);
            var europeanAdapter = new EuropeanTraderAdapter(0.99905f,european, dollarsAmount);
            var shareGoldman = new Share("Goldman Sachs Group Inc", 327.06f, 66);
            List<Share> europeanPurchase = new List<Share>();
            europeanPurchase.Add(shareGoldman);
            europeanAdapter.BuyShares(europeanPurchase);

            Console.WriteLine("{0} has now {1} $", europeanAdapter.Identity, europeanAdapter.DollarsAmount);

            Console.WriteLine("End Adapter Pattern");
        }
    }
}

