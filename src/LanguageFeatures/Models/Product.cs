using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }

        public static Product[] GetProducts()
        {
            //Product kayak = new Product() {  };

            return new Product[] {
                new Product() { Name = "Kayak", Price = 275M },
                new Product() { Name = "LifeJacket", Price = 48.55M },
                null
            };
        }

    }
}
