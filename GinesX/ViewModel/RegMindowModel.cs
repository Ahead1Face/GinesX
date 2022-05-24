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
using GinesX.Model;

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

        public string NewEmail
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged();
            }
        }
        public string Newlogin
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
            EmailColor = Brushes.Black;
            LoginColor = Brushes.Black;
            PasswordColor = Brushes.Black;
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

                     try
                     {
                         if (rg_email.IsMatch(NewEmail))
                         {
                             EmailColor = Brushes.DarkSeaGreen;
                         }
                         else
                         {
                             EmailColor = Brushes.Red;
                         }

                         if (rg_login.IsMatch(Newlogin))
                         {
                             LoginColor = Brushes.DarkSeaGreen;
                         }
                         else
                         {
                             LoginColor = Brushes.Red;
                         }

                         if (rg_pb.IsMatch(password))
                         {
                             PasswordColor = Brushes.DarkSeaGreen;
                         }
                         else
                         {
                             PasswordColor = Brushes.Red;
                         }
                     }
                     catch
                     {
                         MessageBox.Show("Введите данные");
                     }

                     using (BDConnect db = new BDConnect())
                     {
                         User user = db.User.Where(u => u.Login == Newlogin).FirstOrDefault();
                         if (LoginColor == Brushes.DarkSeaGreen && EmailColor == Brushes.DarkSeaGreen && PasswordColor == Brushes.DarkSeaGreen)
                         {
                             int maxID = db.User.Max(u => u.Id);
                             User newUser = new User(maxID + 1, Newlogin, NewEmail, password);
                             db.User.Add(newUser);
                             db.SaveChanges();
                             WindowBilder.ShowWindowGl(maxID + 1, Newlogin, password);
                             CloseWindow();
                         }
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
