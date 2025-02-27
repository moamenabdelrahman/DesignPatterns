using FileSystem.Items;
using File = FileSystem.Items.File;

namespace FileSystem
{
    public class MyApp
    {
        public void SomeOperation()
        {
            // Create files
            IItem file1 = new File("Document.txt", 100);
            IItem file2 = new File("Image.jpg", 500);
            IItem file3 = new File("Spreadsheet.xlsx", 200);

            // Create folders
            Folder folder1 = new Folder("Documents");
            Folder folder2 = new Folder("Images");
            Folder rootFolder = new Folder("Root");

            // Add files to folders
            folder1.AddItem(file1);
            folder1.AddItem(file3);
            folder2.AddItem(file2);

            // Add folders to the root folder
            rootFolder.AddItem(folder1);
            rootFolder.AddItem(folder2);

            // Display the root folder heirarchy
            rootFolder.DisplayHeirarchy();
        }
    }
}
