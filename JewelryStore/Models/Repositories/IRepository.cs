using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JewelryStore.Models.Repositories
{
    internal interface IRepository<T> where T : class
    {
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        HashSet<T> GetAll();
        T FindById(int id);
        HashSet<T> FindByKeywork(string keywork);
    }
}