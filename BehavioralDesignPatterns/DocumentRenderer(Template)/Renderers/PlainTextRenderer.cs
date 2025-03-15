namespace DocumentRenderer.Renderers
{
    public class PlainTextRenderer: BaseRenderer
    {
        public PlainTextRenderer(string filePath) : base(filePath)
        {
        }

        protected override void RenderContent()
        {
            Console.WriteLine($"Plain Text Renderer: Rendering the file \"{_filePath}\"...");
        }
    }
}
