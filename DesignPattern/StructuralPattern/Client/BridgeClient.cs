using StructuralPattern.Bridge;
using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralPattern.Client
{
    public class BridgeClient : IClient
    {
        private ChineseTrader _chineseTrader { get; set; }
        private EuropeanTrader _europeanTrader { get; set; }
        private AmericanTrader _americanTrader { get; set; }

        public void CallPatern()
        {
            InitTraders();
            ShanghaiMarket();
            NYMarket();
            ParisMarket();
        }

        private void InitTraders()
        {
            _americanTrader = new AmericanTrader(213456);
            _europeanTrader = new EuropeanTrader(9820);
            _chineseTrader = new ChineseTrader(54659);

            Console.WriteLine("American Trader is here with {0} $", _americanTrader.AmountCash);
            Console.WriteLine("European Trader is here with {0} €", _europeanTrader.AmountCash);
            Console.WriteLine("American Trader is here with {0} Yuans", _chineseTrader.AmountCash);
        }

        //TODO finir de débeuguer la prochaine fois
        //TODO factoriser une partie du code
        //TODO améliorer la fusion entre market et trader
        private void ShanghaiMarket()
        {
            //chinese
            var shanghaiMarketChineseTrader = new ShanghaiMarket(_chineseTrader,"Shanghaï Market");
            Share firstShare = shanghaiMarketChineseTrader.Shares["ICBC"];
            shanghaiMarketChineseTrader.TraderBuyShares(firstShare, 14);
            Console.WriteLine("After this purchase, chinese trader has {0} shares of the company {1} and {2} yuans", _chineseTrader.Shares[firstShare], firstShare.CompanyName, _chineseTrader.AmountCash);
            shanghaiMarketChineseTrader.TraderBuyShares(firstShare, 6);
            Console.WriteLine("After this purchase, chinese trader has {0} shares of the company {1} and {2} yuans", _chineseTrader.Shares[firstShare], firstShare.CompanyName, _chineseTrader.AmountCash);

            //american
            var shanghaiMarketAmericanTrader = new ShanghaiMarket(_americanTrader, "Shanghaï Market");
            Share secondShare = shanghaiMarketAmericanTrader.Shares["Bank Of China"];
            shanghaiMarketAmericanTrader.TraderBuyShares(secondShare, 60);
            Console.WriteLine("After this purchase, american trader has {0} shares of the company {1} and {2} dollars", _americanTrader.Shares[secondShare], secondShare.CompanyName, _americanTrader.AmountCash);
            Share thirdShare = shanghaiMarketAmericanTrader.Shares["Ping An"];
            shanghaiMarketAmericanTrader.TraderBuyShares(thirdShare, 22);
            Console.WriteLine("After this purchase, american trader has {0} shares of the company {1} and {2} dollars", _americanTrader.Shares[thirdShare], thirdShare.CompanyName, _americanTrader.AmountCash);

            //french
            var shanghaiMarketEuropeanTrader = new ShanghaiMarket(_europeanTrader, "Shanghaï Market");
            Share fourthShare = shanghaiMarketEuropeanTrader.Shares["Petro China"];
            shanghaiMarketEuropeanTrader.TraderBuyShares(fourthShare, 12);
            Console.WriteLine("After this purchase, european trader has {0} shares of the company {1} and {2} euros", _europeanTrader.Shares[fourthShare], fourthShare.CompanyName, _americanTrader.AmountCash);
            Share fifthShare = shanghaiMarketEuropeanTrader.Shares["Kweichow moutai"];
            shanghaiMarketEuropeanTrader.TraderBuyShares(fifthShare, 80);
            Console.WriteLine("After this purchase, european trader has {0} shares of the company {1} and {2} euros", _europeanTrader.Shares[fifthShare], fifthShare.CompanyName, _americanTrader.AmountCash);
        }

        private void NYMarket()
        {
            //chinese
            var wallStreetChineseTrader = new NewYorkMarket(_chineseTrader, "Wall Street");
            Share firstShare = wallStreetChineseTrader.Shares["Microsoft"];
            wallStreetChineseTrader.TraderBuyShares(firstShare, 6);
            Console.WriteLine("After this purchase, chinese trader has {0} shares of the company {1} and {2} yuans", _chineseTrader.Shares[firstShare], firstShare.CompanyName, _chineseTrader.AmountCash);
            Share secondShare = wallStreetChineseTrader.Shares["Meta Platforms Inc."];
            wallStreetChineseTrader.TraderBuyShares(secondShare, 22);
            Console.WriteLine("After this purchase, chinese trader has {0} shares of the company {1} and {2} yuans", _chineseTrader.Shares[secondShare], secondShare.CompanyName, _chineseTrader.AmountCash);

            //american
            var wallStreetAmericanTrader = new NewYorkMarket(_americanTrader, "Wall Street");
            Share thirdShare = wallStreetAmericanTrader.Shares["Apple"];
            wallStreetAmericanTrader.TraderBuyShares(thirdShare, 11);
            Console.WriteLine("After this purchase, american trader has {0} shares of the company {1} and {2} dollars", _americanTrader.Shares[secondShare], secondShare.CompanyName, _americanTrader.AmountCash);
            Share fourthShare = wallStreetAmericanTrader.Shares["Alphabet Inc Class A"];
            wallStreetAmericanTrader.TraderBuyShares(fourthShare, 19); 
            Console.WriteLine("After this purchase, american trader has {0} shares of the company {1} and {2} dollars", _americanTrader.Shares[thirdShare], thirdShare.CompanyName, _americanTrader.AmountCash);

            //french
            var wallStreetEuropeanTrader = new NewYorkMarket(_europeanTrader, "Wall Street");
            Share fifthShare = wallStreetEuropeanTrader.Shares["Amazon.com"];
            wallStreetEuropeanTrader.TraderBuyShares(fourthShare, 16);
            Console.WriteLine("After this purchase, european trader has {0} shares of the company {1} and {2} euros", _europeanTrader.Shares[fourthShare], fourthShare.CompanyName, _americanTrader.AmountCash);
            wallStreetEuropeanTrader.TraderBuyShares(fifthShare, 24);
            Console.WriteLine("After this purchase, european trader has {0} shares of the company {1} and {2} euros", _europeanTrader.Shares[fifthShare], fifthShare.CompanyName, _europeanTrader.AmountCash);
        }

        private void ParisMarket()
        {
            //chinese
            var frenchMarketChineseTrader = new ParisMarket(_chineseTrader, "CAC 40");
            Share firstShare = frenchMarketChineseTrader.Shares["Bouygues"];
            frenchMarketChineseTrader.TraderBuyShares(firstShare, 12);
            Console.WriteLine("After this purchase, chinese trader has {0} shares of the company {1} and {2} yuans", _chineseTrader.Shares[firstShare], firstShare.CompanyName, _chineseTrader.AmountCash);
            frenchMarketChineseTrader.TraderBuyShares(firstShare, 3);
            Console.WriteLine("After this purchase, chinese trader has {0} shares of the company {1} and {2} yuans", _chineseTrader.Shares[firstShare], firstShare.CompanyName, _chineseTrader.AmountCash);

            //american
            var frenchMarketAmericanTrader = new ParisMarket(_americanTrader, "CAC 40");
            Share secondShare = frenchMarketAmericanTrader.Shares["BNP Paribas"];
            frenchMarketAmericanTrader.TraderBuyShares(secondShare, 84);
            Console.WriteLine("After this purchase, american trader has {0} shares of the company {1} and {2} dollars", _americanTrader.Shares[secondShare], secondShare.CompanyName, _americanTrader.AmountCash);
            Share thirdShare = frenchMarketAmericanTrader.Shares["Publicis"];
            frenchMarketAmericanTrader.TraderBuyShares(thirdShare, 12);
            Console.WriteLine("After this purchase, american trader has {0} shares of the company {1} and {2} dollars", _americanTrader.Shares[thirdShare], thirdShare.CompanyName, _americanTrader.AmountCash);


            //french
            var frenchMarketEuropeanTrader = new ParisMarket(_europeanTrader, "CAC 40");
            Share fourthShare = frenchMarketEuropeanTrader.Shares["Airbus Group"];
            frenchMarketEuropeanTrader.TraderBuyShares(fourthShare, 29);
            Console.WriteLine("After this purchase, european trader has {0} shares of the company {1} and {2} euros", _europeanTrader.Shares[fourthShare], fourthShare.CompanyName, _americanTrader.AmountCash);
            Share fifthShare = frenchMarketEuropeanTrader.Shares["Thales"];
            frenchMarketEuropeanTrader.TraderBuyShares(fifthShare, 33);
            Console.WriteLine("After this purchase, european trader has {0} shares of the company {1} and {2} euros", _europeanTrader.Shares[fifthShare], fifthShare.CompanyName, _europeanTrader.AmountCash);
        }
    }
}
