using OrderProject.API.DTOs;
using OrderProject.Core.Helpers;
using OrderProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OrderProject.Core.Enums.Enums;

namespace OrderProject.Core.OutputModels
{
    public class OrderOutputModel
    {
        public PagingHeader Paging { get; set; }
        //public List<LinkInfo> Links { get; set; }
        public List<OrderDto> Items { get; set; }
        public string SortBy { get; set; }
        public string SearchText { get; set; }

    }


}
