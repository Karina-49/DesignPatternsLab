﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLab3
{
    public class Pizza
    {
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public string Topping { get; set; }

        public override string ToString()
        {
            return $"Pizza with Dough: {Dough}, Sauce: {Sauce}, Topping: {Topping}";
        }
    }

}
