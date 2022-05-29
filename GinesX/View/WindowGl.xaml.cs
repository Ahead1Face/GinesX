using GinesX.CustomControls;
using GinesX.Model;
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
            FillGrid();
        }
        void FillGrid()
        {
            using(BDConnect db = new BDConnect())
            {
                List<RowDefinition> rows = new List<RowDefinition>();
                int gameCount = db.Game.Count();
                int rowsCount = 20;
                for (int i = 0; i < rowsCount; i++)
                {
                    rows.Add(new RowDefinition());
                    rows[i * 2].Height = new GridLength(30);
                    rows.Add(new RowDefinition());
                    rows[(i * 2) + 1].Height = new GridLength(130, GridUnitType.Star);
                }
                rows.Add(new RowDefinition());
                rows[rowsCount - 1].Height = new GridLength(30);

                for(int i = 0; i < rows.Count; i++)
                {
                    GameGrid.RowDefinitions.Add(rows[i]);
                }

                int columnNum = 1;
                int rowNum = 1;
                int index = 0;

                foreach(Game game in db.Game)
                {
                    StackPanel sp = new StackPanel();
                    sp.SetValue(Grid.RowProperty, rowNum);
                    sp.SetValue(Grid.ColumnProperty, columnNum);

                    Label price = new Label();
                    price.HorizontalAlignment = HorizontalAlignment.Center;
                    price.Content = game.Price + " рублей";

                    Label Name = new Label();
                    Name.HorizontalAlignment = HorizontalAlignment.Center;
                    Name.Content = game.Title;

                    Image image = new Image();
                    BitmapImage Logo = DataTransform.ByteToImage(game.Image);
                    image.Source = Logo;
                    if (columnNum == 1)
                        columnNum = 3;
                    else if (columnNum == 3)
                        columnNum = 5;
                    else
                        columnNum = 1;

                    sp.Children.Add(image);
                    sp.Children.Add(Name);
                    sp.Children.Add(price);
                    GameGrid.Children.Add(sp);

                    if((index + 1) % 3 == 0)
                    {
                        rowNum += 2;
                    }
                    index++;
                }
            }
        }
    }
}
