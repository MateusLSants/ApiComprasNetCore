using AppComprasNetCore.Application.DTOs;
using AppComprasNetCore.Domain.Entities;
using AutoMapper;

namespace AppComprasNetCore.Application.Mappings;

public class DomainToDtoMappings : Profile
{
	public DomainToDtoMappings()
	{
		CreateMap<Person, PersonDTO>();
	}
}
