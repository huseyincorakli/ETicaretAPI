using ETicaretAPI.Domain;
using ETicaretAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Contexts
{
    public class ETicaretAPIDBContext : DbContext
    {
        public ETicaretAPIDBContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products{ get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers{ get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            //SAVECHANGES INTERCEPTOR
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var item in datas)
            {
                _ = item.State switch
                {
                    EntityState.Added => item.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified=>item.Entity.UpdatedDate=DateTime.UtcNow,
                };
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
