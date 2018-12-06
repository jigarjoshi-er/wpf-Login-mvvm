using LoginMVVM.ViewModel;
using System.Windows;

namespace LoginMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = ViewModel = new LoginViewModel();
            InitializeComponent();
        }

        private LoginViewModel ViewModel { get; set; }
    }
}
