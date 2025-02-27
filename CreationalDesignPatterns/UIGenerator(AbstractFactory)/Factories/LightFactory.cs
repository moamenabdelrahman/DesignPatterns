using UIGenerator.Components.Button;
using UIGenerator.Components.CheckBox;
using UIGenerator.Components.DropDown;

namespace UIGenerator.Factories
{
    public class LightFactory : IFactory
    {
        public IButton CreateButton()
        {
            return new LightButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new LightCheckBox();
        }

        public IDropDown CreateDropDown()
        {
            return new LightDropDown();
        }
    }
}
