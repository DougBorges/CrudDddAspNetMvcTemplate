namespace Domain.Models;

public class Contact : BaseEntity
{
    protected Contact() { }

    public Contact(string name, string email)
    {
        Update(name, email);
    }

    public string Name { get; private set; }
    public string Email { get; private set; }

    public void Update(string name, string email)
    {
        Validate(name, email);
        Name = name;
        Email = email;
    }

    private static void Validate(string name, string email)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentException("Name can't be empty");

        if (string.IsNullOrEmpty(email))
            throw new ArgumentException("Email can't be empty");
    }
}