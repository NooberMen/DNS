using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DNS.Models
{
    public class DNSContext : DbContext
    {
        public DNSContext() : base("DbConnection")
        {}

        public DbSet<Product> Products { get; set; }
    }
}