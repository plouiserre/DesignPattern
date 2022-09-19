using System;
using StructuralPattern.Client;

namespace StructuralPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "Adapter";
            switch (pattern)
            {
                case "Adapter":
                default:
                    var adapterClient = new AdapterClient();
                    adapterClient.CallPatern();
                    break;
            }
        }
    }
}

