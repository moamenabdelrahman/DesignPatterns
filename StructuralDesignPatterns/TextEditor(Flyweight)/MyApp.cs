using TextEditor.Character;

namespace TextEditor
{
    public class MyApp
    {
        private FormatFactory _factory { get; set; }

        public MyApp(FormatFactory factory)
        {
            _factory = factory;
        }

        public void SomeOperation()
        {
            // Test Some Format
            var format = _factory.GetFormat("TimesNewRoman", 14, "Black");
            var context = new CharacterContext(format, 'M');
            context.TypeOnScreen();

            Console.WriteLine();

            // Change Format & character
            format = _factory.GetFormat("Daytona", 22, "Red");
            context.SetFormat(format);
            context.SetCharacter('m');
            context.TypeOnScreen();
        }
    }
}
