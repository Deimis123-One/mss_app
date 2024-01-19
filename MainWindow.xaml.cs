using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mss_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
        }

        private void closeApp(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }
    }

    public class LoginViewModel :ObservableObject
    {
        private LoginModel _currentUser;
        private ICommand _getUserData;
        private ICommand _saveUserData;


        public LoginModel CurrenUser
        {
            get { return _currentUser; }
            set
            {
                if (value != null)
                {
                    _currentUser = value;
                    OnPropertyChanged("CurrentUser");
                }
            }
        }

        public ICommand SaveUserDataCommand
        {
            get
            {
                if (_saveUserData == null)
                {
                    _saveUserData = new RelayCommand(
                        param => SaveUserData(),
                        param => (_currentUser == null)
                    );
                }
                return _saveUserData;
            }
        }

        public ICommand GetUserDataCommand
        {
            get
            {
                if (_saveUserData == null)
                {
                    _saveUserData = new RelayCommand(
                        param => GetUserData()
                    );
                }
                return _getUserData;
            }
        }

        private void SaveUserData()
        {
            /// Some code to save user data in class
        }

        private void GetUserData()
        {
            /// Some code to collect user data
            /// from DB
        }
    }
}
