using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChatroomDB
{
    public class ChatContext : DbContext

    {
        public DbSet<Chatroom> Chatrooms { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
