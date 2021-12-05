using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OrderProject.Core.Enums.Enums;

namespace OrderProject.Core.FilterModels
{
   public class OrderFilterModel
    {
        public int PageSize { get; set; } = 10;
        public int PageNumber { get; set; } = 1;
        public string SearchText { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public List<OrderStatus> Statuses { get; set; }
        public string SortBy { get; set; }
    }
}
