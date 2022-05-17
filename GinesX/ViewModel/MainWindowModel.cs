using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GinesX.ViewModel
{
    internal class MainWindowModel
    {
        public event EventHandler EventCloseWindow;

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
