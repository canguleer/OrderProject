using OrderProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProject.Core.UnitOfWork
{
    public interface IUnitOfWork
    {

        IOrderRepository Orders { get; }
        Task CommitAsync();
        void Commit();
    }
}
