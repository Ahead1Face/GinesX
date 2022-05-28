using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows;

namespace GinesX.ViewModel
{
    internal class MainWindowModel : INotifyPropertyChanged
    {
        public event EventHandler EventCloseWindow;
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        string login;
        public string Login
        {
            get { return login; }
            set
            {
                login = value;
                OnPropertyChanged();
            }
        }
        public void CLoseWindow() => EventCloseWindow?.Invoke(this, EventArgs.Empty);

        private Command changeToRegWindow;
        public Command ChangeToRegWindow
        {
            get
            {
                return changeToRegWindow ??
                    (changeToRegWindow = new Command(obj =>
                   {
                       WindowBilder.ShowRegWindow();
                       CLoseWindow();
                   }));
            }
        }

        private Command showToThirdWindow;
        public Command ShowToThirdWindow
        {
            get
            {
                return showToThirdWindow ?? (
                    showToThirdWindow = new Command(obj =>
                    {
                        using(BDConnect db = new BDConnect())
                        {
                            PasswordBox pb = (PasswordBox)obj;
                            var users = db.User.ToList();
                            var user = users.Where(u => u.Login == Login && u.Password == pb.Password).FirstOrDefault();
                            if (user != null)
                            {
                                WindowBilder.ShowMainToWindowGl(user.Id, user.Login);
                                CLoseWindow();
                            }
                            else
                                MessageBox.Show("Пользователь не найден");
                        }
                    }));
            }
        }

    }
}
