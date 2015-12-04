using Model;

namespace ViewModel
{
    public class FirstRoleVM : ViewModelBase.ViewModelBase
    {
        public FirstRoleVM(Models context) : base(context)
        {

        }

        public string GetRGBMessageText(byte r, byte g, byte b)
        {
            return $"R={r}; G={g}; B={b}";
        }
        public string GetErrorMessageText()
        {
            return "You should pick some color";
        }
    }
}