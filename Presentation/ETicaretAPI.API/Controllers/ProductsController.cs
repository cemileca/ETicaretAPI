

using ETicaretAPI.Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductReadRepository _productReadRepository;
        readonly private IProductWriteRepository _productWriteRepository;
        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }
        [HttpGet]
        public async void Get()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new(){Id=Guid.NewGuid(), CreateDate=DateTime.UtcNow, Name="Product 7",  Price=125, Stock=658},
                new(){Id=Guid.NewGuid(), CreateDate=DateTime.UtcNow, Name="Product 8",  Price=15, Stock=600},
                new(){Id=Guid.NewGuid(), CreateDate=DateTime.UtcNow, Name="Product 9",  Price=185, Stock=450},
            });
            var count = await _productWriteRepository.SaveAsync();
        }
    }
}
