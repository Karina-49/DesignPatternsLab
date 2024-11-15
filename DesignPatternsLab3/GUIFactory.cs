﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLab3
{
    public interface GUIFactory
    {
        Button CreateButton();
        Checkbox CreateCheckbox();
    }

}
