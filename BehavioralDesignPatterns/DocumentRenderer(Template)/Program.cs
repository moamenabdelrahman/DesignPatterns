using DocumentRenderer.Renderers;

namespace DocumentRenderer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pdfRenderer = new PDFRenderer("document.pdf");
            pdfRenderer.Render();

            Console.WriteLine("\n------------------------------------------------\n");

            var htmlRenderer = new HTMLRenderer("document.html");
            htmlRenderer.Render();

            Console.WriteLine("\n------------------------------------------------\n");

            var plainTextRenderer = new PlainTextRenderer("document.txt");
            plainTextRenderer.Render();
        }
    }
}
