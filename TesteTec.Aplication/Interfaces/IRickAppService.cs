using System;
using System.Collections.Generic;
using System.Text;
using TesteTec.Aplication.ViewModels;

namespace TesteTec.Aplication.Interfaces
{
    public interface IRickAppService : IDisposable
    {
        void Register(RickViewModel rickViewModel);
        IEnumerable<RickViewModel> GetAll();
        RickViewModel GetById(int id);
        RickViewModel GetByIdFull(int id);
        void Update(RickViewModel rickViewModel);
        void Remove(int id);
    }
}
