using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace GinesX.Model
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public byte[] Image { get; set; }

        public virtual List<User> Users { get; set; }

        public Game()
        {
            Id = 0;
            Title = "";
            Price = 0;
            Image = new byte[0];
        }
        public Game(int id, string title, int price, string imagePath)
        {
            Id = id;
            Title = title;
            Price = price;
            BitmapImage image = new BitmapImage(new Uri(imagePath, UriKind.Relative));
            Image = DataTransform.JpgToByte(image);
        }
    }
}
