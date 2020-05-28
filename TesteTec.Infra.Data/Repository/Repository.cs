using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteTec.Domain.Interfaces;
using TesteTec.Infra.Data.Context;

namespace TesteTec.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DataContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(DataContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }




        public virtual void Add<V>(TEntity obj) where V : AbstractValidator<TEntity>
        {
            Validate(obj, Activator.CreateInstance<V>());

            DbSet.Add(obj);
            SaveChanges();
        }

        public virtual TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public virtual void Update<V>(TEntity obj) where V : AbstractValidator<TEntity>
        {
            Validate(obj, Activator.CreateInstance<V>());

            DbSet.Update(obj);
            SaveChanges();
        }



        public virtual void Remove(int id)
        {
            DbSet.Remove(DbSet.Find(id));
            SaveChanges();
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }
        public void Validate(TEntity obj, AbstractValidator<TEntity> validator)
        {
            if (obj == null)
                throw new Exception("Registros não detectados!");

            validator.ValidateAndThrow(obj);
        }
        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
