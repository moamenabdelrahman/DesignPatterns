namespace DocumentRenderer.Renderers
{
    public class HTMLRenderer: BaseRenderer
    {
        public HTMLRenderer(string filePath) : base(filePath)
        {
        }

        protected override void RenderContent()
        {
            Console.WriteLine($"HTML Renderer: Rendering the file \"{_filePath}\"...");
        }
    }
}
