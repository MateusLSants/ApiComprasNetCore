namespace AppComprasNetCore.Domain.Entities.Person;

public sealed class Person
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Document { get; private set; }
    public string Phone { get; private set; }

    public Person(string nome, string document, string phone)
    {
    }
    
    private void Validation(string nome, string document, string phone)
    {
        DomainValidation
    }
}
