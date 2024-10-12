using BuilderAPIs.Domain.Entities;
using BuilderAPIs.Domain.Interfaces;
using BuilderAPIs.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

public class ItemsRepository : IItemsRepository
{
    private readonly AppDbContext _context;
    private readonly IMediator _mediator;

    public ItemsRepository(AppDbContext context, IMediator mediator)
    {
        _context = context;
        _mediator = mediator;
    }

    public async Task<List<Items>> GetItemsAsync()
    {
        return await _context.Items.ToListAsync();
    }

    public async Task<List<Items>> GetItemByIdAsync(string id)
    {
        return await _context.Items.Where(item => item.UserId == id).ToListAsync();
    }

    public async Task<Items> AddItemAsync(Items item)
    {
        _context.Items.Add(item);
        await _context.SaveChangesAsync();
        return item;
    }

    public async Task<Items> UpdateItemAsync(Items item)
    {
        _context.Items.Update(item);
        await _context.SaveChangesAsync();
        return item;
    }

    public async Task<bool> DeleteItemAsync(int id)
    {
        var item = await _context.Items.FindAsync(id);
        if (item == null) return false;

        _context.Items.Remove(item);
        await _context.SaveChangesAsync();
        return true;
    }
}
