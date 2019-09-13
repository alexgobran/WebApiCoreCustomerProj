using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCoreCustomerProj.Models {
    public class CustDbContext : DbContext {

        public virtual DbSet<Customer> Customers { get; set; }
        
            public CustDbContext (DbContextOptions<CustDbContext> context) : base(context)  {

            }

            
        

    }
}
