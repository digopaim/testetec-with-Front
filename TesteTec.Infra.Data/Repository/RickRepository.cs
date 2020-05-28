using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteTec.Domain.Entities;
using TesteTec.Domain.Interfaces;
using TesteTec.Infra.Data.Context;

namespace TesteTec.Infra.Data.Repository
{
    public class RickRepository : Repository<Rick>, IRickRepository
    {
        public RickRepository(DataContext context) : base(context)
        {
        }

        public Rick GetByIdFull(int id)
        {
            var result = Db.Ricks.Where(x => x.Id == id).Include(x => x.Morty)
                .Include(x => x.Dimensao).ToList().LastOrDefault();
            return result;
        }
    }
}
