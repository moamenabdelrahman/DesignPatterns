using DocumentVersioning.Mementos;

namespace DocumentVersioning.Originators
{
    public interface IOriginator
    {
        public void SaveVersion();

        public void Restore(IMemento memento);
    }
}
