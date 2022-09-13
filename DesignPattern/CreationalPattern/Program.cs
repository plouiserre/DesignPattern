using System;
using CreationalPattern.Client;

namespace CreationalPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "Method Factory";
            switch (pattern)
            {
                case "Abstract Factory":
                    var abstractFactoryClient = new AbstractFactoryClient();
                    abstractFactoryClient.CallPatern();
                    break;
                case "Builder":
                    var builderClient = new BuilderClient();
                    builderClient.CallPatern();
                    break;
                case "Method Factory":
                default:
                    var methodFactoryClient = new FactoryMethodClient();
                    methodFactoryClient.CallPatern();
                    break;
            }
        }
    }
}
