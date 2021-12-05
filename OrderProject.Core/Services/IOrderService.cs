using OrderProject.Core.FilterModels;
using OrderProject.Core.Helpers;
using OrderProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProject.Core.Services
{
    public interface IOrderService:IService<Order>
    {
        PagedList<Order> GetOrders(OrderFilterModel movieFilterModel);
    }
}
