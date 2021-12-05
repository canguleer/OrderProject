using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProject.Core.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        Task AddAsync(TEntity entity);
    }
}
