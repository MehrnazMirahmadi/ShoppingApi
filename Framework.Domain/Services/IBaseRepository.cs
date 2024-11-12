namespace Framework.Domain.Services
{
    public interface IBaseRepository<TModel, TKey>
    {
        Task<TKey> Add(TModel model);
        Task Delete(TKey ID);
        Task Update(TModel model);
        Task<TModel> Get(TKey id);
        Task<List<TModel>> GetAll();

    }
}
