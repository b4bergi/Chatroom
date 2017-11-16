using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatroomDB
{
    public class Chatroom
    {
        public string ChatroomName { get; set; }
        public int UserCount { get; set; }
        public virtual List<User> MyProperty { get; set; }
    }
}
