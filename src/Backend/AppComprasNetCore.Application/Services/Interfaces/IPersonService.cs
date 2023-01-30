using AppComprasNetCore.Application.DTOs;

namespace AppComprasNetCore.Application.Services.Interfaces;

public interface IPersonService
{
    Task<ResultService<PersonDTO>> CreateAsync(PersonDTO personDTO);
}
