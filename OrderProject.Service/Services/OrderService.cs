using OrderProject.Core.FilterModels;
using OrderProject.Core.Helpers;
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
    public class OrderService : Service<Order>, IOrderService
    {

        public OrderService(IUnitOfWork unitOfWork, IRepository<Order> repository) : base(unitOfWork, repository)
        {

        }


        public PagedList<Order> GetOrders(OrderFilterModel movieFilterModel)
        {
            var data = unitOfWork.Orders.GetOrders(movieFilterModel);

            return data;

        }
    }
}
