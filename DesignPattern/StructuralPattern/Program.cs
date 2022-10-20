using System;
using StructuralPattern.Client;

namespace StructuralPattern
{
    class Program
    {
        //TODO factoriser les classes products de Adapter et Bridge
        static void Main(string[] args)
        {
            string pattern = "BridgeClient";
            switch (pattern)
            {
                case "Adapter":
                    var adapterClient = new AdapterClient();
                    adapterClient.CallPatern();
                    break;
                case "BridgeClient":
                default:
                    var bridgeCLient = new BridgeClient();
                    bridgeCLient.CallPatern();
                    break;
            }
        }
    }
}

