using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace GinesX.ViewModel
{
    internal class MainWindowModel : INotifyPropertyChanged
    {
        public event EventHandler EventCloseWindow;
        public event PropertyChangedEventHandler PropertyChanged;

        string login;
        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        private Command changeToRegWindow;
        public void CLoseWindow()=> EventCloseWindow?.Invoke(this, EventArgs.Empty);
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
    }
}
