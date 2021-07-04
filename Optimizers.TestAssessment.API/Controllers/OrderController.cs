using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Optimizers.TestAssessment.DomainModels.DTO;
using Optimizers.TestAssessment.DomainModels.Models;
using Optimizers.TestAssessment.DomainServices.Interfaces;

namespace Optimizers.TestAssessment.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        /// <summary>
        /// Create new instance of <see cref="orderService"/>.
        /// </summary>
        /// <param name="orderService">Injected orderService.</param>
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        /// <summary>
        /// Save the new order record.
        /// </summary>
        /// <param name="orderModel">Order to be saved.</param>
        /// <returns><see cref="UserModel"/> record.</returns>
        [HttpPost]
        public async Task<ActionResult<OrderModel>> CreateOrder([FromBody] OrderModel orderModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            
            var result = await _orderService.Create(new OrderDTO(orderModel));

            if (result == null)
            {
                return BadRequest();
            }
            
            return Ok(result);
        }
    }
}