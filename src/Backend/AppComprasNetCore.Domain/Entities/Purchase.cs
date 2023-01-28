using AppComprasNetCore.Domain.Validations;

namespace AppComprasNetCore.Domain.Entities;


public sealed class Purchase
{
    public int Id { get; private set; }
    public int ProductId { get; private set; }
    public int PersonId { get; private set; }
    public DateTime Date { get; private set; }
    public Person Person { get; set; }

    public Purchase(int productId, int personId, DateTime? date)
    {
        Validation(productId, personId, date);
    }

    public Purchase(int id, int productId, int personId, DateTime date, Person person)
    {
        DomaniValidationException.When(id < 0, "O Id da compra deve ser informada");
        Id = id;
        Validation(productId, personId, date);
    }

    private void Validation(int productId, int personId, DateTime? date)
    {
        DomaniValidationException.When(productId < 0, "O Id do produto deve ser informado");
        DomaniValidationException.When(personId < 0, "O Id do usuario deve ser informado");
        DomaniValidationException.When(!date.HasValue, "A data da compra deve ser informada");

        ProductId = productId;
        PersonId = personId;
        Date = date.Value;
    }
}


