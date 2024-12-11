using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLab3
{
    public class HawaiianPizzaBuilder : PizzaBuilder
    {
        private Pizza pizza;

        public HawaiianPizzaBuilder()
        {
            this.pizza = new Pizza();
        }

        public void BuildDough()
        {
            pizza.Dough = "cross";  // Гавайская пицца с тестом в виде креста
        }

        public void BuildSauce()
        {
            pizza.Sauce = "mild";  // Мягкий соус
        }

        public void BuildTopping()
        {
            pizza.Topping = "ham+pineapple";  // В качестве начинки: ветчина и ананас
        }

        public Pizza GetResult()
        {
            return pizza;
        }
    }

}
