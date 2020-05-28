using System;
using System.Collections.Generic;
using System.Text;
using TesteTec.Domain.Entities;

namespace TesteTec.Domain.Interfaces
{
    public interface IRickRepository : IRepository<Rick>
    {
        Rick GetByIdFull(int id);
    }
}
