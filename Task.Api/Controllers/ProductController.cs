using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task.Models;
using Task.Repository.Abstraction;
using Task.Services.Abstraction;

namespace Task.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _productService.GetAll();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_productService.GetById(id));
        }
        [HttpPost]
        public IActionResult Insert(Product product)
        {
            if(ModelState.IsValid)
            {
                var result = _productService.Add(product);
                if(result) return Ok(
                    new
                    {
                        status = "200",
                        message = "Insert successfull.",
                        data = product,
                    }
                    
                    );
            }
            return BadRequest("Invalid Request.");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = _productService.Remove(id);
            if (result) return Ok(1);
            return BadRequest("Invalid Request.");
        }
    }
}
