using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLab3
{
    public interface Checkbox
    {
        void Toggle();
    }

    public class WindowsCheckbox : Checkbox
    {
        public void Toggle() => Console.WriteLine("Windows Checkbox toggled!");
    }

    public class MacCheckbox : Checkbox
    {
        public void Toggle() => Console.WriteLine("Mac Checkbox toggled!");
    }

}
