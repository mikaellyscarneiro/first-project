using Microsoft.AspNetCore.Mvc;
using MyFirstProject.Api.Models;
using MyFirstProject.Api.Repositories.Interfaces;

namespace MyFirstProject.Api.Controllers
{
    [ApiController]
    [Route("restaurants")]
    public class RestaurantsController : ControllerBase
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public RestaurantsController(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }

        [HttpGet("get-all")]
        public Restaurant[] Get()
        {
           return _restaurantRepository.GetAllRestaurants();
        }
    }
}
