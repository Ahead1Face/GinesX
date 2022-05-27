using GinesX.CustomControls;
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
using System.Windows.Shapes;

namespace GinesX.View
{
    /// <summary>
    /// Логика взаимодействия для WindowGl.xaml
    /// </summary>
    public partial class WindowGl : Window
    {
        public WindowGl()
        {
            InitializeComponent();

            WindowBorderToThird windowBorderToThird = new WindowBorderToThird(this);
            windowBorderToThird.SetValue(Grid.RowProperty, 0);
            MainGrid.Children.Add(windowBorderToThird);
        }
    }
}
