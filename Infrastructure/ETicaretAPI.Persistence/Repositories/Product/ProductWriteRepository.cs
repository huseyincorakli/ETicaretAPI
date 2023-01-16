using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Repositories
{ 
    public class ProductWriteRepository:WriteRepository<Product> , IProductWriteRepository
    {
        public ProductWriteRepository(ETicaretAPIDBContext context):base(context)
        {
                
        }
    }
}
