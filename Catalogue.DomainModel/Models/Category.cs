namespace Catalogue.DomainModel.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Slug { get; set; }
        public string? LineAge { get; set; }
        public int SortOrder { get; set; }
        public int? ParentID { get; set; }
        public Category Parent { get; set; }
        public List<Category> Children { get; set; }
        public List<Product> Products { get; set; }
        public List<CategoryFeature> CategoryFeatures { get; set; }
        public Category()
        {
            Children = new List<Category>();
            Products = new List<Product>();
            CategoryFeatures = new List<CategoryFeature>();
        }
    }
}
