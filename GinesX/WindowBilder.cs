using GinesX.View;
using GinesX.ViewModel;

namespace GinesX
{
    class WindowBilder
    {
        public static void ShowMainWindow()
        {
            var mainwindow = new MainWindow();
            var viewmodel = new MainWindowModel();
            mainwindow.DataContext = viewmodel;
            viewmodel.EventCloseWindow +=( sender, args) => { mainwindow.Close(); };
            mainwindow.Show();
        }

        public static void ShowRegWindow()
        {
            var regwindow = new RegWindow();
            var viewmodel = new RegMindowModel();
            regwindow.DataContext = viewmodel;
            viewmodel.RegMindowClose +=(sender, args) => { regwindow.Close(); };
            regwindow.Show();
        }
    }
}
