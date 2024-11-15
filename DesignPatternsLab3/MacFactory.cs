using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLab3
{
    public class MacFactory : GUIFactory
    {
        public Button CreateButton() => new MacButton();
        public Checkbox CreateCheckbox() => new MacCheckbox();
    }

}
