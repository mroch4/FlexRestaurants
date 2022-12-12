using Core.Models;

namespace Restaurants.Services
{
    public class RestaurantService : IRestaurantService
    {
        List<Restaurant> restaurants;

        public RestaurantService()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Forni Rossi", Cuisine = CuisineType.Italian},
                new Restaurant { Id = 2, Name = "Petit Paris", Cuisine = CuisineType.French},
                new Restaurant { Id = 3, Name = "The Mexican", Cuisine = CuisineType.Mexican},
                new Restaurant { Id = 4, Name = "Chmeli Suneli", Cuisine = CuisineType.Georgian},
            };
        }

        public void Add(Restaurant restaurant)
        {
            restaurants.Add(restaurant);

            restaurant.Id = restaurants.Max(r => r.Id) + 1;
        }

        public void Update(Restaurant restaurant)
        {
            var existing = Get(restaurant.Id);

            if (existing != null)
            {
                existing.Name = restaurant.Name;
                existing.Cuisine = restaurant.Cuisine;
            }
        }

        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }

        public void Delete(int id)
        {
            var restaurant = Get(id);

            if (restaurant != null)
            {
                restaurants.Remove(restaurant);
            }
        }
    }
}
