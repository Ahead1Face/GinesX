using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace GinesX.CustomControls
{
    /// <summary>
    /// Логика взаимодействия для WindowBorderToThird.xaml
    /// </summary>
    public partial class WindowBorderToThird : UserControl
    {
        Window parent;
        public WindowBorderToThird(Window parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        private void B_hide_Click(object sender, RoutedEventArgs e)
        {
            this.parent.WindowState = WindowState.Minimized;
        }

        private void B_Close_Click(object sender, RoutedEventArgs e)
        {
            this.parent?.Close();
        }

        private void UserControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                parent.DragMove();
            }
                
        }

        private void B_Maximaize_Click(object sender, RoutedEventArgs e)
        {
            if(this.parent.WindowState == WindowState.Maximized)
            {
                this.parent.WindowState = WindowState.Normal;
            }
            else
            {
                this.parent.WindowState = WindowState.Maximized;
            }
        }
    }
}
