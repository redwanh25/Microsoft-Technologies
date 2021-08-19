using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_BusinessLogicLayer.Contracts
{
    public interface IManager<T> where T : class
    {
        T GetById<Y>(Y id);
        List<T> GetAll();
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
