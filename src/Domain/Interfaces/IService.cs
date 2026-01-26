using Domain.Models;

namespace Domain.Interfaces;

public interface IContactService
{
    Contact GetById(int id);
    IEnumerable<Contact> GetAll();
    void Save(int? id, string nome, string email);
    void Delete(int id);
}