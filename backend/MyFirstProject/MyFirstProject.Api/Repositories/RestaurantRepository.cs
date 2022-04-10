using MyFirstProject.Api.Models;
using MyFirstProject.Api.Repositories.Interfaces;

namespace MyFirstProject.Api.Repositories
{
    public class RestaurantRepository : IRestaurantRepository
    {
        public Restaurant[] GetAllRestaurants()
        {
            var restaurants = new Restaurant[3];

            var restaurant1 = new Restaurant
            {
                Name = "Burger King",
                Description = "Restaurante de Hamburgueres e Bebidas - Fast Food",
                PaymentMethods = new[] { "Cartão de Crédito", "Cartão de Débito", "Dinheiro", "Pix", "Refeição" },
                ImageUrl = "https://static-images.ifood.com.br/image/upload/t_high/logosgde/99f8f70a-d9eb-4c3d-95cc-6f4ed12e32e0/202102121046_jNts_i.png",
                Contact = new Contact
                {
                    Email = "contato@burgerking.com",
                    Phone = "(00) 0000-0000"
                }
            };

            var restaurant2 = new Restaurant
            {
                Name = "Meio Kilão",
                Description = "Restaurante de Hamburgueres Artesanais",
                PaymentMethods = new[] { "Cartão de Crédito", "Cartão de Débito", "Dinheiro", "Pix" },
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSWjq2nUkNb2KDozp90l7BjV6brt2yTMoLyyjX1MmrziKXNomuOLP5JVfDluu0GMXgkgCo&usqp=CAU",
                Contact = new Contact
                {
                    Email = "contato@meiokilao.com",
                    Phone = "(00) 0000-0000"
                }
            };

            var restaurant3 = new Restaurant
            {
                Name = "KFC",
                Description = "Restaurante de Hamburgueres de Frango - Fast Food",
                PaymentMethods = new[] { "Cartão de Crédito", "Cartão de Débito", "Dinheiro", "Pix", "Refeição" },
                ImageUrl = "https://wikiimg.tojsiabtv.com/wikipedia/en/thumb/b/bf/KFC_logo.svg/1200px-KFC_logo.svg.png",
                Contact = new Contact
                {
                    Email = "contato@kfc.com",
                    Phone = "(00) 0000-0000"
                }
            };

            restaurants[0] = restaurant1;
            restaurants[1] = restaurant2;
            restaurants[2] = restaurant3;

            return restaurants;
        }
    }
}
