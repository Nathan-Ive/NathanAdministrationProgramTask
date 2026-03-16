using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationProgramNathan
{
    internal class Program
    {
        static void Main(string[] args)
        {

            User user1 = new User("N", "Pmh 24", "123456789", "Gmail", 22);

            user1.SayHello();

        }
    }
}
