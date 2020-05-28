using System;
using System.Collections.Generic;
using System.Text;
using TesteTec.Aplication.ViewModels;

namespace TesteTec.Aplication.Interfaces
{
    public interface IMortyAppService : IDisposable
    {
        void Register(MortyViewModel mortyViewModel);
        IEnumerable<MortyViewModel> GetAll();
        MortyViewModel GetById(int id);
        void Update(MortyViewModel mortyViewModel);
        void Remove(int id);
    }
}
