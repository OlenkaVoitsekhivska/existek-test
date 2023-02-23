using API.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class ProductService
    {
        public Context _context;
        public float pageResults = 3f;
        public ProductService(Context context)
        {
            _context = context;
        }
        public async Task<ProductResponse> productsAll(int page)
        {
            var totalProducts = _context.Products!.Count();
            var pageCount = Math.Ceiling(totalProducts / pageResults);
            var products = await _context.Products!
                .Skip((page - 1) * (int)pageResults)
                .Take((int)pageResults)
                .ToListAsync();
            var response = new ProductResponse
            {
                Products = products,
                CurrentPage = page,
                Pages = (int)pageCount,
                Total = totalProducts
            };
            return response;
        }

        public async Task<ProductResponse> productsAllQueryStr(int page, string searchQuery)
        {
            var totalProducts = _context.Products!.Where(product => product.Title.Contains(searchQuery)).Count();
            var pageCount = Math.Ceiling(totalProducts / pageResults);
            var products = await _context.Products!

                .Skip((page - 1) * (int)pageResults)
                 .Where(product => product.Title.Contains(searchQuery))
                .Take((int)pageResults)
                .ToListAsync();
            var response = new ProductResponse
            {
                Products = products,
                CurrentPage = page,
                Pages = (int)pageCount,
                Total = totalProducts
            };
            return response;
        }
        public async Task<ProductResponse> productsByCategory(int page, string category)
        {
            var totalProducts =  _context.Products!.Where(product => product.Category == category).Count();
            var pageCount = Math.Ceiling(totalProducts / pageResults);
            var products = await _context.Products!
                .Where(product => product.Category == category)
                .Skip((page - 1) * (int)pageResults)
                .Take((int)pageResults)
                .ToListAsync();
            var response = new ProductResponse
            {
                Products = products,
                CurrentPage = page,
                Pages = (int)pageCount,
                Total = totalProducts
            };
            return response;
        }

        public async Task<ProductResponse> productsByCategoryQueryStr(int page, string category, string searchQuery)
        {
            var totalProducts = _context.Products!.Where(product => product.Category == category && product.Title.Contains(searchQuery)).Count();
            var pageCount = Math.Ceiling(totalProducts / pageResults);
            var products = await _context.Products!
                .Where(product => product.Category == category && product.Title.Contains(searchQuery))
                .Skip((page - 1) * (int)pageResults)
                .Take((int)pageResults)
                .ToListAsync();
            var response = new ProductResponse
            {
                Products = products,
                CurrentPage = page,
                Pages = (int)pageCount,
                Total = totalProducts
            };
            return response;
        }
    }

}
