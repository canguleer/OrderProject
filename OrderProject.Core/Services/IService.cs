using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProject.Core.Services
{
    public interface IService<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities);
        Task<TEntity> AddAsync(TEntity entity);
    }
}
