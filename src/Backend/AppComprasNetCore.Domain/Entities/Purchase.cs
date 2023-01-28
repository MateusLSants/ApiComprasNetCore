using AppComprasNetCore.Domain.Validations;
<<<<<<< HEAD
using System.Xml.Linq;

namespace AppComprasNetCore.Domain.Entities;

=======

namespace AppComprasNetCore.Domain.Entities;


>>>>>>> a7056d0922da22df2e19f9f1c03d0f03e13eaf1d
public sealed class Purchase
{
    public int Id { get; private set; }
    public int ProductId { get; private set; }
    public int PersonId { get; private set; }
    public DateTime Date { get; private set; }
<<<<<<< HEAD
    public Person Person { get; private set; }
    public Product Product { get; private set; }

    public Purchase(int productId, int personId, DateTime date)
=======
    public Person Person { get; set; }

    public Purchase(int productId, int personId, DateTime? date)
>>>>>>> a7056d0922da22df2e19f9f1c03d0f03e13eaf1d
    {
        Validation(productId, personId, date);
    }

<<<<<<< HEAD
    public Purchase(int id, int productId, int personId, DateTime date, Person person, Product product)
    {
        DomaniValidationException.When(id < 0, "Id da compra deve ser informado");
=======
    public Purchase(int id, int productId, int personId, DateTime date, Person person)
    {
        DomaniValidationException.When(id < 0, "O Id da compra deve ser informada");
>>>>>>> a7056d0922da22df2e19f9f1c03d0f03e13eaf1d
        Id = id;
        Validation(productId, personId, date);
    }

    private void Validation(int productId, int personId, DateTime? date)
    {
<<<<<<< HEAD
        DomaniValidationException.When(productId < 0, "Id do produto deve ser informado!");
        DomaniValidationException.When(personId < 0, "Id do usuario deve ser informado!");
        DomaniValidationException.When(!date.HasValue, "Data da compra deve ser informado!");
=======
        DomaniValidationException.When(productId < 0, "O Id do produto deve ser informado");
        DomaniValidationException.When(personId < 0, "O Id do usuario deve ser informado");
        DomaniValidationException.When(!date.HasValue, "A data da compra deve ser informada");
>>>>>>> a7056d0922da22df2e19f9f1c03d0f03e13eaf1d

        ProductId = productId;
        PersonId = personId;
        Date = date.Value;
<<<<<<< HEAD

=======
>>>>>>> a7056d0922da22df2e19f9f1c03d0f03e13eaf1d
    }
}


