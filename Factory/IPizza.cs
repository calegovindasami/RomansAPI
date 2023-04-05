using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RomansAPI.Factory
{
    public interface IPizza
    {
        public string GetBase();
        public List<string> GetToppings();
    }
}