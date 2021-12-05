using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using OrderProject.API.DTOs;
using OrderProject.API.Filters;
using OrderProject.Core.FilterModels;
using OrderProject.Core.Helpers;
using OrderProject.Core.Models;
using OrderProject.Core.OutputModels;
using OrderProject.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderDto = OrderProject.API.DTOs.OrderDto;

namespace OrderProject.API.Controllers
{
    [ApiController]
    [Route("orders")]
    public class OrdersController : Controller
    {
        private readonly IOrderService _service;
        private readonly IUrlHelper _urlHelper;
        private readonly IMapper _mapper;

        public OrdersController(IOrderService service, IUrlHelper urlHelper, IMapper mapper)

        {
            _service = service;
            _urlHelper = urlHelper;
            _mapper = mapper;
        }

        [HttpGet(Name = "GetOrders")]
        public IActionResult Get([FromQuery] OrderFilterModel orderFilterModel)
        {
            var model = _service.GetOrders(orderFilterModel);

            Response.Headers.Add("X-Pagination", model.GetHeader().ToJson());

            var outputModel = new OrderOutputModel
            {
                Paging = model.GetHeader(),
                //Links = GetLinks(model),
                Items = _mapper.Map<List<OrderDto>>(model.List),
                SearchText = orderFilterModel.SearchText,
                SortBy = orderFilterModel.SortBy
            };
            return Ok(outputModel);

        }

        [ValidationFilter]
        [HttpPost(Name = "CreateOrderList")]
        public async Task<IActionResult> SaveAll(List<OrderDto> orderDtoList)
        {
            var newOrderList = await _service.AddRangeAsync(_mapper.Map<List<Order>>(orderDtoList));

            return Created(string.Empty, _mapper.Map<List<OrderDto>>(newOrderList));
        }



        //[HttpPost(Name ="CreateOrder")]
        //public async Task<IActionResult> Save(OrderDto orderDto)
        //{
        //    var newOrder = await _service.AddAsync(_mapper.Map<Order>(orderDto));

        //    return Created(string.Empty, _mapper.Map<OrderDto>(newOrder));
        //}





        #region " Links "
        private List<LinkInfo> GetLinks(PagedList<Order> list)
        {
            var links = new List<LinkInfo>();

            if (list.HasPreviousPage)
                links.Add(CreateLink("GetOrders", list.PreviousPageNumber, list.PageSize, "previousPage", "GET"));

            links.Add(CreateLink("GetOrders", list.PageNumber, list.PageSize, "self", "GET"));

            if (list.HasNextPage)
                links.Add(CreateLink("GetOrders", list.NextPageNumber, list.PageSize, "nextPage", "GET"));

            return links;
        }

        private LinkInfo CreateLink(string routeName, int pageNumber, int pageSize, string rel, string method)
        {
            return new LinkInfo
            {
                Href = _urlHelper.Link(routeName, new { PageNumber = pageNumber, PageSize = pageSize }),
                Rel = rel,
                Method = method
            };
        }

        #endregion

    }
}
