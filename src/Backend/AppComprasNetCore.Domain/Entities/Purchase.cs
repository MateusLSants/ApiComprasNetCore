namespace AppComprasNetCore.Domain.Entities;


public sealed class Purchase
{
    public int Id { get; private set; }
    public int ProductId { get; private set; }
    public int PersonId { get; private set; }
    public DateTime Date { get; private set; }
    public Person Person { get; set; }

    public Purchase()
    {

    }
}


