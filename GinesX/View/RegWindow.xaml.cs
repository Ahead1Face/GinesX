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
using System.Windows.Shapes;

namespace GinesX.View
{
    /// <summary>
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        public RegWindow()
        {
            InitializeComponent();

            WindowBorder windowBorder = new WindowBorder(this);
            windowBorder.SetValue(Grid.RowProperty, 0);
            MainGrid.Children.Add(windowBorder);
        }

        private void TB_Email_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex rg = new Regex(@"^[A-Za-z1-9]{1,20}[@][a-z]{1,15}[.][a-z]{1,10}$");
            if (rg.IsMatch(TB_Email.Text))
                TB_Email.Foreground = new SolidColorBrush(Colors.Green);
            else
                TB_Email.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void TB_Login_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex rg = new Regex(@"^[A-Za-z1-9]{1,15}$");
            if (rg.IsMatch(TB_Login.Text))
                TB_Login.Foreground = new SolidColorBrush(Colors.Green);
            else
                TB_Login.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void PB_Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            Regex rg = new Regex(@"^[A-Z]{1,5}[A-Za-z1-9]{1,20}[!@#%^&*]{1,5}$");
            if (rg.IsMatch(PB_Password.Password))
                PB_Password.Foreground = new SolidColorBrush(Colors.Green);
            else
                PB_Password.Foreground = new SolidColorBrush(Colors.Red);
        }
    }
}
