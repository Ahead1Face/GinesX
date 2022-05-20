using GinesX.CustomControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GinesX
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            WindowBorder windowBorder = new WindowBorder(this);
            windowBorder.SetValue(Grid.RowProperty, 0);
            MainGrid.Children.Add(windowBorder);
        }

        private void TB_Login_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex rg = new Regex(@"^[A-Za-z1-9]{1,15}$");
            if (rg.IsMatch(TB_Login.Text))
                TB_Login.Foreground = new SolidColorBrush(Colors.Green);
            else
                TB_Login.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void TB_Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            Regex rg = new Regex(@"^[A-Z]{1,5}[A-Za-z1-9]{1,20}[!@#%^&*]{1,5}$");
            if (rg.IsMatch(TB_Password.Password))
                TB_Password.Foreground = new SolidColorBrush(Colors.Green);
            else
                TB_Password.Foreground = new SolidColorBrush(Colors.Red);
        }
    }
}
