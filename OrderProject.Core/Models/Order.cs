﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OrderProject.Core.Enums.Enums;

namespace OrderProject.Core.Models
{
    public class Order
    {

        public int Id { get; set; }
        public int BrandId { get; set; }
        public decimal Price { get; set; }
        public string StoreName { get; set; }
        public string CustomerName { get; set; }
        public DateTime CreatedOn { get; set; }
        public OrderStatus Status { get; set; }

    }
}
