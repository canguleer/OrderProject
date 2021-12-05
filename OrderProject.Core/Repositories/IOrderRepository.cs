using OrderProject.Core.FilterModels;
using OrderProject.Core.Helpers;
using OrderProject.Core.Models;
using OrderProject.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProject.Core.Repositories
{
    public interface IOrderRepository:IRepository<Order>
    {
        PagedList<Order> GetOrders(OrderFilterModel movieFilterModel);
    }
}
