using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using payment.Dto;
using payment.Database;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;

namespace payment.Controllers
{
    [ApiController]
    [Route("api/v1/payment")]
    public class PaymentController : ControllerBase
    {
        private readonly PaymentContext _paymentContext;
        private readonly ILogger<PaymentController> _logger;

        public PaymentController(PaymentContext paymentContext, ILogger<PaymentController> logger)
        {
            _logger = logger;
            _paymentContext = paymentContext;
        }

        [HttpGet]
    [SwaggerResponse(StatusCodes.Status200OK, type: typeof(PaymentDto[]))]
    public async Task<IActionResult> Get()
    {
        var entities = await _paymentContext.Payment
            .AsNoTracking()
            .ToListAsync();

        var payment = entities.Select(entity => Convert(entity)).ToArray();
        return Ok(payment);
    }
    [HttpGet("{paymentId:int}")]
    [SwaggerResponse(StatusCodes.Status200OK, type: typeof(PaymentDto))]
    public async Task<IActionResult> Get(int paymentId)
    {
        var payment = await _paymentContext.Payment
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == paymentId);
        if (payment == null)
            return NotFound();
        return Ok(Convert(payment));
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] PaymentDto payment)
    {
        var entity = Convert(payment);
        await _paymentContext.Payment.AddAsync(entity);
        await _paymentContext.SaveChangesAsync();
        return Created($"api/v1/payment/{entity.Id}", null);
    }




    [HttpDelete("{payment_uid}")]
    public async Task<IActionResult> Delete(Guid payment_uid)
    {
        var payment = _paymentContext.Payment.FirstOrDefault(payment => payment.payment_uid == payment_uid);
        if (payment == null)
            return NotFound("Аренда не найдена");
        _paymentContext.Payment.Remove(payment);
        await _paymentContext.SaveChangesAsync();
        return NoContent();

    }
    private static PaymentDto Convert(PaymentEntity entity)
    {
        return new PaymentDto()
        {
            Id = entity.Id,
            payment_uid = entity.payment_uid,
            price = entity.price,
            status = entity.status,
        };
    }

    private static PaymentEntity Convert(PaymentDto entity)
    {
        return new PaymentEntity()
        {
            Id = entity.Id,
            payment_uid = entity.payment_uid,
            price = entity.price,
            status = entity.status,
        };
    }
}
}
}
