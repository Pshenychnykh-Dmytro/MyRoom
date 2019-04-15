using MyRoom.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MyRoom.Domain.Core.Repositories
{
    public interface IBaseRepository<T> where T: BaseModel 
    {
        void Add(T model);
        void Update(T model);
        void FirstOrDefaut(Expression<Func<bool, T>> expression);        
        void Delete(Expression<Func<T, bool>> expression);
        IQueryable<T> Where(Expression<Func<T, bool>> condition);
        IEnumerable<T> GetAll();
    }
}
