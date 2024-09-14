using System;
using System.Linq.Expressions;
using Cascalho.Domain.Entities;
using Cascalho.Infra.Context;
using Cascalho.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Cascalho.Infra.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : Base
{
    private CascalhoContext _context;

    public BaseRepository(CascalhoContext context)
    {
        _context = context;
    }

    public async Task<T> Create(T entity)
    {
        _context.Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<T?> Get(Expression<Func<T, bool>> expression)
    {
        return await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(expression);
    }

    public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> expression)
    {
        return await _context.Set<T>().AsNoTracking().Where(expression).ToListAsync();
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await _context.Set<T>().AsNoTracking().ToListAsync();
    }

    public async Task<T> Remove(T entity)
    {
        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<T> Update(T entity)
    {
        _context.Set<T>().Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
}
