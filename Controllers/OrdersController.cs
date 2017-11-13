using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AuthExample.Controllers
{
    [RoutePrefix("api/Orders")]
    public class OrdersController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(Order.CreateOrders());
        }
    }

    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public string ShipperCity { get; set; }
        public Boolean IsShipped { get; set; }

        public static List<Order> CreateOrders()
        {
            List<Order> OrderList = new List<Order>
            {
                new Order {OrderID = 10248, CustomerName = "Maria de Fátima", ShipperCity = "Recife", IsShipped = true },
                new Order {OrderID = 10249, CustomerName = "João Campói", ShipperCity = "Florianópolis", IsShipped = false},
                new Order {OrderID = 10250,CustomerName = "José Roberto", ShipperCity = "Campina Grande", IsShipped = false },
                new Order {OrderID = 10251,CustomerName = "Maria Macedo", ShipperCity = "Rondonópolis", IsShipped = false},
                new Order {OrderID = 10252,CustomerName = "Marcos Akiba", ShipperCity = "São Pedro", IsShipped = true}
            };

            return OrderList;
        }
    }
}
