using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogue.DomainModel.Models
{

    public class ProductFeature
    {
        public int ProductID { get; set; }
        public int FeatureID { get; set; }
        public string FeatureValue { get; set; }
        public int EffectOnPrice { get; set; }
        public bool IsDefault { get; set; }
        public Product Product { get; set; }
        public Feature Feature { get; set; }
    }
}
