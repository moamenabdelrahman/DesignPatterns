using UIGenerator.Components.Button;
using UIGenerator.Components.CheckBox;
using UIGenerator.Components.DropDown;

namespace UIGenerator.Factories
{
    public interface IFactory
    {
        public IButton CreateButton();
        public ICheckBox CreateCheckBox();
        public IDropDown CreateDropDown();
    }
}
