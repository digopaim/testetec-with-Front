using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteTec.Aplication.Interfaces;
using TesteTec.Aplication.Validators;
using TesteTec.Aplication.ViewModels;
using TesteTec.Domain.Entities;
using TesteTec.Domain.Interfaces;

namespace TesteTec.Aplication.Services
{
    public class RickAppService : IRickAppService
    {
        private readonly IMapper _mapper;
        private readonly IRickRepository _rickRepository;
        public RickAppService(IMapper mapper,
            IRickRepository rickRepository)
        {
            _mapper = mapper;
            _rickRepository = rickRepository;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<RickViewModel> GetAll()
        {
            return _rickRepository.GetAll().ProjectTo<RickViewModel>(_mapper.ConfigurationProvider);
        }

        public RickViewModel GetById(int id)
        {
            
            return _mapper.Map<RickViewModel>(_rickRepository.GetById(id));
        }

        public RickViewModel GetByIdFull(int id)
        {
            return _mapper.Map<RickViewModel>(_rickRepository.GetByIdFull(id));
        }

        public void Register(RickViewModel rickViewModel)
        {
            var entity = _mapper.Map<Rick>(rickViewModel);
            _rickRepository.Add<RickValidator>(entity);
        }

        public void Remove(int id)
        {
            _rickRepository.Remove(id);
        }

        public void Update(RickViewModel rickViewModel)
        {
            _rickRepository.Update<RickValidator>(_mapper.Map<Rick>(rickViewModel));
        }
    }
}
