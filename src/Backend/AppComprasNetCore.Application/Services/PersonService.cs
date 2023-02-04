using AppComprasNetCore.Application.DTOs;
using AppComprasNetCore.Application.DTOs.Validations;
using AppComprasNetCore.Application.Services.Interfaces;
using AppComprasNetCore.Domain.Entities;
using AppComprasNetCore.Domain.Repositories;
using AutoMapper;

namespace AppComprasNetCore.Application.Services;

public class PersonService : IPersonService
{
 
    private readonly IPersonRepository _personRepository;
    private readonly IMapper _mapper;
    public PersonService(IPersonRepository personRepository, IMapper mapper)
    {
        _personRepository = personRepository;
        _mapper = mapper;
    }

    public async Task<ResultService<PersonDTO>> CreateAsync(PersonDTO personDTO)
    {
        if (personDTO == null)
            return ResultService.Fail<PersonDTO>("Objeto deve ser informado");
        var result = new PersonDTOValidation().Validate(personDTO);
        if (!result.IsValid)
            return ResultService.RequestErro<PersonDTO>("Problema de validade", result);

        var person = _mapper.Map<Person>(personDTO);
        var data = await _personRepository.CreateAsync(person);
        return ResultService.Ok(_mapper.Map<PersonDTO>(data));
    }
}
