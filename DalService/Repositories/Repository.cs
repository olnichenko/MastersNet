using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Dal.Models;
using DalService.Abstract;

namespace DalService.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DataModel _db;
        private bool _disposed;
        private readonly Type _currentType;
        private DbSet<T> _dataList;

        public Repository()
        {
            _db = new DataModel();
            _currentType = typeof(DbSet<T>);
            var pp = typeof(DataModel).GetProperties();
            var property = pp.Single(x => x.PropertyType == _currentType);
            _dataList = property.GetValue(_db) as DbSet<T>;
            //_dataList.Load();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
            }
            _disposed = true;
        }

        ~Repository()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual IEnumerable<T> GetPage()
        {
            return _dataList;
        }

        public virtual T Create(T item)
        {
            _dataList.Add(item);
            _db.SaveChanges();
            return item;
        }

        public virtual T Update(T item)
        {
            _db.Entry(item).State = EntityState.Modified;
            _db.SaveChanges();
            return item;
        }

        public virtual bool Delete(long id)
        {
            var ent = _dataList.Find(id);
            if (ent != null)
            {
                _dataList.Remove(ent);
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        public virtual T Get(long id)
        {
            return _dataList.Find(id);
        }
    }
}
