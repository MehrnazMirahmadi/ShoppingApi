using Catalogue.DomainModel.Models;
using Catalogue.DomainService.DTO.Category;
using Catalogue.DomainService.Services;
using Microsoft.Data.SqlClient;

namespace Catalogue.Infrastructure.EF.Persistance.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        #region DB
        private CatalogueContext db;
        public CategoryRepository(CatalogueContext db)
        {
                this.db = db;
        }
        #endregion

        private Category ToDBModel(CategoryAddEditModel model)
        {
            return new Category
            {
             CategoryName = model.CategoryName,
                Slug = model.Slug,
                LineAge = model.LineAge,
                SortOrder = model.SortOrder,
                ParentID = model.ParentID

            };

        }
        public Task<int> Add(CategoryAddEditModel model)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryAddEditModel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryAddEditModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<CategoryListItem> GetChild(int CategoryID)
        {
            throw new NotImplementedException();
        }

        public int GetChildCount(int CategoryID)
        {
            throw new NotImplementedException();
        }

        public List<CategoryFeature> GetFeatures(int CategoryID)
        {
            throw new NotImplementedException();
        }

        public CategoryAddEditModel GetParent(int CategoryID)
        {
            throw new NotImplementedException();
        }

        public int GetProductCount(int CategoryID)
        {
            throw new NotImplementedException();
        }

        public bool HasChild(int CategoryID)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryComplexList> Search(CategorySearchModel sm)
        {
            throw new NotImplementedException();
        }

        public Task Update(CategoryAddEditModel model)
        {
            throw new NotImplementedException();
        }
    }
}
