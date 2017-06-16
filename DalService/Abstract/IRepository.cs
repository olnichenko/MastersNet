using System;
using System.Collections;
using System.Collections.Generic;

namespace DalService.Abstract
{
    public interface IRepository<T> : IDisposable where T: class
    {
        //IEnumerable<T> GetAll();
        IEnumerable<T> GetPage();
        T Create(T item);
        T Update(T item);
        bool Delete(long id);
        T Get(long id);
    }
}