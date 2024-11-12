using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogue.DomainModel.Models
{

    public class ProductMedia
    {
        public int ProductMediaID { get; set; }
        public int ProdctID { get; set; }
        public int ProductMediaTypeID { get; set; }
        public string Url { get; set; }
        public long FileSize { get; set; }
        public string UploadingUserName { get; set; }
        public bool IsConfirmed { get; set; }
        public string ConfirmByUserName { get; set; }
        public Product Product { get; set; }
        public ProductMediaType ProductMediaType { get; set; }
    }
}
