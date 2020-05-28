using System;
using System.Collections.Generic;
using System.Text;
using TesteTec.Domain.Entities;
using TesteTec.Domain.Interfaces;
using TesteTec.Infra.Data.Context;

namespace TesteTec.Infra.Data.Repository
{
    public class DimensaoRepository : Repository<Dimensao>, IDimensaoRepository
    {
        public DimensaoRepository(DataContext context) : base(context)
        {
        }
    }
}
