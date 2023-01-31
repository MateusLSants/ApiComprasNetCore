using AppComprasNetCore.Domain.Validations;
namespace AppComprasNetCore.Domain.Entities;

public sealed class Purchase
{
    public int Id { get; private set; }
    public int ProductId { get; private set; }
    public int PersonId { get; private set; }
    public DateTime Date { get; private set; }
    public Person Person { get; set; }
    public Product Product { get; set; }

    public Purchase(int productId, int personId)
    {
        Validation(productId, personId);
    }

    public Purchase(int id, int productId, int personId)
    {
        DomaniValidationException.When(id < 0, "Id da compra deve ser informado");
    }

    private void Validation(int productId, int personId)
    {

        DomaniValidationException.When(productId < 0, "Id do produto deve ser informado!");
        DomaniValidationException.When(personId < 0, "Id do usuario deve ser informado!");

        ProductId = productId;
        PersonId = personId;
        Date = DateTime.Now;
    }
}


