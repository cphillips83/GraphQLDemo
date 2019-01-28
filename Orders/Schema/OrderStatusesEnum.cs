using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orders.Schema
{
    public class OrderStatusesEnum : EnumerationGraphType
    {
        public OrderStatusesEnum()
        {
            //TODO: Check if you can simply do a generic type
            Name = "OrderStatuses";
            AddValue("Created", "Order was created", 2);
            AddValue("Processing", "Order is being processed", 4);
            AddValue("Completed", "Order is completed", 8);
            AddValue("Cancelled", "Order is cancelled", 16);
            AddValue("Closed", "Order was closed", 32);
        }
    }
}
