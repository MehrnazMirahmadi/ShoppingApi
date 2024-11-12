using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogue.DomainModel.Models
{
    public class ProductMediaType
    {
        public int ProductMediaTypeID { get; set; }
        public int ProductMediaTypeName { get; set; }
        public List<ProductMedia> ProductMedia { get; set; }
        public ProductMediaType()
        {
            ProductMedia = new List<ProductMedia>();
        }
    }
}
