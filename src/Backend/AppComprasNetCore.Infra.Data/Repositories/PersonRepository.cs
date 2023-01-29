using AppComprasNetCore.Domain.Entities;
using AppComprasNetCore.Domain.Repositories;
using AppComprasNetCore.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace AppComprasNetCore.Infra.Data.Repositories;

public class PersonRepository : IPersonRepository
{

    private readonly AppDBContext _db;

    public PersonRepository(AppDBContext db)
    {
        _db = db;
    }

    public async Task<Person> CreateAsync(Person person)
    {
        _db.Add(person);
        await _db.SaveChangesAsync();
        return person;
    }

    public async Task DeleteAsync(Person person)
    {
        _db.Remove(person);
        await _db.SaveChangesAsync();
    }

    public async Task EditAsync(Person person)
    {
        _db.Update(person);
        await _db.SaveChangesAsync();
    }

    public async Task<Person> GetByIdAsync(int id)
    {
        return await _db.People.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<ICollection<Person>> GetPeopleAsync()
    {
        return await _db.People.ToListAsync();
    }
}
