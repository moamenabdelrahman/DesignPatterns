using UIGenerator.Factories;

namespace UIGenerator
{
    public class MyApp
    {
        private IFactory _factory { get; set; }

        public MyApp(IFactory factory)
        {
            _factory = factory;
        }

        public void ChangeFactory(IFactory factory)
        {
            _factory = factory;
        }

        public void SomeOperation()
        {
            var button = _factory.CreateButton();
            var checkbox = _factory.CreateCheckBox();
            var dropdown = _factory.CreateDropDown();

            button.Display();
            checkbox.Display();
            dropdown.Display();
        }
    }
}
