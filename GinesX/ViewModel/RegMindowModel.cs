using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace GinesX.ViewModel
{
    internal class RegMindowModel : INotifyPropertyChanged
    {
        public event EventHandler RegMindowClose;
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        string email;
        string login;
        System.Windows.Media.Brush emailColor;
        public System.Windows.Media.Brush EmailColor
        {
            get { return emailColor; }
            set
            {
                emailColor = value;
                OnPropertyChanged("EmailColor");
            }
        }


        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged();
            }
        }
        public string Login
        {
            get { return login; }
            set
            {
                login = value;
                OnPropertyChanged();
            }
        }

        private Command changeToMainWindow;


        private Command reg;

        public RegMindowModel()
        {
            EmailColor = System.Windows.Media.Brushes.Black;
        }

        public Command Reg
        {
            get
            {
                return reg ?? (reg = new Command(obj =>
                 {
                     PasswordBox pb = (PasswordBox)obj;
                     string password = pb.Password;

                     Regex rg_email= new Regex(@"^[A-Za-z1-9]{1,20}[@][a-z]{1,15}[.][a-z]{1,10}$");
                     Regex rg_login = new Regex(@"^[A-Za-z1-9]{1,15}$");
                     Regex rg_pb = new Regex(@"^[A-Z]{1,5}[A-Za-z1-9]{1,20}[!@#%^&*]{1,5}$");

                     if (rg_email.IsMatch(Email))
                     {
                         EmailColor = System.Windows.Media.Brushes.DarkSeaGreen;
                     }
                     else
                     {
                         EmailColor = System.Windows.Media.Brushes.Red;
                     }
                     
                 }));
            }
   
        }

        public void CloseWindow() => RegMindowClose?.Invoke(this, EventArgs.Empty);
        public Command ChangeToMainWindow
        {
            get
            {
                return changeToMainWindow ??
                (changeToMainWindow = new Command(obj =>
                {
                    WindowBilder.ShowMainWindow();
                    CloseWindow();
                }
                ));
            }
        }
    }
}
