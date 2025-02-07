using Kreta.Shared.Responses;

namespace Kreta.HttpService.Services
{
    public interface IBaseHttpService<TEntity>
    {
        public Task<List<TEntity>> GetAllAsync();
        public Task<Response> UpdateAsync(TEntity entity);
        public Task<Response> DeleteAsync(Guid id);
        public Task<Response> InsertAsync(TEntity entity);
    }
}
