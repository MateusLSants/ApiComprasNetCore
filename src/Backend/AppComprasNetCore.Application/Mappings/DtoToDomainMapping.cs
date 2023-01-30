using AppComprasNetCore.Application.DTOs;
using AppComprasNetCore.Domain.Entities;
using AutoMapper;

namespace AppComprasNetCore.Application.Mappings;

public class DtoToDomainMapping : Profile
{
	public DtoToDomainMapping()
	{
		CreateMap<PersonDTO, Person>();
	}
}
