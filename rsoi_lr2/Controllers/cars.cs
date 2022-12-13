using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;

namespace rsoi_lr2.Controllers
{
    [ApiController]
    [Route("api/v1/cars")]
    public class CarsController : ControllerBase
    {
        private readonly CarsContext _carsContext;
        private readonly ILogger<cars> _logger;

        public CarsController(_carsContext cr)
        {
            this.cr = cr;
            if (this.cr.cars.Count() == 0)
            {
                this.cr.cars.Add(new cars()
                {
                    id = 1,
                    car_uid = "109b42f3-198d-4c89-9276-a7520a7120ab",
                    brand = "Mercedes Benz",
                    model = "GLA 250",
                    registration_number = "ЛО777Х799",
                    power = 249,
                    type = "SEDAN",
                    price = 3500,
                    available = true
                });
                cr.SaveChanges();
            }
        }
    
    public CarsController(ILogger<cars> logger)
        {
            _logger = logger;
            _carsContext = carsContext;
        }
    }
        

        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, type: typeof(CarsDto[]))]
        public IEnumerable<cars> GetCars()
        {
            return Ok(cars);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CarsDto cars)
        {

            if (cars.id == 0)
            {
                if (cr.Cars.Count() > 0)
                {
                    cars.id = Cars.Max(r => r.id) + 1;
                }
                else
                {
                    cars.id = 1;
                }
            }
            if (cars.car_uid == Guid.Empty)
            {
                cars.car_uid = Guid.NewGuid();
            }
            car.date_From = car.date_From.ToUniversalTime().AddHours(3);
            car.date_To = car.date_To.ToUniversalTime().AddHours(3);

            Cars.Add(cars);
            SaveChanges();

            return Ok(cars);
        }


        [HttpDelete("{car_uid}")]
        public async Task<IActionResult> Delete(int car_uid)
        {
            var car = cr.Cars.FirstOrDefault(car => car.car_uid == car_uid);
            if (car == !null)
            {
                car.Status = "canceled";
                cr.SaveChanges();
                return Ok();
            }
            return NoContent();
        }
    }

   
