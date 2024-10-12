using BuilderAPIs.Domain.Entities;
using BuilderAPIs.Domain.Interfaces;
using BuilderAPIs.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

public class ComponentsRepository : IComponentsRepository {
    private readonly AppDbContext _context;
    private readonly IMediator _mediator;

    public ComponentsRepository(AppDbContext context, IMediator mediator)
    {
        _context = context;
        _mediator = mediator;
    }

    public async Task<List<Components>> GetComponentByIdAsync(int id)
    {
        return await _context.Components.Where(item => item.CategoryID == id).ToListAsync();
    }

}

