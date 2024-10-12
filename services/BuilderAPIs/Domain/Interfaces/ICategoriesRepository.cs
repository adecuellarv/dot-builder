using BuilderAPIs.Domain.Entities;

namespace BuilderAPIs.Domain.Interfaces
{
    public interface ICategoriesRepository
    {
        Task<List<Categories>> GetCategoriesAsync();
    }
}
