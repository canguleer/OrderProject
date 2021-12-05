using Microsoft.EntityFrameworkCore;
using OrderProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProject.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public readonly AppDbContext _context;
        public readonly DbSet<TEntity> _dbSet;

        public Repository(AppDbContext context)
        {
            _context = context; //veritabanına erişir..
            _dbSet = context.Set<TEntity>(); //tablolara erişir
        }


        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }




    }
}
