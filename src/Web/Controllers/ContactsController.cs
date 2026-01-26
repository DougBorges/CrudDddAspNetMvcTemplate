using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Web.Converters;
using Web.Models;

namespace Web.Controllers;

public class ContactsController(ILogger<ContactsController> logger, IContactService contactService) : Controller
{
    private readonly ILogger<ContactsController> _logger = logger;
    private readonly IContactService _contactService = contactService;

    [HttpGet]
    public IActionResult Index()
    {
        var contacts = _contactService.GetAll();
        return View(contacts.ConvertToViewModel());
    }

    [HttpGet]
    public IActionResult Contact(int? idContact)
    {
        if (!idContact.HasValue)
            return View();

        var contact = _contactService.GetById(idContact.Value);

        return View(contact.ConvertToViewModel());
    }

    [HttpPost]
    public IActionResult Save(ContactViewModel contactViewModel)
    {
        _contactService.Save(contactViewModel.Id, contactViewModel.Name, contactViewModel.Email);

        return RedirectToAction("Index");
    }

    [HttpDelete]
    public IActionResult Delete(int idContact)
    {
        _contactService.Delete(idContact);

        return RedirectToAction("Index");
    }
}