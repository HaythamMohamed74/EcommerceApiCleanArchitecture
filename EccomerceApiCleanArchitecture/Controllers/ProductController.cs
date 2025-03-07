using EccomerceApiCleanArchitecture.Core.Features._Categories.Command.Model;
using EccomerceApiCleanArchitecture.Core.Features.Products.Commands.Models;
using EccomerceApiCleanArchitecture.Core.Features.Products.Queries.Models;
using EccomerceApiCleanArchitecture.Core.Features.Products.Queries.Results;
using EccomerceApiCleanArchitecture.Data.Entities;
using EccomerceApiCleanArchitecture.Infrastructure.Context;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EccomerceApiCleanArchitecture.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IMediator _mediator;
        private readonly ILogger<ProductController> _logger;

        public ApplicationDbContext _ApplicationDbContext { get; }

        public ProductController(IMediator mediator, ILogger<ProductController> loggerFactory, ApplicationDbContext applicationDbContext)
        {
            _mediator = mediator;
            _logger = loggerFactory;
            _ApplicationDbContext = applicationDbContext;
        }
        [HttpGet]
        public async Task<ActionResult<List<GetAllProductListResponse>>> GetAllProducts()
        {
            var products = await _mediator.Send(new GetAllProductQuery());
            return Ok(products);

        }
        [HttpGet("Id")]
        public async Task<ActionResult<GetAllProductListResponse>> GetProduct(int id)
        {
            var products = await _mediator.Send(new GetProductByIdQuery(id));
            return Ok(products);

        }
        [HttpGet]
        public async Task<ActionResult<GetAllProductListResponse>>GetProductByName(string name)
        {
            var products = await _mediator.Send(new GetProductByNameQuery(name));
            return Ok(products);
        }


        [HttpPost]
        public async Task<ActionResult<Product>> AddNewProduct([FromBody] AddNewProductCommand addNewProductCommand)
        {
            //var command= new AddNewProductCommand(id, name, price, stock,desc);
            var newProduct = await _mediator.Send(addNewProductCommand);
            return Ok(newProduct);
        }
        [HttpPut("id")]
        public async Task<ActionResult> EditProduct(int id,[FromBody] EditProductCommand editProductCommand)
        {
            if (id!=editProductCommand.Id)
            {
                return BadRequest("ID in URL and body must match.");
            }
            var product= await _mediator.Send(editProductCommand);
            return Ok(product);
            
        }

        [HttpPost]
        public async Task<IActionResult> AddNewCategory([FromBody] CreateNewCategoryCommand createNewCategoryCommand)
        {
            var newCategory = await _mediator.Send(createNewCategoryCommand);
            return Ok(newCategory);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllGategories()
        {
            var catgs = await _ApplicationDbContext.Categories.ToListAsync();
            return Ok(catgs);
        }
    }
}
