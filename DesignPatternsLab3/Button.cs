using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLab3
{
    public interface Button
    {
        void Click();
    }

    public class WindowsButton : Button
    {
        public void Click() => Console.WriteLine("Windows Button clicked!");
    }

    public class MacButton : Button
    {
        public void Click() => Console.WriteLine("Mac Button clicked!");
    }

}
