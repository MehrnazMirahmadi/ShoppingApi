namespace Catalogue.DomainService.DTO.Category
{
    public class CategoryAddEditModel
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Slug { get; set; }
        public string LineAge { get; set; }
        public int SortOrder { get; set; }
        public int? ParentID { get; set; }
    }
}
