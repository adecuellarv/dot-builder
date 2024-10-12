using BuilderAPIs.Domain.Entities;

namespace BuilderAPIs.Domain.Interfaces
{
    public interface IItemsRepository
    {
        Task<List<Items>> GetItemsAsync();
        Task<List<Items>> GetItemByIdAsync(String id);
        Task<Items> AddItemAsync(Items item);
        Task<Items> UpdateItemAsync(Items item);
        Task<bool> DeleteItemAsync(int id);
    }
}
