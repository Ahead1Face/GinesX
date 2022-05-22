using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GinesX.ViewModel
{
    class WindowGlModel
    {
        public event EventHandler EventCloseWindow;

        public void CloseWindow() => EventCloseWindow?.Invoke(this, EventArgs.Empty);
    }
}
