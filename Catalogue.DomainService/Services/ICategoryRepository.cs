using Catalogue.DomainModel.Models;
using Catalogue.DomainService.DTO.Category;
using Framework.Domain.Services;


namespace Catalogue.DomainService.Services
{
    public interface ICategoryRepository : IBaseRepositorySeachable<CategoryAddEditModel, int, CategorySearchModel, CategoryComplexList>
    {
        bool HasChild(int CategoryID);
        List<CategoryListItem> GetChild(int CategoryID);
        int GetChildCount(int CategoryID);
        CategoryAddEditModel GetParent(int CategoryID);
        int GetProductCount(int CategoryID);
        List<CategoryFeature> GetFeatures(int CategoryID);
    }
}
