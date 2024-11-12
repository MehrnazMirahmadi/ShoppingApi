using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogue.DomainModel.Models
{
    public class Feature
    {
        public int FeatureID { get; set; }
        public string FeatureName { get; set; }
        public List<CategoryFeature> CategoryFeatures { get; set; }
        public List<ProductFeature> ProductFeatures { get; set; }
        public Feature()
        {
            CategoryFeatures = new List<CategoryFeature>();
            ProductFeatures = new List<ProductFeature>();
        }
    }
}
