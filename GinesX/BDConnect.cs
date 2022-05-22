using GinesX.Model;
using System.Data.Entity;

namespace GinesX
{
    public class BDConnect : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Game> Game { get; set; }
        public BDConnect()
        {

        }
    }
}
