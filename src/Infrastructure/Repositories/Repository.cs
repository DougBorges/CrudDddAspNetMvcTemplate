using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Context;

namespace Infrastructure.Repositories;

public abstract class Repository<TEntity>(AppDbContext context) : IRepository<TEntity> where TEntity : BaseEntity
{
    protected readonly AppDbContext _context = context;

    public abstract TEntity? GetById(int id);
    public abstract IEnumerable<TEntity> GetAll();
    public abstract void Add(TEntity entity);
    public abstract void Update(TEntity entity);
    public abstract void Delete(TEntity entity);
}