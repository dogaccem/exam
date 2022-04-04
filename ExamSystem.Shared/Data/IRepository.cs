using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Shared.Data
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        void Add(TEntity entity);
        void Remove(string Id);
        void Update(TEntity entity); 
        TEntity Find(string Id); 
        IQueryable<TEntity> GetQuery();
    }
}
