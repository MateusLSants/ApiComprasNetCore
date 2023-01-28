using AppComprasNetCore.Domain.Validations;

namespace AppComprasNetCore.Domain.Entities;

public sealed class Product
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string CodeErp { get; private set; }
    public decimal Price { get; private set; }
    public ICollection<Purchase> Purchases { get; set; }

    public Product(string name, string codErp, decimal price)
    {
        Validation(name, CodeErp, Price);
    }

    public Product(int id, string name, string codErp, decimal price)
    {
        DomaniValidationException.When(id < 0, "Id do produto deve ser informado");
        Id = id;
        Validation(name, CodeErp, Price);
    }

    private void Validation(string name, string codeErp, decimal price)
    {
        DomaniValidationException.When(string.IsNullOrEmpty(name), "Nome deve ser informado!");
        DomaniValidationException.When(string.IsNullOrEmpty(codeErp), "Codigo deve ser informado!");
        DomaniValidationException.When(price < 0, "Preço deve ser informado!");

        Name = name;
        CodeErp = codeErp;
        Price = price;
    }
}
