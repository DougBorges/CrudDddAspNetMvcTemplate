using Domain.Models;
using Infrastructure.Context;

namespace Infrastructure.Repositories;

public class ContactRepository(AppDbContext context) : Repository<Contact>(context)
{
    public override Contact? GetById(int id)
    {
        return _context.Contacts.Find(id);
    }

    public override IEnumerable<Contact> GetAll()
    {
        return _context.Contacts.ToList();
    }

    public override void Add(Contact entity)
    {
        _context.Contacts.Add(entity);
        _context.SaveChanges();
    }

    public override void Update(Contact entity)
    {
        _context.Contacts.Update(entity);
        _context.SaveChanges();
    }

    public override void Delete(Contact entity)
    {
        _context.Contacts.Remove(entity);
        _context.SaveChanges();
    }
}