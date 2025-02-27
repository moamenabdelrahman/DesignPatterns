namespace UIGenerator.Components.CheckBox
{
    public class DarkCheckBox : ICheckBox
    {
        private string Description { get; set; }

        public DarkCheckBox()
        {
            this.Description = "This is a Dark-themed CheckBox!";
        }

        public void Display()
        {
            Console.WriteLine(this.Description);
        }
    }
}
