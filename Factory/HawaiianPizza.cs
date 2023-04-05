using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RomansAPI.Factory
{
    public class HawaiianPizza : IPizza
    {
        public string GetBase()
        {
            return "Tomato Base";
        }

        public List<string> GetToppings()
        {
            return new List<string>()
            {
                "Ham",
                "Pineapple",
            };
        }
    }
}