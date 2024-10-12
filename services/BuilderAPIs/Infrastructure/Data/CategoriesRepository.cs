using BuilderAPIs.Domain.Entities;
using BuilderAPIs.Domain.Interfaces;
using BuilderAPIs.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

public class CategoriesRepository : ICategoriesRepository
{
    private readonly AppDbContext _context;
    private readonly IMediator _mediator;

    public CategoriesRepository(AppDbContext context, IMediator mediator)
    {
        _context = context;
        _mediator = mediator;
    }
    public async Task<List<Categories>> GetCategoriesAsync()
    {
        return await _context.Categories.ToListAsync();
    }
}

