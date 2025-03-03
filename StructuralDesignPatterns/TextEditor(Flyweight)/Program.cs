namespace TextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = new FormatFactory();
            var app = new MyApp(factory);

            app.SomeOperation();
        }
    }
}
