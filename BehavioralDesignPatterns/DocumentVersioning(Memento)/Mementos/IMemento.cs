namespace DocumentVersioning.Mementos
{
    public interface IMemento
    {
        public string GetTitle();

        public string GetContent();
    }
}
