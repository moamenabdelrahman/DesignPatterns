namespace DocumentRenderer.Renderers
{
    public abstract class BaseRenderer
    {
        protected string _filePath { get; set; }

        protected BaseRenderer(string filePath)
        {
            _filePath = filePath;
        }

        public void Render()
        {
            this.InitializeFile();
            this.RenderContent();
            this.FinalizeFile();
        }

        protected virtual void InitializeFile()
        {
            Console.WriteLine($"Base: Initializing the file \"{_filePath}\"...");
        }

        protected abstract void RenderContent();

        protected virtual void FinalizeFile()
        {
            Console.WriteLine($"Base: Finalizing the file \"{_filePath}\"...");
        }
    }
}
