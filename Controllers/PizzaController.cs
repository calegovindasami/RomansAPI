using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RomansAPI.Factory;
using Microsoft.AspNetCore.Mvc;

namespace RomansAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PizzaController : ControllerBase
    {
        [HttpGet]
        public Pizza GetPizza(string pizzaType)
        {
            PizzaFactory pizzaFactory = new();
            IPizza pizza = pizzaFactory.GetPizza(pizzaType);
            return new Pizza
            {
                Base = pizza.GetBase(),
                Toppings = pizza.GetToppings()
            };
        }
    }
}