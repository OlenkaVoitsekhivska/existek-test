using API.Data;
using API.Services;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {

        private ProductService _prodService;
        public ProductsController(ProductService productService)
        {
            _prodService = productService;
        }

        [HttpGet]
        public async Task<ObjectResult> GetProducts(int page, string? searchQuery)
        {
            ProductResponse response = new ProductResponse();
            if (string.IsNullOrEmpty(searchQuery))
            {
                response = await _prodService.productsAll(page);
                return Ok(response);
            }
            response = await _prodService.productsAllQueryStr(page, searchQuery);
            return Ok(response);

        }

        [HttpGet("{category}")]
        public async Task<ObjectResult> GetProductsByCategory(int page, string category, string? searchQuery)
        {
            ProductResponse response = new ProductResponse();
            if (string.IsNullOrEmpty(searchQuery))
            {
                response = await _prodService.productsByCategory(page, category);
                return Ok(response);
            }
            response = await _prodService.productsByCategoryQueryStr(page, category, searchQuery);
            return Ok(response);
        }
    }
}