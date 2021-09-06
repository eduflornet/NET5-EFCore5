﻿using System;
using System.Collections.Generic;
using NET5.WebApi.DAL.Interfaces;

namespace Fluent.API.DAL.Entities
{
    public class Order : IUserId
    {
        public Order()
        {
            DateOrderedUtc = DateTime.UtcNow;
        }
        public int OrderId { get; set; }

        public DateTime DateOrderedUtc { get; set; }

        // relationships

        public ICollection<LineItem> LineItems { get; set; }

        // Extra columns not used by EF

        public string OrderNumber => $"SO{OrderId:D6}";

        public Guid UserId { get; set; }
    }
}
