using DynamicStyling.Components.Styles;
using DynamicStyling.Components;
using System.ComponentModel;

namespace DynamicStyling
{
    internal class MyApp
    {
        public void SomeOperation()
        {
            // Create a base button
            IWidget button = new Button();

            // Apply styles to the button
            button = new Border(button);
            button = new BackgroundColor(button);
            button = new TextStyle(button);

            // Display the button's appearance
            Console.WriteLine("Button Display:");
            Console.WriteLine(button.Display());

            Console.WriteLine("\n*************************************\n");

            // Create a base textbox
            IWidget textBox = new TextBox();

            // Apply styles to the textbox
            textBox = new Border(textBox);
            textBox = new TextStyle(textBox);

            // Display the textbox's appearance
            Console.WriteLine("Text Box Display:");
            Console.WriteLine(textBox.Display());
        }
    }
}
