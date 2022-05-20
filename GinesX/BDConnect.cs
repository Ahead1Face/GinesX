using GinesX.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GinesX
{
    class BDConnect : DbContext
    {
        DbSet<User> User;
        DbSet<Game> Game;
        public BDConnect()
        {

        }
    }
}
