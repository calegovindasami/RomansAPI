using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RomansAPI.Factory
{
    public class CheesePizza : IPizza
    {
        public string GetBase()
        {
            return "Tomato";
        }

        public List<string> GetToppings()
        {
            return new List<string>()
            {
                "Mozzarella Cheese",
            };
        }
    }
}