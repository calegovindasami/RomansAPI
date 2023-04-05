using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RomansAPI.Factory
{
    public class PizzaFactory
    {
        public IPizza ReturnInstance { get; set; } = null!;
        public IPizza GetPizza(string pizzaType){
            switch (pizzaType)
            {
                case "CheesePizza":
                ReturnInstance = new CheesePizza();
                break;

                case "HawaiianPizza":
                ReturnInstance = new HawaiianPizza();
                break;

                case "MargheritaPizza":
                ReturnInstance = new MargheritaPizza();
                break;

                case "SweetChilliChickenPizza":
                ReturnInstance = new SweetChilliChickenPizza();
                break;
            }

            return ReturnInstance;
        }
    }
}