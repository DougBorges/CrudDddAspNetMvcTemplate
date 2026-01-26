using System;
using Domain.Models;
using Web.Models;

namespace Web.Converters;

public static class ContactConverter
{
    public static ContactViewModel ConvertToViewModel(this Contact contact)
    {
        return new ContactViewModel { Id = contact.Id, Name = contact.Name, Email = contact.Email };
    }

    public static IEnumerable<ContactViewModel> ConvertToViewModel(this IEnumerable<Contact> contacts)
    {
        return contacts.Select(ConvertToViewModel);
    }
}