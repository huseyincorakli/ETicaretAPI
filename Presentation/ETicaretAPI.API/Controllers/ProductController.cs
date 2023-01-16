using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;

        public ProductController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }
        [HttpGet]
        public async void Get()
        {
          await  _productWriteRepository.AddRangeAsync(new(){
                new() {  Id=Guid.NewGuid() ,Name="Product 1", CreatedDate=DateTime.UtcNow,Price=100,Stock=100 },
                new() {  Id=Guid.NewGuid() ,Name="Product 2", CreatedDate=DateTime.UtcNow,Price=200,Stock=200 },
                new() {  Id=Guid.NewGuid() ,Name="Product 3", CreatedDate=DateTime.UtcNow,Price=300,Stock=300 },
                new() {  Id=Guid.NewGuid() ,Name="Product 4", CreatedDate=DateTime.UtcNow,Price=400,Stock=400 },
            });
          await  _productWriteRepository.SaveAsync();
        }
       
    }
}
