using Core.Models;

namespace Restaurants.Services
{
    public interface IRestaurantService
    {
        IEnumerable<Restaurant> GetAll();

        Restaurant Get(int id);

        void Add(Restaurant restaurant);

        void Update(Restaurant restaurant);

        void Delete(int id);
    }
}
