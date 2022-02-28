using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersApi.Models
{
    public class OrdersDBContext : DbContext
    {
        public OrdersDBContext(DbContextOptions<OrdersDBContext> options)
          : base(options)
        {
        }

        public DbSet<Order> TodoItems { get; set; } = null!;
    }
}
