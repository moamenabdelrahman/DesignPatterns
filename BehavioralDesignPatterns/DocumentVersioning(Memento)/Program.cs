using DocumentVersioning.Originators;

namespace DocumentVersioning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var document = new Document("My Document");
            
            // Perform some operations
            document.AddTextAt("Initial content", 0);
            document.AddTextAt(" is cool", 15);
            document.RemoveTextAt(0, 8);
            Console.WriteLine(document);

            Console.WriteLine();

            // Undo the last operation
            document.Undo();
            Console.WriteLine(document);
        }
    }
}
