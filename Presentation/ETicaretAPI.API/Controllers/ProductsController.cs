using ETicaretAPI.Application.Repositories;
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
        public async Task Get()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new(){ Id=Guid.NewGuid(), CreateDate=DateTime.UtcNow, Name="Product 1", Price=101, Stock=65},
                new(){ Id=Guid.NewGuid(), CreateDate=DateTime.UtcNow, Name="Product 2",Price=305, Stock=72},
                new(){ Id=Guid.NewGuid(), CreateDate=DateTime.UtcNow, Name="Product 1",Price=101, Stock=230}
            });
            var count = await _productWriteRepository.SaveChangesAsync();
        }

    }
}
