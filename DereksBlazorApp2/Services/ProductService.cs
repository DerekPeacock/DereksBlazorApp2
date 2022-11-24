using DereksBlazorApp2.Models;

namespace DereksBlazorApp2.Services
{
    public class ProductService
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product()
            {
                Id = 1,
                Name =  "Nike Waffle Debue",
                ImageURL = "NikeWaffle.png",
                Type = 1
            },
            new Product()
            {
                Id = 2,
                Name =  "Nike Air Force",
                Type = 2
            },
            new Product()
            {
                Id = 3,
                Name =  "Nike Air Jordon",
                ImageURL = "NikeWaffle.png",
                Type = 3
            },
        };
    }
}
