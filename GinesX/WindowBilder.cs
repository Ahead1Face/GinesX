using GinesX.View;
using GinesX.ViewModel;

namespace GinesX
{
    public static class CurrentUser
    {
        public static int Id { get; set; }
        public static string Login { get; set; }
    }

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

        public static void ShowWindowGl(int newID, string newlogin, string newpassword)
        {
            CurrentUser.Id = newID;
            CurrentUser.Login = newlogin;

            var windowGl = new WindowGl();
            var windowGlModel = new WindowGlModel();
            windowGl.DataContext = windowGlModel;
            windowGl.Show();
            windowGlModel.EventCloseWindow += (sender, args) => { windowGl.Close(); };
        }
    }
}
