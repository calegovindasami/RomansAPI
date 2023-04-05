using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RomansAPI.Factory
{
    public class Pizza
    {
        public string Base { get; set; } = null!;
        public List<string> Toppings { get; set; } = null!;
    }
}