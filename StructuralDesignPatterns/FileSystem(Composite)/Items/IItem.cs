namespace FileSystem.Items
{
    public interface IItem
    {
        public string GetName();

        public int GetSize();
        
        public void DisplayHeirarchy();
    }
}
