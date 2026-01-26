using Domain.Interfaces;

namespace Domain.Models;

public class ContactService(IRepository<Contact> contactRepository) : IContactService
{
    private readonly IRepository<Contact> _contactRepository = contactRepository;

    public Contact GetById(int id)
    {
        var contact = _contactRepository.GetById(id);

        if (contact == null)
            throw new Exception($"Contact id={id} not found");

        return contact;
    }

    public IEnumerable<Contact> GetAll()
    {
        return _contactRepository.GetAll();
    }

    public void Save(int? id, string name, string email)
    {
        if (!id.HasValue)
        {
            _contactRepository.Add(new Contact(name, email));
            return;
        }

        var contact = _contactRepository.GetById(id.Value);

        if (contact == null)
            throw new Exception($"Contact id={id} not found");

        contact.Update(name, email);

        _contactRepository.Update(contact);
    }

    public void Delete(int id)
    {
        var contact = _contactRepository.GetById(id);

        if (contact == null)
            throw new Exception($"Contact id={id} not found");

        _contactRepository.Delete(contact);
    }
}