using UIGenerator.Components.Button;
using UIGenerator.Components.CheckBox;
using UIGenerator.Components.DropDown;

namespace UIGenerator.Factories
{
    public class DarkFactory : IFactory
    {
        public IButton CreateButton()
        {
            return new DarkButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new DarkCheckBox();
        }

        public IDropDown CreateDropDown()
        {
            return new DarkDropDown();
        }
    }
}
