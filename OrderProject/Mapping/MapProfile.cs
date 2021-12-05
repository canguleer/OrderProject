using AutoMapper;
using OrderProject.API.DTOs;
using OrderProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProject.API.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Order, OrderDto>();
            CreateMap<OrderDto, Order>();
        }

    }
}
