using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogue.DomainModel.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string SmallDescription { get; set; }
        public string Slug { get; set; }

        public string Alt { get; set; }
        public int BasePrice { get; set; }
        public int Discount { get; set; }
        public int AvailableProductCount { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public List<ProductMedia> ProductMedia { get; set; }

        public List<ProductFeature> ProductFeatures { get; set; }
        public Product()
        {
            ProductFeatures = new List<ProductFeature>();
            ProductMedia = new List<ProductMedia>();
        }
    }
}
