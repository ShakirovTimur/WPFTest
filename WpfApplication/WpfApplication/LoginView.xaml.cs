using Facade;
using System.Windows;
using ViewModel;
using VMBase;

namespace View
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : CustomViewBase<LoginViewModel>
    {
        public LoginView(ViewService viewService) : base(viewService)
        {
            InitializeComponent();
        }

        private void LoginClick(object sender, RoutedEventArgs e)
        {
            if (ViewModel.TryToAuthorize())
            {
                switch (ViewModel.Role)
                {
                    case RoleType.FirstRole:
                        _viewService.NextView = _viewService.CreateView<FirstUserView>();

                        break;
                    case RoleType.SecondRole:
                        _viewService.NextView = _viewService.CreateView<SecondUserView>();

                        break;
                    case RoleType.ThirdRole:
                        _viewService.NextView = _viewService.CreateView<ThirdUserView>();

                        break;
                    default:
                        MessageBox.Show("Undefined role");
                        break;

                }
                ShowNextViewCommand.Instance.Execute(this, this);
            }
            else
            {
                MessageBox.Show("Authorization failed");
            }
        }
    }
}
