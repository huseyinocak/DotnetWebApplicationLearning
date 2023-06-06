using Microsoft.AspNetCore.Mvc;

namespace BigDotShop.WebAPI.Controllers
{
    [ApiController]
    [Route("/")]
    [Route("[Controller]")]
    public class CarController : Controller
    {
        private readonly ICar car;

        public CarController(ICar car)
        {
            this.car = car;
        }

        [HttpGet]
        public IActionResult CarsSpeed()
        {
           return Ok(car.Speed());
        }
    }
}
