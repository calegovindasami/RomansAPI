using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RomansAPI.Factory
{
    public class SweetChilliChickenPizza : IPizza
    {
        public string GetBase()
        {
            return "Sweet Chilli Base";
        }

        public List<string> GetToppings()
        {
            return new List<string>()
            {
                "Chicken",
                "Piquante Peppers",
                "Feta Cheese",
            };
        }
    }
}