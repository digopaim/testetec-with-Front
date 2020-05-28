using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TesteTec.Aplication.ViewModels;
using TesteTec.Domain.Entities;

namespace TesteTec.Aplication.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Morty, MortyViewModel>();
            CreateMap<Rick, RickViewModel>();
            CreateMap<Dimensao, DimensaoViewModel>();
        }
    }
}
