using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TesteTec.Aplication.ViewModels;
using TesteTec.Domain.Entities;

namespace TesteTec.Aplication.AutoMapper
{
   public  class ViewModelToDomainMappingProfile : Profile
    
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<MortyViewModel , Morty>();
            CreateMap<RickViewModel , Rick>();
            CreateMap<DimensaoViewModel, Dimensao>();
        }
    }
}
