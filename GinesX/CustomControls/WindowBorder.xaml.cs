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
    /// Логика взаимодействия для WindowBorder.xaml
    /// </summary>
    public partial class WindowBorder : UserControl
    {
        Window parent;
        public WindowBorder(Window parent)
        {
            InitializeComponent();
            this.parent = parent;
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
                parent.DragMove();
        }
    }
}
