﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogue.DomainModel.Models
{
    public class CategoryFeature
    {
        public int CategoryID { get; set; }
        public int FeatureID { get; set; }
        public Category Category { get; set; }
        public Feature Feature { get; set; }
    }
}
