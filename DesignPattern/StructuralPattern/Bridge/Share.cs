using System;
namespace StructuralPattern.Bridge
{
    //TODO factoriser avec celle du dossier product
    public class Share
    {
        public string CompanyName { get; set; }

        public float Price { get; set; }

        public Share(string companyName, float price, int stock)
        {
            CompanyName = companyName;
            Price = price;
        }
    }
}
}

