using AppComprasNetCore.Domain.Validations;

namespace AppComprasNetCore.Domain.Entities.Person;

public sealed class Person
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Document { get; private set; }
    public string Phone { get; private set; }

    public Person(string name, string document, string phone)
    {
        Validation(name, document, phone);
    }

    public Person(int id, string name, string document, string phone) 
    {
        DomaniValidationException.When(id < 0, "Id deve ser maior que zero");
        Id = id;
        Validation(name, document, phone);
    }
    
    private void Validation(string name, string document, string phone)
    {
        DomaniValidationException.When(string.IsNullOrEmpty(name), "Nome deve ser informado!");
        DomaniValidationException.When(string.IsNullOrEmpty(document), "Documento deve ser informado!");
        DomaniValidationException.When(string.IsNullOrEmpty(phone), "Telefone deve ser informado!");

        Name = name;
        Document = document;
        Phone = phone;
    }
}
