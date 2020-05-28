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
    public class MortyAppService : IMortyAppService
    {
        private readonly IMapper _mapper;
        private readonly IMortyRepository _mortyRepository;
        public MortyAppService(IMapper mapper,
            IMortyRepository mortyRepository)
        {
            _mapper = mapper;
            _mortyRepository = mortyRepository;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<MortyViewModel> GetAll()
        {
            return _mortyRepository.GetAll().ProjectTo<MortyViewModel>(_mapper.ConfigurationProvider);
        }

        public MortyViewModel GetById(int id)
        {
            return _mapper.Map<MortyViewModel>(_mortyRepository.GetById(id));
        }

        public void Register(MortyViewModel mortyViewModel)
        {
            var entity = _mapper.Map<Morty>(mortyViewModel);
            _mortyRepository.Add<MortyValidator>(entity);
        }

        public void Remove(int id)
        {
            _mortyRepository.Remove(id);
        }

        public void Update(MortyViewModel mortyViewModel)
        {
            _mortyRepository.Update<MortyValidator>(_mapper.Map<Morty>(mortyViewModel));
        }
    }
}
