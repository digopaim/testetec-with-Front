using System;
using System.Collections.Generic;
using System.Text;
using TesteTec.Aplication.ViewModels;

namespace TesteTec.Aplication.Interfaces
{
    public interface IDimensaoAppService : IDisposable
    {
        void Register(DimensaoViewModel dimensaoViewModel);
        IEnumerable<DimensaoViewModel> GetAll();
        DimensaoViewModel GetById(int id);
        void Update(DimensaoViewModel dimensaoViewModel);
        void Remove(int id);
    }
}
