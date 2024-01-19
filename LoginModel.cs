using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mss_app
{
    public class LoginModel : ObservableObject
    {

        private string _email;
        private bool _isLogged;

        protected string Email
        {
            get { return _email; }
            set
            {
                if (value != _email)
                {
                    _email = value;
                    OnPropertyChanged("username");
                }
            }
        }

        protected bool IsLogged
        {
            get { return _isLogged; }
            set
            {
                if (value != _isLogged)
                {
                    _isLogged = value;
                    OnPropertyChanged("password");
                }
            }
        }
    }
}
