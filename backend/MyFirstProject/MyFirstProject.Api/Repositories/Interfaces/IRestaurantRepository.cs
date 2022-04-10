using MyFirstProject.Api.Models;

namespace MyFirstProject.Api.Repositories.Interfaces
{
    public interface IRestaurantRepository
    {
        Restaurant[] GetAllRestaurants();
    }
}
