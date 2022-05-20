using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GinesX.Model
{
    class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public byte[] avatar { get; set; }
        List<Game> Games;
        public User()
        {
            Id = 0;
            Login = "";
            Email = "";
            Password = "";
            this.avatar = new byte[0];
        }
        public User(int id, string login, string email, string password, byte[] avatar)
        {
            Id = id;
            Login = login;
            Email = email;
            Password = password;
            this.avatar = new byte[0];
        }
    }
}
