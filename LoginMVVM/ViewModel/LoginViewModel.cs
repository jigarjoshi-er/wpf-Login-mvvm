using LoginMVVM.Helpers;
using System.Windows;
using System.Windows.Input;

namespace LoginMVVM.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        public ICommand LoginCommand { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new Command(x => Submit());
        }

        private string userName;
        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                NotifyPropertyChanged(nameof(UserName));
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                NotifyPropertyChanged(nameof(Password));
            }
        }

        private void Submit()
        {
            if (string.IsNullOrWhiteSpace(UserName))
            {
                MessageBox.Show("Please enter UserName.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Please enter Password.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if(UserName == "Admin" && Password == "Demo123")
            {
                MessageBox.Show("Login Successfull.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
