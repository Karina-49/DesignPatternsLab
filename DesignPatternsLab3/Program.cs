using DesignPatternsLab3;

class Program
{
    static void Main(string[] args)
    {
        GUIFactory factory = new WindowsFactory();
        Button button = factory.CreateButton();
        Checkbox checkbox = factory.CreateCheckbox();

        button.Click();
        checkbox.Toggle();

        factory = new MacFactory();
        button = factory.CreateButton();
        checkbox = factory.CreateCheckbox();

        button.Click();
        checkbox.Toggle();
    }
}
