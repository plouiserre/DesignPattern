using System;
namespace StructuralPattern.Product
{
    public class Share
    {
        public string CompanyName { get; set; }

        public float Price { get; set; }

        public int Stock { get; set; }

        public Share(string companyName, float price, int stock)
        {
            CompanyName = companyName;
            Price = price;
            Stock = stock;
        }
    }
}

