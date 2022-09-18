using System;
using CreationalPattern.Client;

namespace CreationalPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "Singleton";
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
                case "Prototype":
                    var prototypeClient = new PrototypeClient();
                    prototypeClient.CallPatern();
                    break;
                case "Singleton":
                    var singletonClient = new SingletonClient();
                    singletonClient.CallPatern();
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
