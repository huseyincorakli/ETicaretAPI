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
        readonly private ICustomerReadRepository _customerReadRepository;
        readonly private ICustomerWriteRepository _customerWriteRepository;
        readonly private IOrderReadRepository _orderReadRepository;
        readonly private IOrderWriteRepository _orderWriteRepository;

        public ProductController(
            IProductWriteRepository productWriteRepository,
            IProductReadRepository productReadRepository,
            ICustomerReadRepository customerReadRepository,
            ICustomerWriteRepository customerWriteRepository,
            IOrderReadRepository orderReadRepository,
            IOrderWriteRepository orderWriteRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _customerReadRepository = customerReadRepository;
            _customerWriteRepository = customerWriteRepository;
            _orderReadRepository = orderReadRepository;
            _orderWriteRepository = orderWriteRepository;
        }
        [HttpGet]
        public async Task Get()
        {
            //await _productWriteRepository.AddRangeAsync(new(){
            //    new() {  Id=Guid.NewGuid() ,Name="Product 1", CreatedDate=DateTime.UtcNow,Price=100,Stock=100 },
            //    new() {  Id=Guid.NewGuid() ,Name="Product 2", CreatedDate=DateTime.UtcNow,Price=200,Stock=200 },
            //    new() {  Id=Guid.NewGuid() ,Name="Product 3", CreatedDate=DateTime.UtcNow,Price=300,Stock=300 },
            //    new() {  Id=Guid.NewGuid() ,Name="Product 4", CreatedDate=DateTime.UtcNow,Price=400,Stock=400 },
            //});
            //await _productWriteRepository.SaveAsync();
            //Product p = await _productReadRepository.GetByIdAsync("a31dfab0-9d2f-470b-8bcc-92190eb2f880");
            //p.Name = "Product 5";
            //await _productWriteRepository.SaveAsync();


            ////*******new customer*********
            //var id= Guid.NewGuid();
            //await _customerWriteRepository.AddAsync(new() { Id=id ,Name="Hüseyin Çoraklı",});

            ////******* new orders*************
            //await _orderWriteRepository.AddAsync(new() { Address = "Kahramanmaraş-Dulkadiroğlu",CustomerId=id, Description="deneme1" });
            //await _orderWriteRepository.AddAsync(new() { Address = "Kahramanmaraş-Onikişubat",CustomerId=id, Description="deneme2" });

            //await _orderWriteRepository.SaveAsync();

            Order order= await _orderReadRepository.GetByIdAsync("d6d48626-e24d-4933-b757-38d0458a577f");
            order.Address = "Kahramanmaraş-Doğukent";
            await _orderWriteRepository.SaveAsync();

        }



        //[HttpGet("{id}")]
        //public async Task<IActionResult> Get(string id)
        //{
        //   Product product = await _productReadRepository.GetByIdAsync(id);
        //    return Ok(product);
        //}
    }
}
