using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GinesX.ViewModel
{
    internal class RegMindowModel
    {
        public event EventHandler RegMindowClose;
        private Command changeToMainWindow;

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
