namespace DocumentRenderer.Renderers
{
    public class PDFRenderer : BaseRenderer
    {
        public PDFRenderer(string filePath): base(filePath)
        {
        }

        protected override void RenderContent()
        {
            Console.WriteLine($"PDF Renderer: Rendering the file \"{_filePath}\"...");
        }
    }
}
