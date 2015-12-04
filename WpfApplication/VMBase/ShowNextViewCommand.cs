using System.Windows.Input;

namespace VMBase
{
    public class ShowNextViewCommand : RoutedUICommand
    {
        private static readonly ShowNextViewCommand _instance = new ShowNextViewCommand();
        public static ShowNextViewCommand Instance => _instance;
    }
}