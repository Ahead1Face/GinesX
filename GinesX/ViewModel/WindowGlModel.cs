using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace GinesX.ViewModel
{
    class WindowGlModel : INotifyPropertyChanged
    {
        public WindowGlModel()
        {
            EditLogin = CurrentUser.Login;
            EditEmail = CurrentUser.Email;

            LoginColor = Brushes.Black;
            EmailColor = Brushes.Black;
            PasswordColor = Brushes.Black;
        }
        public event EventHandler EventCloseWindow;
        public void CloseWindow() => EventCloseWindow?.Invoke(this, EventArgs.Empty);

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        string editLogin;
        string editEmail;

        Brush emailColor;
        Brush loginColor;
        Brush passwordColor;
        public Brush EmailColor
        {
            get { return emailColor; }
            set
            {
                emailColor = value;
                OnPropertyChanged("EmailColor");
            }
        }

        public Brush LoginColor
        {
            get { return loginColor; }
            set
            {
                loginColor = value;
                OnPropertyChanged("LoginColor");
            }
        }

        public Brush PasswordColor
        {
            get { return passwordColor; }
            set
            {
                passwordColor = value;
                OnPropertyChanged("PasswordColor");
            }
        }

        public string EditLogin
        {
            get { return editLogin; }
            set
            {
                editLogin = value;
                OnPropertyChanged("EditLogin");
            }
        }
        public string EditEmail
        {
            get { return editEmail; }
            set
            {
                editEmail = value;
                OnPropertyChanged("EditEmail");
            }
        }

        private Command edit;
        public Command Edit
        {
            get
            {
                return edit ?? (edit = new Command(obj =>
                {
                    PasswordBox pb = (PasswordBox)obj;
                    string password = pb.Password;

                    Regex rg_email = new Regex(@"^[A-Za-z1-9]{1,20}[@][a-z]{1,15}[.][a-z]{1,10}$");
                    Regex rg_login = new Regex(@"^[A-Za-z1-9]{1,15}$");
                    Regex rg_pb = new Regex(@"^[A-Z]{1,5}[A-Za-z1-9]{1,20}[!@#%^&*]{1,5}$");

                    using (BDConnect db = new BDConnect())
                    {
                        var users = db.User.ToList();
                        var user = users.Where(u => u.Login == CurrentUser.Login).FirstOrDefault();
                        if(user != null)
                        {
                            if (rg_email.IsMatch(EditEmail))
                            {
                                user.Email = EditEmail;
                                MessageBox.Show("Электронная почта изменена");
                            }
                            else
                                MessageBox.Show("Электронная почта не изменена");
                            if (rg_login.IsMatch(EditLogin))
                            {
                                user.Login = EditLogin;
                                MessageBox.Show("Логин изменен");
                            }
                            else
                                MessageBox.Show("Логин не изменен");
                            if (rg_pb.IsMatch(password))
                            {
                                user.Password = password;
                                MessageBox.Show("Пароль изменен");
                            }
                            else
                                MessageBox.Show("Пароль не изменен");
                        }
                        
                           
                    }
                }));
            }
        }
        
    }
}
