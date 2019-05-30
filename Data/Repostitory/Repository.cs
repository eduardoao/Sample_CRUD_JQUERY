﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repostitory
{
    public class Repository<T> : IRepository<T> where T : Base
    {
        private Context.DataAccessContext context;

        public Repository()
        {
            context = Activator.CreateInstance<Context.DataAccessContext>();
        }

        public Repository(Context.DataAccessContext context)
        {
            this.context = context;            
        }

        public void Insert(T obj)
        {
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }

        public void Update(T obj)
        {
            context.Entry(obj).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int id)
        {           
            context.Set<T>().Remove(Select(id));
            context.SaveChanges();
        }

        public IList<T> Select()
        {
            return context.Set<T>().ToList();
        }     
 

        public T Select(int id)
        {
            return context.Set<T>().Find(id);
        }
              

        public IList<T> SelectAll()
        {
            return context.Set<T>().ToList();
        }
    }
}
