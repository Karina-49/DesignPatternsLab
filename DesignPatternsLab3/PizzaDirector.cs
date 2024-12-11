using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLab3
{
    public class PizzaDirector
    {
        private PizzaBuilder builder;

        public PizzaDirector(PizzaBuilder builder)
        {
            this.builder = builder;
        }

        public void ConstructPizza()
        {
            builder.BuildDough();
            builder.BuildSauce();
            builder.BuildTopping();
        }
    }

}
