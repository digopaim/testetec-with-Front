using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Text;
using TesteTec.Aplication.Interfaces;
using TesteTec.Aplication.Validators;
using TesteTec.Aplication.ViewModels;
using TesteTec.Domain.Entities;
using TesteTec.Domain.Interfaces;

namespace TesteTec.Aplication.Services
{
    public class DimensaoAppService : IDimensaoAppService
    {
        private readonly IMapper _mapper;
        private readonly IDimensaoRepository _dimensaoRepository;
        public DimensaoAppService(IMapper mapper,
            IDimensaoRepository dimensaoRepository)
        {
            _mapper = mapper;
            _dimensaoRepository = dimensaoRepository;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<DimensaoViewModel> GetAll()
        {
            return _dimensaoRepository.GetAll().ProjectTo<DimensaoViewModel>(_mapper.ConfigurationProvider);
        }

        public DimensaoViewModel GetById(int id)
        {
            return _mapper.Map<DimensaoViewModel>(_dimensaoRepository.GetById(id));
        }

        public void Register(DimensaoViewModel dimensaoViewModel)
        {
            var entity = _mapper.Map<Dimensao>(dimensaoViewModel);
            _dimensaoRepository.Add<DimensaoValidator>(entity);
        }

        public void Remove(int id)
        {
            _dimensaoRepository.Remove(id);
        }

        public void Update(DimensaoViewModel dimensaoViewModel)
        {
            _dimensaoRepository.Update<DimensaoValidator>(_mapper.Map<Dimensao>(dimensaoViewModel));
        }
    }
}
