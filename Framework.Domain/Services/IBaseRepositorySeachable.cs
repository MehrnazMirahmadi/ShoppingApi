namespace Framework.Domain.Services
{
    public interface IBaseRepositorySeachable<TModel, TKey, TSearchModel, TComplexModel> : IBaseRepository<TModel, TKey>
    {
        Task<TComplexModel> Search(TSearchModel sm);
    }
}
