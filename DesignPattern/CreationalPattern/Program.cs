using System;
using CreationalPattern.AbstractFactory.Factory;
using CreationalPattern.Client;
using CreationalPattern.Product;

namespace CreationalPattern
{
    class Program
    {
        //TODO in the future do an switch case with all clients
        static void Main(string[] args)
        {
            //var abstractFactoryClient = new AbstractFactoryClient();
            //abstractFactoryClient.CallPatern();

            var builderClient = new BuilderClient();
            builderClient.CallPatern();

        }
    }
}
