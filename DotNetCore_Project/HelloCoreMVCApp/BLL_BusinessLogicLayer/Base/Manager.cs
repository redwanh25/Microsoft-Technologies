using BLL_BusinessLogicLayer.Contracts;
using DAL_DataAccessLayer.Base;
using DAL_DataAccessLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_BusinessLogicLayer.Base
{
    public abstract class Manager<T>: IManager<T> where T : class
    {
        private IRepository<T> _repository;

        public Manager(IRepository<T> repository)
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
