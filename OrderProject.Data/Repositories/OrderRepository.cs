
using Microsoft.EntityFrameworkCore;
using OrderProject.Core.FilterModels;
using OrderProject.Core.Helpers;
using OrderProject.Core.Models;
using OrderProject.Core.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static OrderProject.Core.Enums.Enums;

namespace OrderProject.Data.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {


        private AppDbContext appDbContext { get => _context as AppDbContext; }

        public OrderRepository(AppDbContext context) : base(context)
        {

        }

        public PagedList<Order> GetOrders(OrderFilterModel movieFilterModel)
        {

            var query = this._dbSet.AsQueryable();

            if (movieFilterModel.Statuses != null)
            {
                query = query.Where(x => movieFilterModel.Statuses.Contains(x.Status));
            }

            if (movieFilterModel.StartDate != null)
            {
                query = query.Where(x => x.CreatedOn >= movieFilterModel.StartDate);


            }
            if (movieFilterModel.EndDate != null)
            {
                query = query.Where(x => x.CreatedOn <= movieFilterModel.EndDate);

            }

            if (!string.IsNullOrEmpty(movieFilterModel.SearchText))
            {
                string filterBy = movieFilterModel.SearchText.Trim().ToLower();

                query = query.Where(x => x.StoreName.ToLower().Contains(filterBy) || x.CustomerName.ToLower().Contains(filterBy));
            }

            if (!string.IsNullOrEmpty(movieFilterModel.SortBy))
            {
                query = query.Sort(movieFilterModel.SortBy);
            }
            return new PagedList<Order>(query, movieFilterModel.PageNumber, movieFilterModel.PageSize);
        }
    }
}
