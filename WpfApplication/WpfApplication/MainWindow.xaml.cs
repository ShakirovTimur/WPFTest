using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using View;
using VMBase;

namespace WpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private ContentControl _currentConent;
        private readonly ViewService _viewService = new ViewService();
        public MainWindow()
        {
            InitializeComponent();
            CommandBindings.Add(new CommandBinding(ShowNextViewCommand.Instance, OnNextView));
            var login = _viewService.CreateView<LoginView>();// new LoginView();
            login.ViewModel.Login = "User";
            CurrentContent = login;
        }

        private void OnNextView(object sender, ExecutedRoutedEventArgs executedRoutedEventArgs)
        {
            CurrentContent = _viewService.NextView as ContentControl;
        }

        public ContentControl CurrentContent
        {
            get { return _currentConent; }
            private set
            {
                _currentConent = value;
                var pc = PropertyChanged;
                pc?.Invoke(this, new PropertyChangedEventArgs("CurrentContent"));
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }


}
