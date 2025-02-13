using EccomerceApiCleanArchitecture.Core.Features.Products.Queries.Models;
using EccomerceApiCleanArchitecture.Core.Features.Products.Queries.Results;
using EccomerceApiCleanArchitecture.Data.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EccomerceApiCleanArchitecture.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
       IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            return await _mediator.Send(new GetAllProductQuery());
        }
    }
}
