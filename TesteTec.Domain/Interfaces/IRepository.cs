using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesteTec.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add<V>(TEntity obj) where V : AbstractValidator<TEntity>;
        TEntity GetById(int id);
        IQueryable<TEntity> GetAll();
        void Update<V>(TEntity obj) where V : AbstractValidator<TEntity>;
        void Remove(int id);
        int SaveChanges();
        void Validate(TEntity obj, AbstractValidator<TEntity> validator);
    }
}
