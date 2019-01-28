using System;
using System.Collections.Generic;
using System.Text;

namespace Orders.Models
{

    [Flags]
    public enum OrderStatuses
    {
        Created = 2,
        Processing = 4,
        Completed = 8,
        Cancelled = 16,
        Closed = 32
    }

    public class Order
    {
        public Order(string name, string description, DateTime created, int customerId, string Id)
        {
            Name = name;
            Description = description;
            Created = created;
            CustomerId = customerId;
            this.Id = Id;

            Status = OrderStatuses.Created;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; }
        public int CustomerId { get; set; }
        public string Id { get; }

        public OrderStatuses Status { get; private set; } 

        public void Start()
        {
            Status = OrderStatuses.Processing;
        }
        
    }
}
