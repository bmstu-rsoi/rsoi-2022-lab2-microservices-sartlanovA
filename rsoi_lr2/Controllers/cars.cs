using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;
using rsoi_lr2.Dto;
using rsoi_lr2.Database;
using Microsoft.EntityFrameworkCore;

namespace rsoi_lr2.Controllers
{
    [ApiController]
    [Route("api/v1/cars")]
    public class CarsController : ControllerBase
    {
        private readonly CarsContext _carsContext;
        private readonly ILogger<CarsController> _logger;

        public CarsController(CarsContext carsContext, ILogger<CarsController> logger)
        {
            _logger = logger;
            _carsContext = carsContext;
        }


        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, type: typeof(CarsDto[]))]
        public async Task<IActionResult> Get()
        {
            var entities = await _carsContext.Cars
                .AsNoTracking()
                .ToListAsync();

            var cars = entities.Select(entity => Convert(entity)).ToArray();
            return Ok(cars);
        }
        [HttpGet("{carsId:int}")]
        [SwaggerResponse(StatusCodes.Status200OK, type: typeof(CarsDto))]
        public async Task<IActionResult> Get(int carsId)
        {
            var cars = await _carsContext.Cars
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == carsId);
            if (cars == null)
                return NotFound();
            return Ok(Convert(cars));
        }

         [HttpPost]
          public async Task<IActionResult> Post([FromBody] CarsDto cars)
         {
            var entity = Convert(cars);
            await _carsContext.Cars.AddAsync(entity);
            await _carsContext.SaveChangesAsync();
            return Created($"api/v1/cars/{entity.Id}", null);
           }
             



        [HttpDelete("{car_uid}")]
        public async Task<IActionResult> Delete(Guid car_uid)
        {
            var car = _carsContext.Cars.FirstOrDefault(car => car.car_uid == car_uid);
            if (car == null)
                return NotFound("Аренда не найдена");
            _carsContext.Cars.Remove(car);
            await _carsContext.SaveChangesAsync();
            return NoContent();

        }
        private static CarsDto Convert(CarsEntity entity)
        {
            return new CarsDto()
            {
                Id = entity.Id,
                car_uid = entity.car_uid,
                brand = entity.brand,
                model = entity.model,
                registration_number = entity.registration_number,
                power = entity.power,
                price = entity.price,
                type = entity.type,
                availability = entity.availability,
            };
        }

        private static CarsEntity Convert(CarsDto entity)
        {
            return new CarsEntity()
            {
                Id = entity.Id,
                car_uid = entity.car_uid,
                brand = entity.brand,
                model = entity.model,
                registration_number = entity.registration_number,
                power = entity.power,
                price = entity.price,
                type = entity.type,
                availability = entity.availability,
            };
        }
    }
}

