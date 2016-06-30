﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.ChangeTracking;
using Sbabu.Web.Models;

namespace Sbabu.Web.Repository.Infrastructure
{
    public class RepositoryBase<T> where T : class, IEntity
    {
        private DatabaseContext dataContext;
        private readonly DbSet<T> dbset;
        protected RepositoryBase(IDatabaseFactory databaseFactory)
        {
            DatabaseFactory = databaseFactory;
            dbset = DataContext.Set<T>();
        }



        protected IDatabaseFactory DatabaseFactory
        {
            get;
            private set;
        }

        protected DatabaseContext DataContext
        {
            get { return dataContext ?? (dataContext = DatabaseFactory.Get()); }
        }

        public virtual T Add(T entity)
        {
             var entity1 = dbset.Add(entity);
            //  dataContext.SaveChanges();
            return entity;
        }

        public virtual T Update(T entity)
        {
            dbset.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
            //      dataContext.SaveChanges();
            return entity;
        }

        public virtual void Delete(T entity)
        {
            dbset.Remove(entity);
            //  dataContext.SaveChanges();
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbset.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbset.Remove(obj);
            // dataContext.SaveChanges();
        }



        public virtual IEnumerable<T> GetAll()
        {
            return dbset.ToList();
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where).ToList();
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where).FirstOrDefault<T>();
        }

        public virtual T GetById(long id)
        {
            return dbset.SingleOrDefault(x => x.Id == id);
        }


    }
}