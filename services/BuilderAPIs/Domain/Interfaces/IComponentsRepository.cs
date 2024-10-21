using BuilderAPIs.Domain.Entities;

namespace BuilderAPIs.Domain.Interfaces
{
    public interface IComponentsRepository
    {
        Task<List<Components>> GetComponentByIdAsync(int id, int frontid);
    }
}
