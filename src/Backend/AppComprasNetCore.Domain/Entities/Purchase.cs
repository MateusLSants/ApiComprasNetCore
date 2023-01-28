using AppComprasNetCore.Domain.Validations;
using System.Xml.Linq;

namespace AppComprasNetCore.Domain.Entities;

public sealed class Purchase
{
    public int Id { get; private set; }
    public int ProductId { get; private set; }
    public int PersonId { get; private set; }
    public DateTime Date { get; private set; }
    public Person Person { get; private set; }
    public Product Product { get; private set; }

    public Purchase(int productId, int personId, DateTime date)
    {
        Validation(productId, personId, date);
    }

    public Purchase(int id, int productId, int personId, DateTime date, Person person, Product product)
    {
        DomaniValidationException.When(id < 0, "Id da compra deve ser informado");
        Id = id;
        Validation(productId, personId, date);
    }

    private void Validation(int productId, int personId, DateTime? date)
    {
        DomaniValidationException.When(productId < 0, "Id do produto deve ser informado!");
        DomaniValidationException.When(personId < 0, "Id do usuario deve ser informado!");
        DomaniValidationException.When(!date.HasValue, "Data da compra deve ser informado!");

        ProductId = productId;
        PersonId = personId;
        Date = date.Value;

    }
}


