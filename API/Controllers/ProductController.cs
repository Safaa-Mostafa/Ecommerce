using API.DTO;
using API.ResponseModels;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductController(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromForm] AddProductDTO AddProductDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var product = _mapper.Map<Product>(AddProductDTO);
            await _productRepository.Add(product);
            return Ok(new { success = true, data = product });
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var products = await _productRepository.GetAllAsync();
            throw new Exception("fjjf");
            return Ok(ApiResponse<IEnumerable<Product>>.SuccessResponse(products, "data fetched success", 200));

        }


    }
}
