﻿using DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Base
{
    public class Repository<T> where T : class
    {
        CustomerDbContext db = new CustomerDbContext();
        private DbSet<T> Table
        {
            get { return db.Set<T>(); }
        }

        public virtual T GetById<Y>(Y id)
        {
            //return db.Set<T>().Find(id);
            return Table.Find(id);
        }
        public virtual List<T> GetAll()
        {
            //return db.Set<T>().ToList();
            return Table.ToList();
        }

        public virtual bool Add(T entity)
        {
            //db.Entry(entity).State = EntityState.Added;
            //db.Set<T>().Add(entity);
            Table.Add(entity);
            return db.SaveChanges() > 0;
        }

        public virtual bool Update(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public virtual bool Delete(T entity)
        {
            db.Entry(entity).State = EntityState.Deleted;
            return db.SaveChanges() > 0;
        }
    }
}