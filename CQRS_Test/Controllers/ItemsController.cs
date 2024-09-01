using CQRS_lib.CQRS.Commands;
using CQRS_lib.CQRS.Queries;
using CQRS_lib.Data.Models;
using CQRS_lib.Repo;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly ItemsRepo _repo;
        private readonly IMediator _mediator;

        public ItemsController(ItemsRepo repo , IMediator mediator)
        {
            _repo = repo;
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult Get() {

            //var items = _repo.GetItems().ToList();
            //  return Ok(items);
            var result = _mediator.Send(new GetAllItemsQuery());
            return Ok(result);
        
        }
        [HttpPost]
        public async Task<IActionResult> Insert(Items item) {

            //_repo.InsertItem(item);
            //return Ok(item);
            var result = await _mediator.Send(new InsertItemCommand(item));
            return Ok(result);
        }
    }
}
