using AppComprasNetCore.Domain.Validations;

namespace AppComprasNetCore.Domain.Entities;

public sealed class Person
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Document { get; private set; }
    public string Phone { get; private set; }
<<<<<<< HEAD
    public ICollection<Purchase> purchases { get; private set; }
=======
    public ICollection<Purchase> Purchases { get; set; }

>>>>>>> a7056d0922da22df2e19f9f1c03d0f03e13eaf1d

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
