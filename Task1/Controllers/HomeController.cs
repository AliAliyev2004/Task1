using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task1.Entites;

namespace Task1.Controllers
{
    public class HomeController : Controller
    {


        public string Index()
        {
            return "Hello string Action";

        }
        public IActionResult Index2()
        {
            return View();
        }
        public ViewResult Drink()
        {
            List<Drink> drinks = new List<Drink>() {
            new Drink
            {
                Id = 1,
                Name = "Milk",
                Price = 10
            },
            new Drink
            {
                Id=2,
                Name="Kola",
                Price=8
            },
            new Drink
            {
                Id=3,
                Name="Fanta",
                Price=7
            }
           };
            return View(drinks);

        }
        public ViewResult Drink2()
        {
            List<Drink> drinks = new List<Drink>() {
            new Drink
            {
                Id = 1,
                Name = "Milk",
                Price = 10
            },
            new Drink
            {
                Id=2,
                Name="Kola",
                Price=8
            },
            new Drink
            {
                Id=3,
                Name="Fanta",
                Price=7
            }
           };
            return View(drinks);

        }
        public ViewResult HotMeal()
        {
            List<HotMeal> hotMeals = new List<HotMeal>()
            {
                new HotMeal
                {
                    Id=1,
                    Name="Coffe",
                    Price=15
                },
                new HotMeal
                {
                    Id=2,
                    Name="Tea",
                    Price=5
                }

            };
            return View(hotMeals);
        }
        public ViewResult FastFood()
        {
            List<FastFood> fastFoods = new List<FastFood>()
            {
                new FastFood
                {
                    Id = 1,
                    Name = "Hamburger",
                    Price = 20
                },
                new FastFood
                {
                    Id = 2,
                    Name = "Pizza",
                    Price = 32

                },
                new FastFood
                {
                    Id = 3,
                    Name = "Doner",
                    Price = 18



                }


            };
            return View(fastFoods);
        }
    }
}
