using OrderProject.Core.Models;
using OrderProject.Core.Repositories;
using OrderProject.Core.Services;
using OrderProject.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProject.Service.Services
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {

        public IUnitOfWork unitOfWork;
        private IRepository<TEntity> repository;



        public Service(IUnitOfWork unitOfWork, IRepository<TEntity> repository)
        {
            this.unitOfWork = unitOfWork;
            this.repository = repository;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await repository.AddAsync(entity);
            await unitOfWork.CommitAsync();

            return entity;
        }

        public async Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await repository.AddRangeAsync(entities);
            await unitOfWork.CommitAsync();

            return entities;
        }

      
    }
}
