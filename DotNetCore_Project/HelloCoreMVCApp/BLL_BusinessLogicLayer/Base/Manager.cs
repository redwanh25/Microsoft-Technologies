using DAL_DataAccessLayer.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_BusinessLogicLayer.Base
{
    public abstract class Manager<T> where T : class
    {
        public Repository<T> _repository;

        public Manager(Repository<T> repository)
        {
            _repository = repository;
        }

        public virtual T GetById<Y>(Y id)
        {
            return _repository.GetById(id);
        }
        public virtual List<T> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual bool Add(T entity)
        {
            return _repository.Add(entity);
        }

        public virtual bool Update(T entity)
        {
            return _repository.Update(entity);
        }

        public virtual bool Delete(T entity)
        {
            return _repository.Delete(entity);
        }
    }
}
