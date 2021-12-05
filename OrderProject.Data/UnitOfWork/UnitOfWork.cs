using OrderProject.Core.Repositories;
using OrderProject.Core.UnitOfWork;
using OrderProject.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProject.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private OrderRepository _orderRepository;


        public IOrderRepository Orders => _orderRepository = _orderRepository ?? new OrderRepository(_context);


        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
       

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
