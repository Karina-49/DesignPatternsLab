using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLab3
{
    public class WindowsFactory : GUIFactory
    {
        public Button CreateButton() => new WindowsButton();
        public Checkbox CreateCheckbox() => new WindowsCheckbox();
    }

}
