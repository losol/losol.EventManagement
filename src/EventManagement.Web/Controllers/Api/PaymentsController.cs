using System.Threading.Tasks;
using EventManagement.Services.Payments;
using losol.EventManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Stripe;

namespace EventManagement.Web.Controllers.Api
{
    [Route("api/payments")]
    public class PaymentsController : Controller
    {
        private readonly IOrderService _orderService;
        public PaymentsController(IOrderService service)
        {
            _orderService = service;
        }

        [HttpPost("stripe")]
        public async Task<IActionResult> StripeCharge([FromBody]StripeChargeRequestVM request,
            [FromServices]StripePaymentProvider provider)
        {
            await provider.ChargeCustomer(
                order: await _orderService.GetByIdAsync(request.OrderId),
                token: request.Token);
            // TODO: Mark the order as paid
            return Ok();
        }
    }

    public class StripeChargeRequestVM
    {
        public int OrderId { get; set; }
        public StripeToken Token { get; set; }
    }
}