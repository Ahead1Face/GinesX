using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GinesX.Model
{
    class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Price { get; set; }

        List<User> Users;
    }
}
