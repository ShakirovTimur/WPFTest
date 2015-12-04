using System.Windows;
using ViewModel;
using VMBase;
using MessageBox = System.Windows.MessageBox;

namespace View
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class FirstUserView : CustomViewBase<FirstRoleVM>
    {
        public FirstUserView(ViewService viewService) : base(viewService)
        {
            InitializeComponent();
        }

        private void ShowMessageClick(object sender, RoutedEventArgs e)
        {
            string message;
            if (ClrPcker.SelectedColor != null)
            {
                var r = ClrPcker.SelectedColor.Value.R;
                var g = ClrPcker.SelectedColor.Value.G;
                var b = ClrPcker.SelectedColor.Value.B;
                message = ViewModel.GetRGBMessageText(r, g, b);
            }
            else
            {
                message = ViewModel.GetErrorMessageText();
            }

            MessageBox.Show(message);
        }
    }
}
