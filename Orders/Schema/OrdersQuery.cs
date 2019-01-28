using GraphQL.Types;
using Orders.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orders.Schema
{
    public class OrdersQuery  : ObjectGraphType<object>
    {
        public OrdersQuery(IOrderService orders)
        {
            Name = "Query";
            Field<ListGraphType<OrderType>>("orders",
                resolve: context => orders.GetOrdersAsync());
        }
    }
}
